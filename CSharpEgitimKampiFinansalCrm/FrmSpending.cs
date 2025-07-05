using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampiFinansalCrm.Models;

namespace CSharpEgitimKampiFinansalCrm
{
    public partial class FrmSpending : Form
    {
        public FrmSpending()
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

        private void button8_Click(object sender, EventArgs e)
        {
            Login log_Out = new Login();
            log_Out.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories categories = new FrmCategories();
            categories.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
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

        private void btnlist_Click(object sender, EventArgs e)
        {
            var result = dbEntities.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                Category = x.Category.CategoryName

            }).ToList();
            //var result = dbEntities.Spendings.ToList();
            dataGridView1.DataSource = result;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string title = txttitle.Text;
            int amount = int.Parse(txtamount.Text);
            DateTime spendingDate = DateTime.Parse(dateTimePicker1.Text);
            int categoryId = int.Parse(comboBox1.SelectedIndex.ToString());


            Spending spending = new Spending();
            spending.SpendingTitle = title;
            spending.SpendingAmount = amount;
            spending.SpendingDate = spendingDate;
            spending.CategoryId = categoryId;


            dbEntities.Spendings.Add(spending);
            dbEntities.SaveChanges();
            MessageBox.Show("ekleme başarılı");
        }

        private void FrmSpending_Load(object sender, EventArgs e)
        {
            var categories = dbEntities.Categories.ToList();
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            string title = txttitle.Text;
            decimal amount = decimal.Parse(txtamount.Text);
            DateTime dateTime = DateTime.Parse(dateTimePicker1.Text);
            int categoryId = int.Parse(comboBox1.SelectedIndex.ToString());
            var updatedValue = dbEntities.Spendings.Find(id);
            updatedValue.SpendingTitle = title;
            updatedValue.SpendingAmount = amount;
            updatedValue.SpendingDate = dateTime;
            updatedValue.CategoryId = categoryId;
            dbEntities.SaveChanges();
            MessageBox.Show("güncellendi");


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deletedValues = dbEntities.Spendings.Find(id);
            dbEntities.Spendings.Remove(deletedValues);
            dbEntities.SaveChanges();
            MessageBox.Show("silindi");
        }
    }
}
