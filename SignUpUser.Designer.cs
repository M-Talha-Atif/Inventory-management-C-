namespace InventoryManagement
{
    partial class SignUpUser
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPasswordUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignUpUser = new System.Windows.Forms.Button();
            this.emailUser = new System.Windows.Forms.Label();
            this.tbEmailUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(434, 118);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(141, 26);
            this.tbUserName.TabIndex = 0;
            // 
            // tbPasswordUser
            // 
            this.tbPasswordUser.Location = new System.Drawing.Point(434, 175);
            this.tbPasswordUser.Name = "tbPasswordUser";
            this.tbPasswordUser.Size = new System.Drawing.Size(141, 26);
            this.tbPasswordUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(200, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Password:";
            // 
            // btnSignUpUser
            // 
            this.btnSignUpUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSignUpUser.Location = new System.Drawing.Point(274, 290);
            this.btnSignUpUser.Name = "btnSignUpUser";
            this.btnSignUpUser.Size = new System.Drawing.Size(192, 52);
            this.btnSignUpUser.TabIndex = 4;
            this.btnSignUpUser.Text = "Sign Up";
            this.btnSignUpUser.UseVisualStyleBackColor = true;
            this.btnSignUpUser.Click += new System.EventHandler(this.btnSignUpUser_Click);
            // 
            // emailUser
            // 
            this.emailUser.AutoSize = true;
            this.emailUser.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailUser.Location = new System.Drawing.Point(200, 64);
            this.emailUser.Name = "emailUser";
            this.emailUser.Size = new System.Drawing.Size(137, 30);
            this.emailUser.TabIndex = 5;
            this.emailUser.Text = "Enter Email:";
            // 
            // tbEmailUser
            // 
            this.tbEmailUser.Location = new System.Drawing.Point(434, 69);
            this.tbEmailUser.Name = "tbEmailUser";
            this.tbEmailUser.Size = new System.Drawing.Size(141, 26);
            this.tbEmailUser.TabIndex = 6;
            // 
            // SignUpUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEmailUser);
            this.Controls.Add(this.emailUser);
            this.Controls.Add(this.btnSignUpUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPasswordUser);
            this.Controls.Add(this.tbUserName);
            this.Name = "SignUpUser";
            this.Text = "SignUpUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPasswordUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignUpUser;
        private System.Windows.Forms.Label emailUser;
        private System.Windows.Forms.TextBox tbEmailUser;
    }
}