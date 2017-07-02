using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy_Checker
{
    static class Data
    {
        static Data()
        {
            Threads = new List<Thread>();
            GoodProxies = new List<string>();
            lockableObject = new object();
            proxyIndex = 0;
        }

        public static object lockableObject { get; set; }

        public static List<string> Proxies { get; set; }
        public static List<string> GoodProxies { get; set; }
        public static List<Thread> Threads { get; set; }
        public static int threadCount { get; set; }
        public static int proxyType { get; set; }
        public static string url { get; set; }

        public static int proxyIndex { get; set; }

        public static int LoadProxies(string path)
        {
            try
            {
                Proxies = File.ReadAllLines(path).Distinct().ToList();
                return Proxies.Count;
            }
            catch { return 0; }
        }

        public static void KillThreads()
        {
            foreach (var thread in Threads)
            {
                try
                {
                    thread.Abort();
                }
                catch { }
            }
            MessageBox.Show("Работа закончена!");
        }

        public static void dataReset()
        {
            Proxies = null;
            GoodProxies = null;
            proxyIndex = 0;
        }
    }
}
