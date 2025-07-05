namespace CSharpEgitimKampiFinansalCrm
{
    partial class FrmSettings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltotalBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_last_havale = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_son_havale = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 116);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ödenen Ve Ödenmesi\r\nGereken Fatura Miktarları \r\nAşağıdaki grafikten\r\n ulaşabilirs" +
    "iniz ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 87);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bankalar Ve Bankalardaki \r\nPara Miktarlarına Aşağıdaki \r\ngrafikten ulaşabilirsini" +
    "z ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(316, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 135);
            this.panel3.TabIndex = 21;
            // 
            // chart2
            // 
            chartArea11.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart2.Legends.Add(legend11);
            this.chart2.Location = new System.Drawing.Point(666, 304);
            this.chart2.Name = "chart2";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Legend = "Legend1";
            series11.Name = "Faturalar";
            this.chart2.Series.Add(series11);
            this.chart2.Size = new System.Drawing.Size(332, 315);
            this.chart2.TabIndex = 20;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea12.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart1.Legends.Add(legend12);
            this.chart1.Location = new System.Drawing.Point(315, 304);
            this.chart1.Name = "chart1";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(332, 315);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // lbltotalBalance
            // 
            this.lbltotalBalance.AutoSize = true;
            this.lbltotalBalance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltotalBalance.ForeColor = System.Drawing.Color.Black;
            this.lbltotalBalance.Location = new System.Drawing.Point(6, 60);
            this.lbltotalBalance.Name = "lbltotalBalance";
            this.lbltotalBalance.Size = new System.Drawing.Size(113, 45);
            this.lbltotalBalance.TabIndex = 4;
            this.lbltotalBalance.Text = "0.00 ₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Bakiye";
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillAmount.ForeColor = System.Drawing.Color.Black;
            this.lblBillAmount.Location = new System.Drawing.Point(6, 60);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(113, 45);
            this.lblBillAmount.TabIndex = 5;
            this.lblBillAmount.Text = "0.00 ₺";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltitle.ForeColor = System.Drawing.Color.Black;
            this.lbltitle.Location = new System.Drawing.Point(9, 15);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(149, 29);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "Fatura Başlığı ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(666, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 135);
            this.panel4.TabIndex = 22;
            // 
            // lbl_last_havale
            // 
            this.lbl_last_havale.AutoSize = true;
            this.lbl_last_havale.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_last_havale.ForeColor = System.Drawing.Color.Black;
            this.lbl_last_havale.Location = new System.Drawing.Point(6, 60);
            this.lbl_last_havale.Name = "lbl_last_havale";
            this.lbl_last_havale.Size = new System.Drawing.Size(113, 45);
            this.lbl_last_havale.TabIndex = 6;
            this.lbl_last_havale.Text = "0.00 ₺";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_last_havale);
            this.groupBox3.Controls.Add(this.lbl_son_havale);
            this.groupBox3.Location = new System.Drawing.Point(785, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 120);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // lbl_son_havale
            // 
            this.lbl_son_havale.AutoSize = true;
            this.lbl_son_havale.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_son_havale.ForeColor = System.Drawing.Color.Black;
            this.lbl_son_havale.Location = new System.Drawing.Point(9, 15);
            this.lbl_son_havale.Name = "lbl_son_havale";
            this.lbl_son_havale.Size = new System.Drawing.Size(186, 29);
            this.lbl_son_havale.TabIndex = 5;
            this.lbl_son_havale.Text = "Son Gelen Havale";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(138)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 605);
            this.panel1.TabIndex = 14;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(4, 522);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(301, 66);
            this.button8.TabIndex = 5;
            this.button8.Text = "Çıkış Yap";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(4, 448);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(301, 66);
            this.button7.TabIndex = 6;
            this.button7.Text = "Ayarlar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(4, 374);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(301, 66);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(4, 300);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(301, 66);
            this.button5.TabIndex = 4;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(4, 226);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(301, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "Giderler";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(4, 152);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(301, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(4, 78);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bankalar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBillAmount);
            this.groupBox2.Controls.Add(this.lbltitle);
            this.groupBox2.Location = new System.Drawing.Point(550, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 120);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltotalBalance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(315, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 120);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 28);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard Formu";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltotalBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_last_havale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_son_havale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}