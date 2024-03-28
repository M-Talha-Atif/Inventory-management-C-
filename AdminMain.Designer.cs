namespace InventoryManagement
{
    partial class AdminMain
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
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnChangeUser.Location = new System.Drawing.Point(193, 124);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(286, 52);
            this.btnChangeUser.TabIndex = 12;
            this.btnChangeUser.Text = "User Modifications";
            this.btnChangeUser.UseVisualStyleBackColor = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnProduct.Location = new System.Drawing.Point(193, 257);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(286, 52);
            this.btnProduct.TabIndex = 13;
            this.btnProduct.Text = "Products Modifications";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnChangeUser);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeUser;
        private System.Windows.Forms.Button btnProduct;
    }
}