namespace WFManagermentFastFood
{
    partial class ManagementOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDetailOrder = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(418, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToOrderColumns = true;
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.dateCreateDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.recipientAddressDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.Status,
            this.Edit});
            this.dataGridViewOrder.DataSource = this.orderBindingSource;
            this.dataGridViewOrder.Location = new System.Drawing.Point(1, 81);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(1103, 236);
            this.dataGridViewOrder.TabIndex = 1;
            this.dataGridViewOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "Mã hóa đơn";
            this.OrderID.Name = "OrderID";
            // 
            // dateCreateDataGridViewTextBoxColumn
            // 
            this.dateCreateDataGridViewTextBoxColumn.DataPropertyName = "DateCreate";
            this.dateCreateDataGridViewTextBoxColumn.HeaderText = "Ngày đặt hàng";
            this.dateCreateDataGridViewTextBoxColumn.Name = "dateCreateDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Số ĐT";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // recipientAddressDataGridViewTextBoxColumn
            // 
            this.recipientAddressDataGridViewTextBoxColumn.DataPropertyName = "RecipientAddress";
            this.recipientAddressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ giao hàng";
            this.recipientAddressDataGridViewTextBoxColumn.Name = "recipientAddressDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "Sửa";
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.HeaderText = "Sửa";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.ToolTipText = "Sửa";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WFManagermentFastFood.FastFoddService.Order);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(WFManagermentFastFood.FastFoddService.Account);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(4, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(155, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(165, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDetailOrder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 167);
            this.panel1.TabIndex = 4;
            // 
            // dataGridViewDetailOrder
            // 
            this.dataGridViewDetailOrder.AllowUserToOrderColumns = true;
            this.dataGridViewDetailOrder.AutoGenerateColumns = false;
            this.dataGridViewDetailOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dataGridViewDetailOrder.DataSource = this.orderDetailBindingSource;
            this.dataGridViewDetailOrder.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewDetailOrder.Name = "dataGridViewDetailOrder";
            this.dataGridViewDetailOrder.Size = new System.Drawing.Size(444, 136);
            this.dataGridViewDetailOrder.TabIndex = 1;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(WFManagermentFastFood.FastFoddService.OrderDetail);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi tiết hóa đơn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(30, 87);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(113, 23);
            this.btnAddOrder.TabIndex = 5;
            this.btnAddOrder.Text = "Thêm hóa đơn";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(180, 87);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Đóng";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnAddOrder);
            this.panel2.Location = new System.Drawing.Point(802, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 130);
            this.panel2.TabIndex = 7;
            // 
            // ManagementOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.label1);
            this.Name = "ManagementOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDetailOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
    }
}