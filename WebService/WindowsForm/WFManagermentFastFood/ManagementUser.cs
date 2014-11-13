using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFManagermentFastFood.Properties;
using WFManagermentFastFood.FastFoddService;

namespace WFManagermentFastFood
{
    public partial class ManagementUser : Form
    {
        FastFoddService.FastFoodServiceClient db = new FastFoddService.FastFoodServiceClient();
        public ManagementUser()
        {
            InitializeComponent();
            Enable("load");
            GetAllUser();
        }
        public void GetAllUser()
        {

            try
            {
                List<Account> list = new List<Account>();
                dataGridViewGetAllUser.DataSource = db.getAllAccount();
                List<UserType> listUserType = new List<UserType>();
                UserType[] s = db.getAllUserType();
                foreach (UserType c in s)
                {
                    listUserType.Add(c);
                }

                comboBoxRole.DataSource = listUserType;
                comboBoxRole.DisplayMember = "UserType1";
                comboBoxRole.ValueMember = "ID";
            }
            catch { }
        }
        public void Enable(string acction)
        {
            if (acction == "load")
            {
                btnxoa.Enabled = false;
                btnthem.Enabled = false;
                btnsua.Enabled = false;
            }
            if (acction == "them")
            {
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnthem.Enabled = true;
            }
            if (acction == "xoasua")
            {
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnthem.Enabled = false;
            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewGetAllUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridViewGetAllUser.Rows[rowIndex];
                string userName = row.Cells["UserName"].Value.ToString();
                Account ac = new Account();
                ac = db.getAccountByID(userName);
                txtUserName.Enabled = false;
                txtUserName.Text = ac.UserName;
                txtPass.Text = ac.Password.ToString();
                txtName.Text = ac.Name;
                txtEmail.Text = ac.Email;
                txtAddress.Text = ac.Address;
                txtPhone.Text = ac.Phone;
                comboBoxRole.SelectedValue = ac.UserTypeID;
                Enable("xoasua");
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            txtUserName.Enabled = true;
            txtUserName.Text = "";
            txtPhone.Text = "";
            txtPass.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            GetAllUser();
            Enable("them");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPass.Text == ""
                    || txtPhone.Text == "" || txtUserName.Text == "")
                {
                    MessageBox.Show("Chưa điền đầy đủ thông tin vui lòng nhập lại");
                }
                else
                {
                    Account acc = new Account();
                    acc.UserName = txtUserName.Text;
                    acc.Password = txtPass.Text;
                    acc.Phone = txtPhone.Text;
                    acc.Email = txtEmail.Text;
                    acc.Name = txtName.Text;
                    acc.Address = txtAddress.Text;
                    acc.UserTypeID = Int32.Parse(comboBoxRole.SelectedValue.ToString());
                    if (db.insertAccount(acc) == true)
                    {
                        MessageBox.Show("Thêm thành công !");
                        clear();
                        GetAllUser();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại !");
                    }
                }
            }
            catch { }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != "")
                {
                    string userName = txtUserName.Text;
                    if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa ?"), "Xác Nhận xóa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (db.deteteAccount(userName) == true)
                        {
                            MessageBox.Show("Xóa thành công !");
                            clear();
                            GetAllUser();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại !");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chon tài khoản muốn xóa !");
                }
            }
            catch { }
        }
        public void clear()
        {
            txtUserName.Text = "";
            txtPass.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                Account acc = new Account();
                acc.UserName = txtUserName.Text;
                acc.Password = txtPass.Text;
                acc.Phone = txtPhone.Text;
                acc.Email = txtEmail.Text;
                acc.Name = txtName.Text;
                acc.Address = txtAddress.Text;
                acc.UserTypeID = Int32.Parse(comboBoxRole.SelectedValue.ToString());
                if (db.updateAccount(acc) == true)
                {
                    MessageBox.Show("Cập nhật thành công !");
                    clear();
                    GetAllUser();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                }
            }
            catch { }
        }
    }
}
