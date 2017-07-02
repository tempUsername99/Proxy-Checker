using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace Proxy_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы|*.txt";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            var proxiesCount = Data.LoadProxies(openFileDialog1.FileName);



            if (proxiesCount > 0)
            {
                MessageBox.Show("Прокси загружены");
            }
            else
            {
                MessageBox.Show("Неудалось загрузить прокси, проверьте текстовый файл");
            }

            ProxiesCountLbl.Text = proxiesCount + "";
            progressBar1.Maximum = proxiesCount;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (urlBox.Text.Trim() == "" || threadsBox.Text.Trim() == "" || comboBox1.SelectedIndex == -1 || Data.Proxies == null || Data.Proxies.Count == 0 || Data.Threads.Count == 0)
                {
                    MessageBox.Show("Вы что-то не заполнили или не загрузили базу прокси");
                    return;
                }

                Data.proxyType = comboBox1.SelectedIndex;
                Data.threadCount = int.Parse(threadsBox.Text);
                Data.url = urlBox.Text;


                for(int i = 0; i < Data.threadCount; i++)
                {
                    var th = new Thread(body);
                    th.IsBackground = true;
                    Data.Threads.Add(th);
                }

                foreach(var t in Data.Threads)
                {
                    t.Start();
                }
            }
            catch { MessageBox.Show("Что-то пошло не так, попробуйте снова"); }
           
        }

        private string getNextProxy()
        {
            lock (Data.lockableObject)
            {
                try
                {
                    return Data.Proxies[Data.proxyIndex++];
                }
                catch { Data.proxyIndex = 0; return Data.Proxies[Data.proxyIndex]; }
            }
        }

        private void body()
        {
            while(true)
            {
                try
                {
                    var currentLine = getNextProxy();
                    if (currentLine == "Finish") return;
                    if (!(currentLine.Contains(":") || currentLine.Contains(";"))) continue;

                    var req = new HttpRequest();
                    req.Proxy.ConnectTimeout = 20000;
                    req.ConnectTimeout = 20000;
                    req.IgnoreProtocolErrors = true;

                    switch (Data.proxyType)
                    {
                        case 0:
                            {
                                req.Proxy = HttpProxyClient.Parse(currentLine);
                                break;
                            }
                        case 1:
                            {
                                req.Proxy = Socks4ProxyClient.Parse(currentLine);
                                break;
                            }
                        case 2:
                            {
                                req.Proxy = Socks5ProxyClient.Parse(currentLine);
                                break;
                            }
                        default: break;
                    }

                    req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";
                    req.Cookies = new CookieDictionary();

                    var checkReq = req.Get(Data.url);

                    progressBar1.Invoke(new Action(() => { progressBar1.Value++; }));
                    GoodProxieslbl.Invoke(new Action(() => { GoodProxieslbl.Text = (int.Parse(GoodProxieslbl.Text) + 1) + ""; }));
                    dataGridView1.Invoke(new Action(() => { dataGridView1.Rows.Add(currentLine, checkReq.StatusCode) }));
                    lock (Data.lockableObject) File.AppendAllText("Good.txt", currentLine + Environment.NewLine);
                }
                catch
                {
                    BadProxieslbl.Invoke(new Action(() => { BadProxieslbl.Text = (int.Parse(BadProxieslbl.Text) + 1) + ""; }));
                    progressBar1.Invoke(new Action(() => { progressBar1.Value++; }));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var th = new Thread(Data.KillThreads);
            th.IsBackground = true;
            th.Start();
        }
    }
}
