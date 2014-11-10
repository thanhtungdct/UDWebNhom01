using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFManagermentFastFood.FastFoddService;

namespace WFManagermentFastFood
{
    public partial class ManagementOrder : Form
    {
        FastFoddService.FastFoodServiceClient db = new FastFoddService.FastFoodServiceClient();
        public ManagementOrder()
        {
            InitializeComponent();
            dataGridViewOrder.DataSource = db.getAllOrder();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewOrder.Columns["Edit"].Index)
            {
               // Order order = Order
                
                try {
                    Order order = new Order();
                    int rowIndex = e.RowIndex;
                    DataGridViewRow row = dataGridViewOrder.Rows[rowIndex];
                    string OrderID = row.Cells["OrderID"].Value.ToString();
                    order = db.getOrderByID(OrderID);
                    order.Status =(bool)row.Cells["Status"].Value;
                    db.updateOrder(order);
                    dataGridViewOrder.DataSource = db.getAllOrder();
                }
                catch { }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dataGridViewOrder.DataSource = db.getAllOrder();

            }
            else
                dataGridViewOrder.DataSource = db.getOrderByID(txtSearch.Text);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridViewOrder.Rows[rowIndex];
            string OrderID = row.Cells["OrderID"].Value.ToString();
            dataGridViewDetailOrder.DataSource = db.getOrderDetailByID(OrderID);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            ManagementAddNewOrder f = new ManagementAddNewOrder();
            f.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            Management f = new Management();
            f.Show();
        }
    }
}
