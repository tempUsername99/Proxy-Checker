namespace Proxy_Checker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLabel1 = new System.Windows.Forms.Label();
            this.ProxiesCountLbl = new System.Windows.Forms.Label();
            this.GoodProxieslbl = new System.Windows.Forms.Label();
            this.textLabel2 = new System.Windows.Forms.Label();
            this.BadProxieslbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.threadsBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить прокси";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(218, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(408, 264);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BadProxieslbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.GoodProxieslbl);
            this.groupBox1.Controls.Add(this.textLabel2);
            this.groupBox1.Controls.Add(this.ProxiesCountLbl);
            this.groupBox1.Controls.Add(this.textLabel1);
            this.groupBox1.Location = new System.Drawing.Point(15, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // textLabel1
            // 
            this.textLabel1.AutoSize = true;
            this.textLabel1.Location = new System.Drawing.Point(6, 16);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(48, 13);
            this.textLabel1.TabIndex = 0;
            this.textLabel1.Text = "Прокси:";
            // 
            // ProxiesCountLbl
            // 
            this.ProxiesCountLbl.AutoSize = true;
            this.ProxiesCountLbl.Location = new System.Drawing.Point(72, 16);
            this.ProxiesCountLbl.Name = "ProxiesCountLbl";
            this.ProxiesCountLbl.Size = new System.Drawing.Size(13, 13);
            this.ProxiesCountLbl.TabIndex = 1;
            this.ProxiesCountLbl.Text = "0";
            // 
            // GoodProxieslbl
            // 
            this.GoodProxieslbl.AutoSize = true;
            this.GoodProxieslbl.Location = new System.Drawing.Point(72, 32);
            this.GoodProxieslbl.Name = "GoodProxieslbl";
            this.GoodProxieslbl.Size = new System.Drawing.Size(13, 13);
            this.GoodProxieslbl.TabIndex = 3;
            this.GoodProxieslbl.Text = "0";
            // 
            // textLabel2
            // 
            this.textLabel2.AutoSize = true;
            this.textLabel2.Location = new System.Drawing.Point(6, 32);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.Size = new System.Drawing.Size(61, 13);
            this.textLabel2.TabIndex = 2;
            this.textLabel2.Text = "Валидные:";
            // 
            // BadProxieslbl
            // 
            this.BadProxieslbl.AutoSize = true;
            this.BadProxieslbl.Location = new System.Drawing.Point(72, 48);
            this.BadProxieslbl.Name = "BadProxieslbl";
            this.BadProxieslbl.Size = new System.Drawing.Size(13, 13);
            this.BadProxieslbl.TabIndex = 5;
            this.BadProxieslbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Плохие:";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(74, 41);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(138, 20);
            this.urlBox.TabIndex = 3;
            this.urlBox.Text = "http://ya.ru";
            this.urlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "URL:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 253);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(197, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HTTP/S",
            "SOCKS4",
            "SOCKS5"});
            this.comboBox1.Location = new System.Drawing.Point(12, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Тип прокси";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Прокси";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "StatusCode";
            this.Column2.Name = "Column2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Потоков:";
            // 
            // threadsBox
            // 
            this.threadsBox.Location = new System.Drawing.Point(74, 67);
            this.threadsBox.Name = "threadsBox";
            this.threadsBox.Size = new System.Drawing.Size(138, 20);
            this.threadsBox.TabIndex = 9;
            this.threadsBox.Text = "50";
            this.threadsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Стоп";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 295);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.threadsBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Proxy Checker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label BadProxieslbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label GoodProxieslbl;
        private System.Windows.Forms.Label textLabel2;
        private System.Windows.Forms.Label ProxiesCountLbl;
        private System.Windows.Forms.Label textLabel1;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox threadsBox;
        private System.Windows.Forms.Button button3;
    }
}

