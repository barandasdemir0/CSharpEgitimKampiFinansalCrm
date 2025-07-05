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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities dbEntities = new FinancialCrmDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {

            FrmCategories categories = new FrmCategories();
            categories.Show();
            this.Hide();
        }

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

        private void button8_Click(object sender, EventArgs e)
        {
            Login log_Out = new Login();
            log_Out.Show();
            this.Hide();
        }

        void spendings()
        {
            var result = dbEntities.Categories.Select(x => new
            {
                x.CategoryName,
                Spending = x.Spendings.Count()
            }).ToList();
            dataGridView1.DataSource = result;

        }
        private void btnlist_Click(object sender, EventArgs e)
        {
            var result = dbEntities.Categories.Select(x => new
            {
                x.CategoryName,
                Spending = x.Spendings.Count()
            }).ToList();
            dataGridView1.DataSource = result;

            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            Category kategoriler = new Category();
            kategoriler.CategoryName = categoryName;
            dbEntities.Categories.Add(kategoriler);
            dbEntities.SaveChanges();
            MessageBox.Show("eklendi");
            var values = dbEntities.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(txtid.Text);
            var deletedValues = dbEntities.Categories.Find(categoryId);
            dbEntities.Categories.Remove(deletedValues);
            dbEntities.SaveChanges();
            MessageBox.Show("silindi");
            var values = dbEntities.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(txtid.Text);
            string name = txtCategoryName.Text;

            var updatedValues = dbEntities.Categories.Find(categoryId);
            updatedValues.CategoryName = name;
            dbEntities.SaveChanges();
            MessageBox.Show("Güncellendi");
            var values = dbEntities.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            spendings();
        }
    }
}
