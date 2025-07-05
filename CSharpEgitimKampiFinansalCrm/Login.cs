using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampiFinansalCrm.Models;

namespace CSharpEgitimKampiFinansalCrm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities dbEntities = new FinancialCrmDbEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
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
            string username = textBox1.Text;
           string password = textBox2.Text;
            var detedtecUser = dbEntities.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (detedtecUser != null )
            {
                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("giriş olmaz");
            }

        }
    }
}
