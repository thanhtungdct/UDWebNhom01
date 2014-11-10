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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public void getdata(string a, string b)
        {
            a = txtPass.Text;
            b = txtUserName.Text;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FastFoodServiceClient db = new FastFoodServiceClient();
            Account [] s = db.login(txtUserName.Text, txtPass.Text);
            if (s.Count() > 0)
            {
                MessageBox.Show("Đăng nhập thành công !");
                ManagementUser m = new ManagementUser();
                m.Show();
            }
            else {
                MessageBox.Show("Đăng nhập thất bại !");
            }
        }
    }
}
