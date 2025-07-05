using System;
using System.Linq;
using System.Windows.Forms;
using CSharpEgitimKampiFinansalCrm.Models;

namespace CSharpEgitimKampiFinansalCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities dbEntities = new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            #region banka bakiyeleri

            var ziraatbankBalance = dbEntities.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakifbankBalance = dbEntities.Banks.Where(x => x.BankTitle == "Vakıf Bank").Select(y => y.BankBalance).FirstOrDefault();
            var isbankasıBalance = dbEntities.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblziraatBank.Text = ziraatbankBalance.ToString() + " ₺";
            lblVakifBank.Text = vakifbankBalance.ToString() + " ₺";
            lblisBank.Text = isbankasıBalance.ToString() + " ₺";
            #endregion

            #region banka hareketleri


            var bankProcess1 = dbEntities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            txtLastBankProcess1.Text =  bankProcess1.Description +" "+bankProcess1.ProcessDate+" "+bankProcess1.Amount;

            var bankProcess2 = dbEntities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            txtLastBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.ProcessDate + " " + bankProcess2.Amount;

            var bankProcess3 = dbEntities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            txtLastBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.ProcessDate + " " + bankProcess3.Amount;

            var bankProcess4 = dbEntities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            txtLastBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.ProcessDate + " " + bankProcess4.Amount;

            var bankProcess5 = dbEntities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            txtLastBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.ProcessDate + " " + bankProcess5.Amount;
            #endregion 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblziraatBank_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblVakifBank_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblisBank_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtLastBankProcess5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtLastBankProcess4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtLastBankProcess3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtLastBankProcess2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtLastBankProcess1_Click(object sender, EventArgs e)
        {

        }
    }
}
