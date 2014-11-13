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
            if (e.ColumnIndex == dataGridViewOrder.Columns["Edit"].Index)// bắt sự kiện cell click, lấy ra cột có ID là Edit
            {
               // Order order = Order
                
                try {
                    Order order = new Order();
                    int rowIndex = e.RowIndex;
                    DataGridViewRow row = dataGridViewOrder.Rows[rowIndex];
                    string OrderID = row.Cells["OrderID"].Value.ToString();
                    order = db.getOrderByID(OrderID);
                    order.Status =(bool)row.Cells["Status"].Value;// lấy trạng thái của hóa đơn (đã giao - chưa giao , đã giao thì checkbox dc chọn)
                    db.updateOrder(order);// cập nhật lại trạng thái
                    dataGridViewOrder.DataSource = db.getAllOrder(); // cập nhật lại datasource dataGridViewOrder
                }
                catch { }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dataGridViewOrder.DataSource = db.getAllOrder();// trả về tất các các hóa đơn bán hiễn thị vào dataGridViewOrder

            }
            else
                dataGridViewOrder.DataSource = db.getOrderByID(txtSearch.Text);
            //trả về hóa đơn theo mã hóa đơn hiển thị vào dataGridViewOrder

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewOrder.Rows[rowIndex];
                string OrderID = row.Cells["OrderID"].Value.ToString();// lấy mã hóa đơn để lấy chi tiết hóa đơn
                dataGridViewDetailOrder.DataSource = db.getOrderDetailByID(OrderID);//lấy chi tiết các hóa đơn hiển thị vào dataGridViewDetailOrder
            }
            catch { }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {

            //ManagementAddNewOrder f = new ManagementAddNewOrder();
            //f.Show();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
