using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using WFManagermentFastFood.FastFoddService;

namespace WFManagermentFastFood
{

    public partial class FormReport : Form
    {
        FastFoodServiceClient db = new FastFoodServiceClient();
        public FormReport()
        {
            InitializeComponent();
            comboBoxQuarter.SelectedIndex = 0;
            LoaderDataForCombobox();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormReport_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnDate_Click(object sender, EventArgs e)
        {

            DateTime dt = dateTimePickerDay.Value;
            Order[] s = db.getOrderByDay(dt);
            List<Order> list = new List<Order>();
            foreach (Order or in s)
            {
                list.Add(or);
            }
            List<OrderDetail> listoddt = orderDetail(s);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetOrderDay", list));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetOrderDetailDay", listoddt));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter_Day", dt.ToString("dd/MM/yyyy")));
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Refresh();

        }


        public List<OrderDetail> orderDetail(Order[] s)
        {
            List<productCustomize> listprod = new List<productCustomize>();
            List<OrderDetail> listoddt = new List<OrderDetail>();

            foreach (Order x in s)
            {
                OrderDetail[] or = db.getOrderDetailReprort(x.OrderID);
                foreach (OrderDetail ordt in or)
                {
                    productCustomize prc = new productCustomize();
                    prc.ProductID = ordt.ProductID;
                    prc.Quantity = ordt.Quantity;
                    prc.UnitPrice = ordt.UnitPrice;
                    var p = listprod.Where(c => c.ProductID == prc.ProductID).FirstOrDefault();
                    if (p != null)
                    {
                        p.Quantity += prc.Quantity;
                    }
                    else
                    {
                        listprod.Add(prc);
                    }
                }
            }

            foreach (productCustomize pr in listprod)
            {
                OrderDetail ordt = new OrderDetail();
                //Product p = db.getProductByID(pr.ProductID);
                //ordt.ProductName = p.ProductName;
                ordt.ProductID = pr.ProductID;
                ordt.Quantity = pr.Quantity;
                ordt.UnitPrice = pr.UnitPrice;
                listoddt.Add(ordt);
            }
            return listoddt;
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePickerMonth.Value;
            Order[] s = db.getOrderByMonth(dt);
            List<Order> list = new List<Order>();
            foreach (Order or in s)
            {
                list.Add(or);
            }
            List<OrderDetail> listoddt = orderDetail(s);
            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSetOrderMonth", list));
            this.reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSetOrderDetailMonth", listoddt));
            this.reportViewer2.LocalReport.SetParameters(new ReportParameter("ReportParameter_Month", dt.Month.ToString()));
            this.reportViewer2.LocalReport.SetParameters(new ReportParameter("ReportParameter_Year", dt.Year.ToString()));
            this.reportViewer2.RefreshReport();
            this.reportViewer2.Refresh();
        }
        public void LoaderDataForCombobox()
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

            comboBoxYear.DataSource = list;
            comboBoxYear.DisplayMember = "Text";
            comboBoxYear.ValueMember = "Value";

            int year = DateTime.Now.Year;
            comboBoxQuarterYear.SelectedValue = year;
            comboBoxYear.SelectedValue = year;

        }

        private void btnQuarter_Click(object sender, EventArgs e)
        {
            
            int year = int.Parse(comboBoxQuarterYear.SelectedValue.ToString());
            if (comboBoxQuarter.SelectedIndex != 0)
            {
                string selecteds = comboBoxQuarter.SelectedItem.ToString().Trim();
                int quarter = comboBoxQuarter.SelectedIndex;
                Order[] s = db.getOrderByQuarterly(quarter, year);
                List<Order> list = new List<Order>();
                foreach (Order or in s)
                {
                    list.Add(or);
                }
                List<OrderDetail> listoddt = orderDetail(s);
                this.reportViewer3.LocalReport.DataSources.Clear();
                this.reportViewer3.LocalReport.DataSources.Add(new ReportDataSource("DataSetOrderQuarter", list));
                this.reportViewer3.LocalReport.DataSources.Add(new ReportDataSource("DataSetOrderDetailQuarter", listoddt));
                this.reportViewer3.LocalReport.SetParameters(new ReportParameter("ReportParameter_Quarter1", selecteds.ToString()));
                this.reportViewer3.LocalReport.SetParameters(new ReportParameter("ReportParameter_Year",year.ToString()));
                this.reportViewer3.RefreshReport();
                this.reportViewer3.Refresh();
                
            }
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            int year =int.Parse( comboBoxYear.SelectedValue.ToString());

            Order[] s = db.getOrderByYear(year);
            List<Order> list = new List<Order>();
            foreach (Order or in s)
            {
                list.Add(or);
            }
            List<OrderDetail> listoddt = orderDetail(s);
            this.reportViewer4.LocalReport.DataSources.Clear();
            this.reportViewer4.LocalReport.DataSources.Add(new ReportDataSource("DataSetOrderYear", list));
            this.reportViewer4.LocalReport.DataSources.Add(new ReportDataSource("DataSetOrderDetailYear", listoddt));
            this.reportViewer4.LocalReport.SetParameters(new ReportParameter("ReportParameter_Year", year.ToString()));
            this.reportViewer4.RefreshReport();
            this.reportViewer4.Refresh();
        }


    }
}