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
    public partial class ManagementStorage : Form
    {
        FastFoodServiceClient db = new FastFoodServiceClient();
        public List<OrderImportDetail> orderdetail = new List<OrderImportDetail>();
        public ManagementStorage()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dataGridView1.DataSource = db.getProductByCategory(2);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                string product = row.Cells["productIDDataGridViewTextBoxColumn"].Value.ToString();
                textBox1.Text = product;
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    OrderImportDetail od = new OrderImportDetail();
                    Product pr = new Product();
                    pr = db.getProductByID(textBox1.Text);
                    od.ProductID = pr.ProductID;
                    od.Quantity = 1;
                    od.UnitPrice = (double)pr.UnitPrice;
                    var p = orderdetail.Where(x => x.ProductID == pr.ProductID).FirstOrDefault();
                    if (p == null)
                    {
                        orderdetail.Add(od);
                    }
                    textBox1.Text = "";
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
        public void loadOrderDetail()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = orderdetail;
 
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "")
                {
                    foreach (OrderImportDetail pr in orderdetail)
                    {
                        if (pr.ProductID == textBox2.Text)
                            orderdetail.Remove(pr);
                    }
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Chọn sản phẩm để xóa");
                }
            }
            catch
            {

            }
            loadOrderDetail();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView2.Rows[rowIndex];
                string product = row.Cells["productIDDataGridViewTextBoxColumn1"].Value.ToString();
                textBox2.Text = product;

            }
            catch
            {

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView2.Columns["Update"].Index)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow row = dataGridView2.Rows[rowIndex];
                    string product = row.Cells["productIDDataGridViewTextBoxColumn1"].Value.ToString();
                    int quantity = int.Parse(row.Cells["quantityDataGridViewTextBoxColumn"].Value.ToString());
                    foreach (OrderImportDetail or in orderdetail)
                    {
                        if (or.ProductID == product)
                        {
                            or.Quantity = quantity;
                        }
                    }
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OrderImport order = new OrderImport();
                string orderID = "HDN" + DateTime.Now.Ticks.ToString();
                order.OrderImportID = orderID;
                order.DateImport = DateTime.Now;
                double totalprice = 0;
                foreach (OrderImportDetail or in orderdetail)
                {
                    totalprice = (double)or.Quantity * (double)or.UnitPrice;
                }
                order.TotalPrice = totalprice - (totalprice * 10 / 100);
                if (totalprice != 0)
                {
                    if (db.InsertOrderImport(order) == true)
                    {
                        MessageBox.Show("Tạo hóa đơn thành công !!!");

                    }
                    foreach (OrderImportDetail or in orderdetail)
                    {
                        OrderImportDetail ordt = new OrderImportDetail();
                        Storage storage = new Storage();

                        ordt.OrderImportID = orderID;
                        ordt.ProductID = or.ProductID;
                        ordt.Quantity = or.Quantity;
                        ordt.UnitPrice = or.UnitPrice - or.UnitPrice * 10 / 100;
                        db.InsertOrderImportDetail(ordt);

                        Storage x = db.GetProductInStorage(ordt.ProductID);
                        if (x != null)
                        {
                            db.UpdateProductToStorage(ordt.ProductID, (int)ordt.Quantity);
                        }
                        else
                        {
                            db.InsertProductToStorage(ordt.ProductID, (int)ordt.Quantity);
                        }
                    }
                }
                else
                    MessageBox.Show("Vui lòng chọn sản phẩm");
            }
            catch { }
        }

    }
}
