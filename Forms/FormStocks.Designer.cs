namespace Appliances_Management_System.Forms
{
    partial class FormStocks
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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblproductlistBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.newproductlistDataSet = new Appliances_Management_System.NewproductlistDataSet();
            this.tblproductlistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productlistDataSet1 = new Appliances_Management_System.productlistDataSet1();
            this.productlistDataSet = new Appliances_Management_System.productlistDataSet();
            this.tblproductlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_productlistTableAdapter = new Appliances_Management_System.productlistDataSetTableAdapters.tbl_productlistTableAdapter();
            this.productList1DataSet = new Appliances_Management_System.ProductList1DataSet();
            this.tblproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_productTableAdapter = new Appliances_Management_System.ProductList1DataSetTableAdapters.tbl_productTableAdapter();
            this.tbl_productlistTableAdapter1 = new Appliances_Management_System.productlistDataSet1TableAdapters.tbl_productlistTableAdapter();
            this.productlistDataSet2 = new Appliances_Management_System.productlistDataSet2();
            this.tblproductlistBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_productlistTableAdapter2 = new Appliances_Management_System.productlistDataSet2TableAdapters.tbl_productlistTableAdapter();
            this.tbl_productlistTableAdapter3 = new Appliances_Management_System.NewproductlistDataSetTableAdapters.tbl_productlistTableAdapter();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductlistBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newproductlistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductlistBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productList1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductlistBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Kitchen Appliances",
            "Laundry Appliance",
            "Cleaning Appliances",
            "Climate Control Appliances",
            "Entertainment Appliances",
            "Personal Care Appliances",
            "Home Security Appliances"});
            this.comboBoxCategory.Location = new System.Drawing.Point(497, 47);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(107, 21);
            this.comboBoxCategory.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(620, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "PRODUCT PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(494, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "CATEGORY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(215, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "PRODUCT QUANTITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(354, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "BRAND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "PRODUCT NAME";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(357, 46);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(118, 20);
            this.txtBrand.TabIndex = 39;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(218, 46);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(113, 20);
            this.txtProductQuantity.TabIndex = 38;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(623, 48);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(99, 20);
            this.txtProductPrice.TabIndex = 37;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(12, 46);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(187, 20);
            this.txtProductName.TabIndex = 36;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.Location = new System.Drawing.Point(245, 79);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 35);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Location = new System.Drawing.Point(397, 79);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 35);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_name,
            this.product_quantity,
            this.brand,
            this.category,
            this.product_price});
            this.dataGridView1.DataSource = this.tblproductlistBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(126, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 163);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tblproductlistBindingSource3
            // 
            this.tblproductlistBindingSource3.DataMember = "tbl_productlist";
            this.tblproductlistBindingSource3.DataSource = this.newproductlistDataSet;
            // 
            // newproductlistDataSet
            // 
            this.newproductlistDataSet.DataSetName = "NewproductlistDataSet";
            this.newproductlistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblproductlistBindingSource1
            // 
            this.tblproductlistBindingSource1.DataMember = "tbl_productlist";
            this.tblproductlistBindingSource1.DataSource = this.productlistDataSet1;
            // 
            // productlistDataSet1
            // 
            this.productlistDataSet1.DataSetName = "productlistDataSet1";
            this.productlistDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productlistDataSet
            // 
            this.productlistDataSet.DataSetName = "productlistDataSet";
            this.productlistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblproductlistBindingSource
            // 
            this.tblproductlistBindingSource.DataMember = "tbl_productlist";
            this.tblproductlistBindingSource.DataSource = this.productlistDataSet;
            this.tblproductlistBindingSource.CurrentChanged += new System.EventHandler(this.tblproductlistBindingSource_CurrentChanged);
            // 
            // tbl_productlistTableAdapter
            // 
            this.tbl_productlistTableAdapter.ClearBeforeFill = true;
            // 
            // productList1DataSet
            // 
            this.productList1DataSet.DataSetName = "ProductList1DataSet";
            this.productList1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblproductBindingSource
            // 
            this.tblproductBindingSource.DataMember = "tbl_product";
            this.tblproductBindingSource.DataSource = this.productList1DataSet;
            // 
            // tbl_productTableAdapter
            // 
            this.tbl_productTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_productlistTableAdapter1
            // 
            this.tbl_productlistTableAdapter1.ClearBeforeFill = true;
            // 
            // productlistDataSet2
            // 
            this.productlistDataSet2.DataSetName = "productlistDataSet2";
            this.productlistDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblproductlistBindingSource2
            // 
            this.tblproductlistBindingSource2.DataMember = "tbl_productlist";
            this.tblproductlistBindingSource2.DataSource = this.productlistDataSet2;
            // 
            // tbl_productlistTableAdapter2
            // 
            this.tbl_productlistTableAdapter2.ClearBeforeFill = true;
            // 
            // tbl_productlistTableAdapter3
            // 
            this.tbl_productlistTableAdapter3.ClearBeforeFill = true;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // product_quantity
            // 
            this.product_quantity.DataPropertyName = "product_quantity";
            this.product_quantity.HeaderText = "Product Quantity";
            this.product_quantity.Name = "product_quantity";
            this.product_quantity.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // product_price
            // 
            this.product_price.DataPropertyName = "product_price";
            this.product_price.HeaderText = "Product Price";
            this.product_price.Name = "product_price";
            this.product_price.ReadOnly = true;
            // 
            // FormStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Name = "FormStocks";
            this.Text = "PRODUCT STOCK";
            this.Load += new System.EventHandler(this.FormStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductlistBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newproductlistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductlistBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productList1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductlistBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private productlistDataSet productlistDataSet;
        private System.Windows.Forms.BindingSource tblproductlistBindingSource;
        private productlistDataSetTableAdapters.tbl_productlistTableAdapter tbl_productlistTableAdapter;
        private ProductList1DataSet productList1DataSet;
        private System.Windows.Forms.BindingSource tblproductBindingSource;
        private ProductList1DataSetTableAdapters.tbl_productTableAdapter tbl_productTableAdapter;
        private productlistDataSet1 productlistDataSet1;
        private System.Windows.Forms.BindingSource tblproductlistBindingSource1;
        private productlistDataSet1TableAdapters.tbl_productlistTableAdapter tbl_productlistTableAdapter1;
        private productlistDataSet2 productlistDataSet2;
        private System.Windows.Forms.BindingSource tblproductlistBindingSource2;
        private productlistDataSet2TableAdapters.tbl_productlistTableAdapter tbl_productlistTableAdapter2;
        private NewproductlistDataSet newproductlistDataSet;
        private System.Windows.Forms.BindingSource tblproductlistBindingSource3;
        private NewproductlistDataSetTableAdapters.tbl_productlistTableAdapter tbl_productlistTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
    }
}