namespace InventoryManagement
{
    partial class LoginAdmin
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
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswordAdmin = new System.Windows.Forms.TextBox();
            this.tbAdminName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnLoginAdmin.Location = new System.Drawing.Point(246, 296);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(216, 52);
            this.btnLoginAdmin.TabIndex = 11;
            this.btnLoginAdmin.Text = "Login Admin";
            this.btnLoginAdmin.UseVisualStyleBackColor = true;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(152, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Admin Name:";
            // 
            // tbPasswordAdmin
            // 
            this.tbPasswordAdmin.Location = new System.Drawing.Point(461, 183);
            this.tbPasswordAdmin.Name = "tbPasswordAdmin";
            this.tbPasswordAdmin.Size = new System.Drawing.Size(141, 26);
            this.tbPasswordAdmin.TabIndex = 8;
            // 
            // tbAdminName
            // 
            this.tbAdminName.Location = new System.Drawing.Point(461, 126);
            this.tbAdminName.Name = "tbAdminName";
            this.tbAdminName.Size = new System.Drawing.Size(141, 26);
            this.tbAdminName.TabIndex = 7;
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPasswordAdmin);
            this.Controls.Add(this.tbAdminName);
            this.Name = "LoginAdmin";
            this.Text = "LoginAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswordAdmin;
        private System.Windows.Forms.TextBox tbAdminName;
    }
}