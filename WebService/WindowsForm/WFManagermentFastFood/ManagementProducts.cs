﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WFManagermentFastFood.FastFoddService;

namespace WFManagermentFastFood
{
    public partial class ManagementProducts : Form
    {
        public ManagementProducts()
        {
            InitializeComponent();
            loadData();
            txtImage.Enabled = false;
            Enable("load");
        }

        FastFoodServiceClient db = new FastFoodServiceClient();

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image = new Bitmap(Image.FromFile(dlg.FileName), this.pictureBox1.Width, this.pictureBox1.Height);
                        this.txtImage.Text = dlg.FileName.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Dung lượng ảnh quá lớn.Vui lòng chọn ảnh khác", "Lỗi chọn ảnh");
                    }
                }
            }
        }

        public void Enable(string acction)
        {
            if (acction == "load")
            {
                btnDelete.Enabled = false;
                btnInsert.Enabled = false;
                btnUpdate.Enabled = false;
            }
            if (acction == "them")
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnInsert.Enabled = true;
            }
            if (acction == "xoasua")
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnInsert.Enabled = false;
            }
        }

        public void loadData()
        {
            dataGridViewProduct.DataSource = db.getAllProduct();

            //List<productCustomize> list = new List<productCustomize>();
            //foreach (Product p in db.getAllProduct())
            //{
            //    productCustomize p1 = new productCustomize()
            //    {
            //        ProductID = p.ProductID,
            //        ProductName = p.ProductName,
            //        Discount = (int)p.Discount,
            //        Display = (bool)p.Display,
            //        UnitPrice = (double)p.UnitPrice,
            //        CategoryID = (int)p.CategoryID
            //    };
            //    list.Add(p1);
            //}
            //dataGridViewProduct.DataSource = list;


            comboBoxCategory.DataSource = db.getAllCategory();
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "ID";


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            getData(product);
            if (db.insertProduct(product) == true)
            {
                MessageBox.Show("Thêm sản phẩm thành công !");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại !");
            }
            loadData();

        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                Enable("xoasua");
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewProduct.Rows[rowIndex];
                string productname = row.Cells["ProductID"].Value.ToString();
                Product p = new Product();
                p = db.getProductByID(productname);
                txtProductID.Enabled = false;
                txtProductID.Text = p.ProductID;
                txtProductName.Text = p.ProductName;
                txtUnitPrice.Text = p.UnitPrice.ToString();
                txtVote.Text = p.Vote.ToString();
                txtDiscount.Text = p.Discount.ToString();
                txtDescription.Text = p.Description;
                checkBoxDisplay.Checked = (bool)p.Display;
                comboBoxCategory.SelectedValue = p.CategoryID;

                //byte[] img_arr1 = (byte[])p.Image;
                pictureBox1.Image = null;
                if (p.Image != null)
                {
                    MemoryStream ms1 = new MemoryStream((Byte[])p.Image);
                    Image RetImage = Image.FromStream(ms1);
                    pictureBox1.Image = RetImage;
                }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            getData(p);
            if (db.updateProduct(p) == true)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            loadData();
            clearData();
        }

        public Product getData(Product p)
        {

            p.ProductID = txtProductID.Text;
            //ProductName
            if (txtProductName.Text == "" || txtUnitPrice.Text == "" || txtDiscount.Text == "" || txtVote.Text == ""
                || txtDescription.Text == ""
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                //UnitPrice
                p.UnitPrice = Int32.Parse(txtUnitPrice.Text);
                p.ProductName = txtProductName.Text;

                //Discount
                p.Discount = Int32.Parse(txtDiscount.Text);
                //Vote
                p.Vote = Int32.Parse(txtVote.Text);
                //Display
                if (checkBoxDisplay.Checked)
                {
                    p.Display = true;

                }
                else
                    p.Display = false;

                //Description
                p.Description = txtDescription.Text;
                p.CategoryID = Int32.Parse(comboBoxCategory.SelectedValue.ToString());
            }

            if (txtImage.Text != "")
            {
                MemoryStream ms1 = new MemoryStream();
                pictureBox1.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] img_arr1 = ms1.ToArray();
                p.Image = img_arr1;
            }
            return p;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                string product = txtProductID.Text;
                if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa sản phẩm đã chọn"), "Xác Nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (db.deleteProduct(product) == true)
                    {
                        MessageBox.Show("Xóa thành công !");
                        loadData();
                        clearData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chon sản phẩm muốn xóa !");
            }
        }
        public void clearData()
        {
            txtProductID.Enabled = true;
            Enable("them");
            txtProductName.Text = "";
            txtUnitPrice.Text = "";
            txtDiscount.Text = ""; txtVote.Text = "";
            txtDescription.Text = "";
            txtProductID.Text = "";
            txtVote.Text = "";
            pictureBox1.Image = null;
        }

        private void btnInsertNew_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnSearxh_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            //List<productCustomize> list = new List<productCustomize>();
            //foreach (Product p in db.search(search))
            //{
            //    productCustomize p1 = new productCustomize()
            //    {
            //        ProductID = p.ProductID,
            //        ProductName = p.ProductName,
            //        Discount = (int)p.Discount,
            //        Display = (bool)p.Display,
            //        UnitPrice = (double)p.UnitPrice,
            //        CategoryID = (int)p.CategoryID
            //    };
            //    list.Add(p1);
            //}
            //if (list.Count() > 0)
            //{
            //    dataGridViewProduct.DataSource = list;
            //}
            //else
            //{
            //    List<productCustomize> list1 = new List<productCustomize>();
            //    foreach (Product p in db.getAllProduct())
            //    {
            //        productCustomize p1 = new productCustomize()
            //        {
            //            ProductID = p.ProductID,
            //            ProductName = p.ProductName,
            //            Discount = (int)p.Discount,
            //            Display = (bool)p.Display,
            //            UnitPrice = (double)p.UnitPrice,
            //            CategoryID = (int)p.CategoryID
            //        };
            //        list1.Add(p1);
            //    }
            //    dataGridViewProduct.DataSource = list1;
            //}
        }
    }
}
