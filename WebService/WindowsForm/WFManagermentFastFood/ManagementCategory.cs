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
    public partial class ManagementCategory : Form
    {
        FastFoodServiceClient db = new FastFoodServiceClient();
        public ManagementCategory()
        {
            InitializeComponent();
            LoadData();
            txtCategoryID.Enabled = false;
            Enable("load");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            dataGridViewCategory.DataSource = db.getAllCategory();
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;// lấy ra chỉ số dòng hiên tại
                DataGridViewRow row = dataGridViewCategory.Rows[rowIndex];// lấy ra dong hiện tại
                int cateID = int.Parse(row.Cells["ID"].Value.ToString());// lấy giá trị của ô ID
                Category cate = new Category();
                cate = db.getCategoryByID(cateID);// lấy danh mục theo id
                txtCategoryID.Text = cate.ID.ToString();
                txtCategoryID.Enabled = false;
                txtCategoryName.Text = cate.CategoryName;
                Enable("xoasua");
            }
            catch { 
            
            }
            
        }
        public void Enable(string acction)
        {
            if (acction == "load")
            {
                btnDel.Enabled = false;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
            }
            if (acction == "them")
            {
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
                btnAdd.Enabled = true;
            }
            if (acction == "xoasua")
            {
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
                btnAdd.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Enable("them");
            txtCategoryName.Text = "";
            txtCategoryID.Text = "";
            txtCategoryID.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Category cate = new Category()
                {
                    
                    CategoryName = txtCategoryName.Text,
                    ID = Convert.ToInt32(txtCategoryID.Text)
                };
                db.insertCategory(cate);// thêm mới danh mục vào csdl
                LoadData();
                txtCategoryID.Enabled = false;
                txtCategoryID.Text = "";
                txtCategoryName.Text = "";
                Enable("load");
                MessageBox.Show("Thêm thành công");

            }
            catch {
                MessageBox.Show("Thêm thất bại");
            
            }
            

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategoryID.Text != "")
                {
                    int cateID = int.Parse(txtCategoryID.Text);
                    if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa danh mục đã chọn"), "Xác Nhận xóa",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (db.deteteCategory(cateID) == true)// nếu xóa danh mục thành công thông báo
                        {
                            MessageBox.Show("Xóa thành công !");
                            LoadData();
                            txtCategoryID.Enabled = false;
                            txtCategoryID.Text = "";
                            txtCategoryName.Text = "";
                            Enable("load");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại !");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chon sản danh mục muốn xóa !");
                }
            }
            catch { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int cateID = int.Parse(txtCategoryID.Text);
                Category cate = db.getCategoryByID(cateID);
                cate.CategoryName = txtCategoryName.Text;
                db.updateCategory(cate);// sửa danh mục
                LoadData();
                txtCategoryID.Enabled = false;
                Enable("load");
                txtCategoryID.Text = "";
                txtCategoryName.Text = "";
                MessageBox.Show("Sửa thành công !");
            }
            catch {
                MessageBox.Show("Sửa thất bại !");
            }
        }
    }
}
