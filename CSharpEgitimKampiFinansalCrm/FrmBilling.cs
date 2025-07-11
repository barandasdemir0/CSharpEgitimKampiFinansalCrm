﻿using System;
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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities dbEntities = new FinancialCrmDbEntities();
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = dbEntities.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            var values = dbEntities.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string title = txttitle.Text;
            decimal amount = decimal.Parse(txtamount.Text);
            string periot = txtperiot.Text;

            Bill bill = new Bill();
            bill.BillTitle = title;
            bill.BillAmount = amount;
            bill.BillPeriod = periot;
            dbEntities.Bills.Add(bill);
            dbEntities.SaveChanges();
            MessageBox.Show("eklendi");

            var values = dbEntities.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            //var detectedvalues = dbEntities.Bills.Where(x => x.BillId == id).FirstOrDefault();
            var detectedvalues = dbEntities.Bills.Find(id);
            dbEntities.Bills.Remove(detectedvalues);
            dbEntities.SaveChanges();
            MessageBox.Show("silindi");

            var values = dbEntities.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            string title = txttitle.Text;
            string periot = txtperiot.Text;
            decimal amount = decimal.Parse(txtamount.Text);

            var valuesid = dbEntities.Bills.Find(id);


            valuesid.BillTitle = title;
            valuesid.BillPeriod = periot;
            valuesid.BillAmount = amount;
            dbEntities.SaveChanges();
            MessageBox.Show("güncellendi");

            var values = dbEntities.Bills.ToList();
            dataGridView1.DataSource = values;



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
