using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampiFinansalCrm.Models;

namespace CSharpEgitimKampiFinansalCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities entities = new FinancialCrmDbEntities();
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = entities.Banks.Sum(x => x.BankBalance);
            lbltotalBalance.Text = totalBalance.ToString();

            var lastBankProces = entities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lbl_last_havale.Text = lastBankProces.ToString();







            //chart1 kodları

            var bankdata = entities.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance,
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankdata)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }


            //chart2 kodları

            var billData = entities.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount,
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count %4==1)
            {
                var billTitle1 = entities.Bills.Where(x => x.BillTitle == "elektrik").Select(y => y.BillAmount).FirstOrDefault();
                lbltitle.Text = "elektrik";
                lblBillAmount.Text = billTitle1.ToString();

            }
            else if(count % 4 == 2)
            {
                var billTitle2 = entities.Bills.Where(x => x.BillTitle == "Doğalgaz Faturaso").Select(y => y.BillAmount).FirstOrDefault();
                lbltitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = billTitle2.ToString();

            }
            else if (count % 4 == 3)
            {
                var billTitle3 = entities.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lbltitle.Text = "Su Faturası";
                lblBillAmount.Text = billTitle3.ToString();

            }
            else if(count % 4 == 0)
            {
                var billTitle4 = entities.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lbltitle.Text = "İnternet Faturası";
                lblBillAmount.Text = billTitle4.ToString();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories categories = new FrmCategories();
            categories.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSpending spending = new FrmSpending();
            spending.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login log_Out = new Login();
            log_Out.Show();
            this.Hide();
        }
    }
}
