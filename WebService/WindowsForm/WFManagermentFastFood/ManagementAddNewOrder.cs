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
    public partial class ManagementAddNewOrder : Form
    {
        FastFoodServiceClient db = new FastFoodServiceClient();
        List<OrderDetail> orderdetail = new List<OrderDetail>();
        public ManagementAddNewOrder()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dataGridViewProduct.DataSource = db.getAllProduct();
        }
        public void loadOrderDetail()
        {

            //dataGridViewListProduct.EndEdit();
            dataGridViewListProduct.DataSource = null;
            dataGridViewListProduct.DataSource = orderdetail;
        }

        private void ManagementAddNewOrderForm1_Load(object sender, EventArgs e)
        {
        }
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewProduct.Rows[rowIndex];
                string product = row.Cells["ProductID1"].Value.ToString();
                txtID.Text = product;
            }
            catch
            {
            }
        }

        private void dataGridViewListProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "")
                {
                    OrderDetail od = new OrderDetail();
                    Product pr = new Product();
                    pr = db.getProductByID(txtID.Text);
                    od.ProductID = pr.ProductID;
                    od.Quantity = 1;
                    od.UnitPrice = (double)pr.UnitPrice;

                    var p = orderdetail.Where(x => x.ProductID == pr.ProductID).FirstOrDefault();
                    if (p == null)
                    {
                        orderdetail.Add(od);
                    }
                    txtID.Text = "";
                    loadOrderDetail();
                }
                else
                {

                    MessageBox.Show("Chọn sản phẩm thêm vào hóa đơn");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (OrderDetail pr in orderdetail)
                {
                    if (pr.ProductID == txtDel.Text)
                        orderdetail.Remove(pr);
                }

            }
            catch
            {
            }
            loadOrderDetail();

        }

        private void dataGridViewListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewListProduct.Rows[rowIndex];
                string product = row.Cells["ProductID"].Value.ToString();
                txtDel.Text = product;

            }
            catch
            {

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            string orderID = "HDB" + DateTime.Now.Ticks.ToString();
            order.OrderID = orderID;
            order.UserID = "vantrong";
            order.Name = "";
            order.RecipientAddress = "";
            order.Phone = "";
            order.Email = "";
            order.Payment = "Mua";
            order.Note = "";
            order.Status = true;
            order.DateCreate = DateTime.Today;
            double totalprice = 0;
            foreach (OrderDetail or in orderdetail)
            {
                totalprice = or.Quantity * or.UnitPrice;
            }
            order.TotalPrice = totalprice;
            if (totalprice != 0)
            {
                if (db.insertOrder(order) == true)
                {
                    MessageBox.Show("Tạo hóa đơn thành công !!!");

                }
                foreach (OrderDetail or in orderdetail)
                {
                    OrderDetail ordt = new OrderDetail();
                    ordt.OrderID = orderID;
                    ordt.ProductID = or.ProductID;
                    ordt.Quantity = or.Quantity;
                    ordt.UnitPrice = or.UnitPrice;
                    db.insertOrderDetail(ordt);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn sản phẩm");
        }

        private void dataGridViewListProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewListProduct.Columns["Edit"].Index)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewListProduct.Rows[rowIndex];
                string product = row.Cells["ProductID"].Value.ToString();
                int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                foreach (OrderDetail or in orderdetail)
                {
                    if (or.ProductID == product)
                    {
                        or.Quantity = quantity;
                    }
                }
            }
        }
    }
}
