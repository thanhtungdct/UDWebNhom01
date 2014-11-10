namespace WFManagermentFastFood
{
    partial class ManagementProducts
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
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtVote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxDisplay = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.Label();
            this.lable9 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnInsertNew = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearxh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AutoGenerateColumns = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.descriptionDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.displayDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dataGridViewProduct.DataSource = this.productBindingSource;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(675, 311);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
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
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Giảm giá";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // displayDataGridViewTextBoxColumn
            // 
            this.displayDataGridViewTextBoxColumn.DataPropertyName = "Display";
            this.displayDataGridViewTextBoxColumn.HeaderText = "Hiển thị";
            this.displayDataGridViewTextBoxColumn.Name = "displayDataGridViewTextBoxColumn";
            this.displayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.displayDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(854, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(795, 48);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(795, 74);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(795, 100);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 4;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(795, 126);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // txtVote
            // 
            this.txtVote.Location = new System.Drawing.Point(795, 152);
            this.txtVote.Name = "txtVote";
            this.txtVote.Size = new System.Drawing.Size(100, 20);
            this.txtVote.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giảm giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hiển thị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(739, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Vote";
            // 
            // checkBoxDisplay
            // 
            this.checkBoxDisplay.AutoSize = true;
            this.checkBoxDisplay.Location = new System.Drawing.Point(795, 185);
            this.checkBoxDisplay.Name = "checkBoxDisplay";
            this.checkBoxDisplay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDisplay.TabIndex = 9;
            this.checkBoxDisplay.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(714, 261);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 10;
            this.btnBrowser.Text = "Chọn hình";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(916, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(923, 330);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1004, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1085, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(795, 205);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 13;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(795, 264);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(100, 20);
            this.txtImage.TabIndex = 14;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(725, 211);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(34, 13);
            this.s.TabIndex = 8;
            this.s.Text = "Mô tả";
            // 
            // lable9
            // 
            this.lable9.AutoSize = true;
            this.lable9.Location = new System.Drawing.Point(725, 237);
            this.lable9.Name = "lable9";
            this.lable9.Size = new System.Drawing.Size(56, 13);
            this.lable9.TabIndex = 8;
            this.lable9.Text = "Danh mục";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(795, 231);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCategory.TabIndex = 15;
            // 
            // btnInsertNew
            // 
            this.btnInsertNew.Location = new System.Drawing.Point(714, 330);
            this.btnInsertNew.Name = "btnInsertNew";
            this.btnInsertNew.Size = new System.Drawing.Size(75, 23);
            this.btnInsertNew.TabIndex = 16;
            this.btnInsertNew.Text = "Làm mới";
            this.btnInsertNew.UseVisualStyleBackColor = true;
            this.btnInsertNew.Click += new System.EventHandler(this.btnInsertNew_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 20);
            this.txtSearch.TabIndex = 17;
            // 
            // btnSearxh
            // 
            this.btnSearxh.Location = new System.Drawing.Point(224, 7);
            this.btnSearxh.Name = "btnSearxh";
            this.btnSearxh.Size = new System.Drawing.Size(75, 23);
            this.btnSearxh.TabIndex = 18;
            this.btnSearxh.Text = "Tìm";
            this.btnSearxh.UseVisualStyleBackColor = true;
            this.btnSearxh.Click += new System.EventHandler(this.btnSearxh_Click);
            // 
            // ManagementProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 382);
            this.Controls.Add(this.btnSearxh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnInsertNew);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.checkBoxDisplay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lable9);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVote);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProduct);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "ManagementProducts";
            this.Text = "QUẢN LÝ SẢN PHẨM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtVote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxDisplay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label lable9;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button btnInsertNew;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearxh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn displayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}