namespace InventoryManagement
{
    partial class LoginUser
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
            this.btnLoginUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswordUser = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoginUser
            // 
            this.btnLoginUser.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.btnLoginUser.Location = new System.Drawing.Point(264, 285);
            this.btnLoginUser.Name = "btnLoginUser";
            this.btnLoginUser.Size = new System.Drawing.Size(141, 52);
            this.btnLoginUser.TabIndex = 9;
            this.btnLoginUser.Text = "Login";
            this.btnLoginUser.UseVisualStyleBackColor = true;
            this.btnLoginUser.Click += new System.EventHandler(this.btnLoginUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(190, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter UserName:";
            // 
            // tbPasswordUser
            // 
            this.tbPasswordUser.Location = new System.Drawing.Point(431, 176);
            this.tbPasswordUser.Name = "tbPasswordUser";
            this.tbPasswordUser.Size = new System.Drawing.Size(141, 26);
            this.tbPasswordUser.TabIndex = 6;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(431, 112);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(141, 26);
            this.tbUserName.TabIndex = 5;
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoginUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPasswordUser);
            this.Controls.Add(this.tbUserName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "LoginUser";
            this.Text = "LoginUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswordUser;
        private System.Windows.Forms.TextBox tbUserName;
    }
}