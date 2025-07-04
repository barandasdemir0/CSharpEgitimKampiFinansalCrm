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
    }
}
