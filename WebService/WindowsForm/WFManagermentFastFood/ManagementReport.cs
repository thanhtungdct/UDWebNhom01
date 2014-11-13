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
    public partial class ManagementReport : Form
    {
        private FastFoodServiceClient db = new FastFoodServiceClient();
        public ManagementReport()
        {
            InitializeComponent();
            comboBoxQuarter.SelectedIndex = 0;
            LoaderDataForCombobox();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

      
        public void loadData(Order[] s,DataGridView dtgv,Label lb)
        {
            try
            {
                double totalprice = 0;
                List<productCustomize> list = new List<productCustomize>();
                foreach (Order x in s)
                {
                    OrderDetail[] or = db.getOrderDetailReprort(x.OrderID);
                    foreach (OrderDetail ordt in or)
                    {
                        totalprice += x.TotalPrice;
                        productCustomize prc = new productCustomize();
                        prc.ProductID = ordt.ProductID;
                        prc.Quantity = ordt.Quantity;
                        prc.UnitPrice = ordt.UnitPrice;
                        //prc.ProductName = ordt.Product.ProductName;
                        var p = list.Where(c => c.ProductID == prc.ProductID).FirstOrDefault();
                        if (p != null)
                        {
                            p.Quantity += prc.Quantity;
                        }
                        else
                        {
                            list.Add(prc);
                        }
                    }


                }
                string price = String.Format("{0:0,0 VNĐ}", Convert.ToInt32(totalprice));
                lb.Text = price;
                list = list.OrderByDescending(p => p.Quantity).ToList();
                dtgv.DataSource = list;
            }
            catch { }

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void btnDate_Click(object sender, EventArgs e)
        {
            //string theDate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            DateTime dt = dateTimePickerDay.Value;
            Order[] s = db.getOrderByDay(dt);

            dataGridViewDay.DataSource = db.getOrderByDay(dt);
            loadData(s, dataGridViewProductDay, lbTotalPriceDay);

        }
        private void btnMonth_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePickerMonth.Value;
            Order[] s = db.getOrderByMonth(dt);

            dataGridViewMonth.DataSource = db.getOrderByMonth(dt);
            loadData(s, dataGridViewProductMonth, lbTotalMonth);
        }

        private void btnQuarter_Click(object sender, EventArgs e)
        {

            DateTime dt = dateTimePickerMonth.Value;
            int year =int.Parse( comboBoxQuarterYear.SelectedValue.ToString());
            if (comboBoxQuarter.SelectedIndex != 0 )
            {
                int quarter = comboBoxQuarter.SelectedIndex;
                Order[] s = db.getOrderByQuarterly(quarter, year);

                dataGridViewQuarter.DataSource = db.getOrderByQuarterly(quarter, year);
                loadData(s, dataGridViewProductQuarter, lbTotalQuarter);
            }
        }
        public void LoaderDataForCombobox()// load du lieu vao combobox 
        {
            List<ComboboxItem> list = new List<ComboboxItem>();
            for (int i = 2000; i < 2050; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = i;
                item.Text = i.ToString();
                list.Add(item);
            }
            
            comboBoxQuarterYear.DataSource = list;
            comboBoxQuarterYear.DisplayMember = "Text";
            comboBoxQuarterYear.ValueMember = "Value";
            int year = DateTime.Now.Year;
            comboBoxQuarterYear.SelectedValue = year;

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            ManagementReportFile f = new ManagementReportFile();
            f.Show();
        }

    }
}
