namespace WFManagermentFastFood
{
    partial class ManagementAddNewOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.ProductID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListProduct = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtDel = new System.Windows.Forms.TextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewProduct);
            this.panel1.Location = new System.Drawing.Point(25, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 232);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToOrderColumns = true;
            this.dataGridViewProduct.AutoGenerateColumns = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID1,
            this.productName1,
            this.discountDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dataGridViewProduct.DataSource = this.productBindingSource;
            this.dataGridViewProduct.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(540, 184);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            // 
            // ProductID1
            // 
            this.ProductID1.DataPropertyName = "ProductID";
            this.ProductID1.HeaderText = "Mã sản phẩm";
            this.ProductID1.Name = "ProductID1";
            // 
            // productName1
            // 
            this.productName1.DataPropertyName = "ProductName";
            this.productName1.HeaderText = "Tên sản phẩm";
            this.productName1.Name = "productName1";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Giảm giá";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Hình ảnh";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WFManagermentFastFood.FastFoddService.Product);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridViewListProduct);
            this.panel2.Location = new System.Drawing.Point(609, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 231);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH SẢN PHẨM ĐÃ CHỌN";
            // 
            // dataGridViewListProduct
            // 
            this.dataGridViewListProduct.AutoGenerateColumns = false;
            this.dataGridViewListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Quantity,
            this.UnitPrice,
            this.Edit,
            this.orderDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn1});
            this.dataGridViewListProduct.DataSource = this.orderDetailBindingSource;
            this.dataGridViewListProduct.Location = new System.Drawing.Point(6, 41);
            this.dataGridViewListProduct.Name = "dataGridViewListProduct";
            this.dataGridViewListProduct.Size = new System.Drawing.Size(443, 180);
            this.dataGridViewListProduct.TabIndex = 0;
            this.dataGridViewListProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListProduct_CellClick);
            this.dataGridViewListProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListProduct_CellContentClick_1);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Mã sản phẩm";
            this.ProductID.Name = "ProductID";
            this.ProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.UnitPrice.HeaderText = "Đơn giá";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Edit
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.NullValue = "Cập nhật ";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.HeaderText = "Thêm";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(WFManagermentFastFood.FastFoddService.OrderDetail);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(574, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(574, 178);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(29, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "<<";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(574, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(22, 20);
            this.txtID.TabIndex = 4;
            this.txtID.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(609, 334);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(285, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Thêm hóa đơn";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtDel
            // 
            this.txtDel.Location = new System.Drawing.Point(574, 71);
            this.txtDel.Name = "txtDel";
            this.txtDel.Size = new System.Drawing.Size(22, 20);
            this.txtDel.TabIndex = 6;
            this.txtDel.Visible = false;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WFManagermentFastFood.FastFoddService.Order);
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn1
            // 
            this.unitPriceDataGridViewTextBoxColumn1.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn1.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn1.Name = "unitPriceDataGridViewTextBoxColumn1";
            // 
            // ManagementAddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 387);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtDel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManagementAddNewOrder";
            this.Text = "THÊM HÓA ĐƠN";
            this.Load += new System.EventHandler(this.ManagementAddNewOrderForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewListProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn1;
    }
}