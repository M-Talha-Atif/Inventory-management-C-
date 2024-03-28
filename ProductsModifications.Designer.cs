namespace InventoryManagement
{
    partial class ProductsModifications
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.tbProductname = new System.Windows.Forms.TextBox();
            this.emailUser = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductQuantity = new System.Windows.Forms.TextBox();
            this.tbProductDescription = new System.Windows.Forms.TextBox();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProductBrand = new System.Windows.Forms.TextBox();
            this.EditProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(72, 13);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(141, 26);
            this.tbID.TabIndex = 27;
            this.tbID.Visible = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(6, 13);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(42, 30);
            this.labelID.TabIndex = 26;
            this.labelID.Text = "ID:";
            this.labelID.Visible = false;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdateProduct.Location = new System.Drawing.Point(484, 176);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(192, 52);
            this.btnUpdateProduct.TabIndex = 25;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // tbProductname
            // 
            this.tbProductname.Location = new System.Drawing.Point(464, 6);
            this.tbProductname.Name = "tbProductname";
            this.tbProductname.Size = new System.Drawing.Size(113, 26);
            this.tbProductname.TabIndex = 24;
            // 
            // emailUser
            // 
            this.emailUser.AutoSize = true;
            this.emailUser.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailUser.Location = new System.Drawing.Point(230, 1);
            this.emailUser.Name = "emailUser";
            this.emailUser.Size = new System.Drawing.Size(143, 30);
            this.emailUser.TabIndex = 23;
            this.emailUser.Text = "Enter Name:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.Location = new System.Drawing.Point(211, 176);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(192, 52);
            this.btnAddProduct.TabIndex = 22;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(230, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter Description:";
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Location = new System.Drawing.Point(464, 113);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(113, 26);
            this.tbProductQuantity.TabIndex = 19;
            this.tbProductQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProductQuantity_KeyPress);
            // 
            // tbProductDescription
            // 
            this.tbProductDescription.Location = new System.Drawing.Point(464, 55);
            this.tbProductDescription.Name = "tbProductDescription";
            this.tbProductDescription.Size = new System.Drawing.Size(113, 26);
            this.tbProductDescription.TabIndex = 18;
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditProduct,
            this.RemoveProduct});
            this.dataGridProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridProducts.Location = new System.Drawing.Point(0, 267);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.RowHeadersWidth = 62;
            this.dataGridProducts.RowTemplate.Height = 28;
            this.dataGridProducts.Size = new System.Drawing.Size(1199, 183);
            this.dataGridProducts.TabIndex = 17;
            this.dataGridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProducts_CellContentClick);
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(880, 37);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(141, 26);
            this.tbProductPrice.TabIndex = 31;
            this.tbProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProductPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(598, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Enter Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(598, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Enter BrandName:";
            // 
            // tbProductBrand
            // 
            this.tbProductBrand.Location = new System.Drawing.Point(880, 85);
            this.tbProductBrand.Name = "tbProductBrand";
            this.tbProductBrand.Size = new System.Drawing.Size(141, 26);
            this.tbProductBrand.TabIndex = 28;
            // 
            // EditProduct
            // 
            this.EditProduct.HeaderText = "Edit Product";
            this.EditProduct.MinimumWidth = 8;
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Width = 150;
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.HeaderText = "Remove Product";
            this.RemoveProduct.MinimumWidth = 8;
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Width = 150;
            // 
            // ProductsModifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1199, 450);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbProductBrand);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.tbProductname);
            this.Controls.Add(this.emailUser);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProductQuantity);
            this.Controls.Add(this.tbProductDescription);
            this.Controls.Add(this.dataGridProducts);
            this.Name = "ProductsModifications";
            this.Text = "ProductsModifications";
            this.Load += new System.EventHandler(this.ProductsModifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox tbProductname;
        private System.Windows.Forms.Label emailUser;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductQuantity;
        private System.Windows.Forms.TextBox tbProductDescription;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProductBrand;
        private System.Windows.Forms.DataGridViewButtonColumn EditProduct;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveProduct;
    }
}