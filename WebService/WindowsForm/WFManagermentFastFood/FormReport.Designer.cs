namespace WFManagermentFastFood
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource16 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDate = new System.Windows.Forms.Button();
            this.dateTimePickerDay = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMonth = new System.Windows.Forms.Button();
            this.dateTimePickerMonth = new System.Windows.Forms.DateTimePicker();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxQuarterYear = new System.Windows.Forms.ComboBox();
            this.comboBoxQuarter = new System.Windows.Forms.ComboBox();
            this.btnQuarter = new System.Windows.Forms.Button();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.orderDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.managementReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.btnYear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataMember = "OrderDetails";
            this.OrderBindingSource.DataSource = typeof(WFManagermentFastFood.FastFoddService.Order);
            // 
            // OrderDetailBindingSource
            // 
            this.OrderDetailBindingSource.DataSource = typeof(WFManagermentFastFood.FastFoddService.OrderDetail);
            // 
            // reportViewer1
            // 
            reportDataSource9.Name = "DataSetOrderDay";
            reportDataSource9.Value = this.OrderBindingSource;
            reportDataSource10.Name = "DataSetOrderDetailDay";
            reportDataSource10.Value = this.OrderDetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFManagermentFastFood.Reports.ReportDDay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(724, 388);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 462);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDate);
            this.tabPage1.Controls.Add(this.dateTimePickerDay);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(727, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Theo ngày";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(147, 12);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 4;
            this.btnDate.Text = "Thống kê";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // dateTimePickerDay
            // 
            this.dateTimePickerDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDay.Location = new System.Drawing.Point(13, 14);
            this.dateTimePickerDay.Name = "dateTimePickerDay";
            this.dateTimePickerDay.Size = new System.Drawing.Size(119, 20);
            this.dateTimePickerDay.TabIndex = 3;
            this.dateTimePickerDay.Value = new System.DateTime(2014, 10, 24, 0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMonth);
            this.tabPage2.Controls.Add(this.dateTimePickerMonth);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Theo tháng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(153, 9);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(75, 23);
            this.btnMonth.TabIndex = 4;
            this.btnMonth.Text = "Thống kê";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // dateTimePickerMonth
            // 
            this.dateTimePickerMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMonth.Location = new System.Drawing.Point(10, 12);
            this.dateTimePickerMonth.Name = "dateTimePickerMonth";
            this.dateTimePickerMonth.Size = new System.Drawing.Size(119, 20);
            this.dateTimePickerMonth.TabIndex = 3;
            this.dateTimePickerMonth.Value = new System.DateTime(2014, 10, 24, 0, 0, 0, 0);
            // 
            // reportViewer2
            // 
            reportDataSource13.Name = "DataSetOrderMonth";
            reportDataSource13.Value = this.OrderBindingSource;
            reportDataSource14.Name = "DataSetOrderDetailMonth";
            reportDataSource14.Value = this.OrderDetailBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WFManagermentFastFood.Reports.ReportMonth.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(-4, 41);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(731, 399);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxQuarterYear);
            this.tabPage3.Controls.Add(this.comboBoxQuarter);
            this.tabPage3.Controls.Add(this.btnQuarter);
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(727, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Theo quý";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxQuarterYear
            // 
            this.comboBoxQuarterYear.FormattingEnabled = true;
            this.comboBoxQuarterYear.Location = new System.Drawing.Point(133, 13);
            this.comboBoxQuarterYear.Name = "comboBoxQuarterYear";
            this.comboBoxQuarterYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuarterYear.TabIndex = 20;
            // 
            // comboBoxQuarter
            // 
            this.comboBoxQuarter.FormattingEnabled = true;
            this.comboBoxQuarter.Items.AddRange(new object[] {
            "-----------Chọn quý-----------",
            "               Quý I",
            "               Quý II",
            "               Quý III",
            "               Quý IV"});
            this.comboBoxQuarter.Location = new System.Drawing.Point(6, 13);
            this.comboBoxQuarter.Name = "comboBoxQuarter";
            this.comboBoxQuarter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuarter.TabIndex = 19;
            // 
            // btnQuarter
            // 
            this.btnQuarter.Location = new System.Drawing.Point(260, 12);
            this.btnQuarter.Name = "btnQuarter";
            this.btnQuarter.Size = new System.Drawing.Size(75, 23);
            this.btnQuarter.TabIndex = 18;
            this.btnQuarter.Text = "Thống kê";
            this.btnQuarter.UseVisualStyleBackColor = true;
            this.btnQuarter.Click += new System.EventHandler(this.btnQuarter_Click);
            // 
            // reportViewer3
            // 
            reportDataSource15.Name = "ReportDay";
            reportDataSource15.Value = this.OrderBindingSource;
            reportDataSource16.Name = "ReportOrderMonthDetail";
            reportDataSource16.Value = this.OrderDetailBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource15);
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource16);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "WFManagermentFastFood.Reports.ReportQuarter.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(-2, 51);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(729, 389);
            this.reportViewer3.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnYear);
            this.tabPage4.Controls.Add(this.comboBoxYear);
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(727, 436);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Theo năm";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            reportDataSource11.Name = "DataSetOrderYear";
            reportDataSource11.Value = this.OrderBindingSource;
            reportDataSource12.Name = "DataSetOrderDetailYear";
            reportDataSource12.Value = this.OrderDetailBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "WFManagermentFastFood.Reports.ReportYear.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(-3, 40);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(730, 393);
            this.reportViewer4.TabIndex = 1;
            // 
            // orderDetailBindingSource1
            // 
            this.orderDetailBindingSource1.DataSource = typeof(WFManagermentFastFood.FastFoddService.OrderDetail);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(228, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // managementReportBindingSource
            // 
            this.managementReportBindingSource.DataSource = typeof(WFManagermentFastFood.ManagementReport);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(28, 13);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 2;
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(156, 11);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(75, 23);
            this.btnYear.TabIndex = 3;
            this.btnYear.Text = "Thống kê";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource OrderDetailBindingSource;
        private System.Windows.Forms.BindingSource orderDetailBindingSource1;
        private System.Windows.Forms.BindingSource managementReportBindingSource;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDay;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.DateTimePicker dateTimePickerMonth;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.ComboBox comboBoxQuarterYear;
        private System.Windows.Forms.ComboBox comboBoxQuarter;
        private System.Windows.Forms.Button btnQuarter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.ComboBox comboBoxYear;

    }
}