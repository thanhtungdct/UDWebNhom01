using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFManagermentFastFood
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            btnManagementOrder.TabStop = false;
            btnManagementOrder.FlatStyle = FlatStyle.Flat;
            btnManagementOrder.FlatAppearance.BorderSize = 0;

            btnManagementCategory.TabStop = false;
            btnManagementCategory.FlatStyle = FlatStyle.Flat;
            btnManagementCategory.FlatAppearance.BorderSize = 0;

            btnManagementProduct.TabStop = false;
            btnManagementProduct.FlatStyle = FlatStyle.Flat;
            btnManagementProduct.FlatAppearance.BorderSize = 0;

            btnManagementUser.TabStop = false;
            btnManagementUser.FlatStyle = FlatStyle.Flat;
            btnManagementUser.FlatAppearance.BorderSize = 0;

            btnReport.TabStop = false;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.FlatAppearance.BorderSize = 0;

            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
        }

        private void btnManagementUser_Click(object sender, EventArgs e)
        {
            ManagementUser f1 = new ManagementUser();
            f1.Show();
        }

        private void btnManagementProduct_Click(object sender, EventArgs e)
        {
            ManagementProducts f = new ManagementProducts();
            f.Show();
        }

        private void btnManagementCategory_Click(object sender, EventArgs e)
        {
            ManagementCategory f = new ManagementCategory();
            f.Show();
        }

        private void btnManagementOrder_Click(object sender, EventArgs e)
        {
           
            ManagementOrder f = new ManagementOrder();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ManagementReport f = new ManagementReport();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagementStorage f = new ManagementStorage();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
