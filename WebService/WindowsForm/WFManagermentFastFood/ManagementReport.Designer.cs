namespace WFManagermentFastFood
{
    partial class ManagementReport
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
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxQuarterYear = new System.Windows.Forms.ComboBox();
            this.comboBoxQuarter = new System.Windows.Forms.ComboBox();
            this.lbTotalQuarter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewQuarter = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProductQuarter = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuarter = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbTotalMonth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewMonth = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProductMonth = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMonth = new System.Windows.Forms.Button();
            this.dateTimePickerMonth = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewProductDay = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTotalPriceDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.dateTimePickerDay = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewDay = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuarter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductQuarter)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMonth)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDay)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WFManagermentFastFood.FastFoddService.Order);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(WFManagermentFastFood.FastFoddService.Category);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(424, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "THỐNG KÊ BÁO CÁO";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(750, 374);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "Xuất report";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(848, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxQuarterYear);
            this.tabPage3.Controls.Add(this.comboBoxQuarter);
            this.tabPage3.Controls.Add(this.lbTotalQuarter);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridViewQuarter);
            this.tabPage3.Controls.Add(this.dataGridViewProductQuarter);
            this.tabPage3.Controls.Add(this.btnQuarter);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(914, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Theo quý";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // comboBoxQuarterYear
            // 
            this.comboBoxQuarterYear.FormattingEnabled = true;
            this.comboBoxQuarterYear.Location = new System.Drawing.Point(134, 6);
            this.comboBoxQuarterYear.Name = "comboBoxQuarterYear";
            this.comboBoxQuarterYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuarterYear.TabIndex = 17;
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
            this.comboBoxQuarter.Location = new System.Drawing.Point(7, 6);
            this.comboBoxQuarter.Name = "comboBoxQuarter";
            this.comboBoxQuarter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuarter.TabIndex = 16;
            // 
            // lbTotalQuarter
            // 
            this.lbTotalQuarter.AutoSize = true;
            this.lbTotalQuarter.ForeColor = System.Drawing.Color.Red;
            this.lbTotalQuarter.Location = new System.Drawing.Point(353, 237);
            this.lbTotalQuarter.Name = "lbTotalQuarter";
            this.lbTotalQuarter.Size = new System.Drawing.Size(30, 13);
            this.lbTotalQuarter.TabIndex = 15;
            this.lbTotalQuarter.Text = "VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tổng doanh thu:";
            // 
            // dataGridViewQuarter
            // 
            this.dataGridViewQuarter.AutoGenerateColumns = false;
            this.dataGridViewQuarter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuarter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn10});
            this.dataGridViewQuarter.DataSource = this.orderBindingSource;
            this.dataGridViewQuarter.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewQuarter.Name = "dataGridViewQuarter";
            this.dataGridViewQuarter.Size = new System.Drawing.Size(445, 190);
            this.dataGridViewQuarter.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã hóa đơn";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DateCreate";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Status";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Trạng thái";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn10.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewProductQuarter
            // 
            this.dataGridViewProductQuarter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductQuarter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dataGridViewProductQuarter.Location = new System.Drawing.Point(471, 34);
            this.dataGridViewProductQuarter.Name = "dataGridViewProductQuarter";
            this.dataGridViewProductQuarter.Size = new System.Drawing.Size(445, 190);
            this.dataGridViewProductQuarter.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn11.HeaderText = "Mả sản phẩm";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn12.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn13.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn14.HeaderText = "Giá tiền";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // btnQuarter
            // 
            this.btnQuarter.Location = new System.Drawing.Point(261, 5);
            this.btnQuarter.Name = "btnQuarter";
            this.btnQuarter.Size = new System.Drawing.Size(75, 23);
            this.btnQuarter.TabIndex = 11;
            this.btnQuarter.Text = "Thống kê";
            this.btnQuarter.UseVisualStyleBackColor = true;
            this.btnQuarter.Click += new System.EventHandler(this.btnQuarter_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbTotalMonth);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridViewMonth);
            this.tabPage2.Controls.Add(this.dataGridViewProductMonth);
            this.tabPage2.Controls.Add(this.btnMonth);
            this.tabPage2.Controls.Add(this.dateTimePickerMonth);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Theo tháng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbTotalMonth
            // 
            this.lbTotalMonth.AutoSize = true;
            this.lbTotalMonth.ForeColor = System.Drawing.Color.Red;
            this.lbTotalMonth.Location = new System.Drawing.Point(353, 235);
            this.lbTotalMonth.Name = "lbTotalMonth";
            this.lbTotalMonth.Size = new System.Drawing.Size(30, 13);
            this.lbTotalMonth.TabIndex = 9;
            this.lbTotalMonth.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng doanh thu:";
            // 
            // dataGridViewMonth
            // 
            this.dataGridViewMonth.AutoGenerateColumns = false;
            this.dataGridViewMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewMonth.DataSource = this.orderBindingSource;
            this.dataGridViewMonth.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewMonth.Name = "dataGridViewMonth";
            this.dataGridViewMonth.Size = new System.Drawing.Size(459, 190);
            this.dataGridViewMonth.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã hóa đơn";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateCreate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Trạng thái";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewProductMonth
            // 
            this.dataGridViewProductMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewProductMonth.Location = new System.Drawing.Point(471, 32);
            this.dataGridViewProductMonth.Name = "dataGridViewProductMonth";
            this.dataGridViewProductMonth.Size = new System.Drawing.Size(445, 190);
            this.dataGridViewProductMonth.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mả sản phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá tiền";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(161, 3);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(75, 23);
            this.btnMonth.TabIndex = 3;
            this.btnMonth.Text = "Thống kê";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // dateTimePickerMonth
            // 
            this.dateTimePickerMonth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMonth.Location = new System.Drawing.Point(8, 6);
            this.dateTimePickerMonth.Name = "dateTimePickerMonth";
            this.dateTimePickerMonth.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerMonth.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewProductDay);
            this.tabPage1.Controls.Add(this.lbTotalPriceDay);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnDate);
            this.tabPage1.Controls.Add(this.dateTimePickerDay);
            this.tabPage1.Controls.Add(this.dataGridViewDay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Theo ngày";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridViewProductDay
            // 
            this.dataGridViewProductDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.UnitPrice});
            this.dataGridViewProductDay.Location = new System.Drawing.Point(457, 32);
            this.dataGridViewProductDay.Name = "dataGridViewProductDay";
            this.dataGridViewProductDay.Size = new System.Drawing.Size(445, 190);
            this.dataGridViewProductDay.TabIndex = 5;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Mả sản phẩm";
            this.ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Giá tiền";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // lbTotalPriceDay
            // 
            this.lbTotalPriceDay.AutoSize = true;
            this.lbTotalPriceDay.ForeColor = System.Drawing.Color.Red;
            this.lbTotalPriceDay.Location = new System.Drawing.Point(357, 225);
            this.lbTotalPriceDay.Name = "lbTotalPriceDay";
            this.lbTotalPriceDay.Size = new System.Drawing.Size(30, 13);
            this.lbTotalPriceDay.TabIndex = 4;
            this.lbTotalPriceDay.Text = "VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng doanh thu:";
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(162, 3);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 2;
            this.btnDate.Text = "Thống kê";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // dateTimePickerDay
            // 
            this.dateTimePickerDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDay.Location = new System.Drawing.Point(11, 6);
            this.dateTimePickerDay.Name = "dateTimePickerDay";
            this.dateTimePickerDay.Size = new System.Drawing.Size(119, 20);
            this.dateTimePickerDay.TabIndex = 1;
            this.dateTimePickerDay.Value = new System.DateTime(2014, 10, 24, 0, 0, 0, 0);
            // 
            // dataGridViewDay
            // 
            this.dataGridViewDay.AutoGenerateColumns = false;
            this.dataGridViewDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.dateCreateDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridViewDay.DataSource = this.orderBindingSource;
            this.dataGridViewDay.Location = new System.Drawing.Point(7, 32);
            this.dataGridViewDay.Name = "dataGridViewDay";
            this.dataGridViewDay.Size = new System.Drawing.Size(444, 190);
            this.dataGridViewDay.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // dateCreateDataGridViewTextBoxColumn
            // 
            this.dateCreateDataGridViewTextBoxColumn.DataPropertyName = "DateCreate";
            this.dateCreateDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.dateCreateDataGridViewTextBoxColumn.Name = "dateCreateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Trạng thái";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 320);
            this.tabControl1.TabIndex = 0;
            // 
            // ManagementReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 402);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagementReport";
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuarter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductQuarter)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMonth)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDay)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBoxQuarterYear;
        private System.Windows.Forms.ComboBox comboBoxQuarter;
        private System.Windows.Forms.Label lbTotalQuarter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewQuarter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridView dataGridViewProductQuarter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button btnQuarter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbTotalMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dataGridViewProductMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.DateTimePicker dateTimePickerMonth;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewProductDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.Label lbTotalPriceDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDay;
        private System.Windows.Forms.DataGridView dataGridViewDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
    }
}