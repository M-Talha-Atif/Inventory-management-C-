namespace InventoryManagement
{
    partial class Main
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
            this.btnAuthenticateAdmin = new System.Windows.Forms.Button();
            this.btnSignUpUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoginUser
            // 
            this.btnLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnLoginUser.Location = new System.Drawing.Point(256, 70);
            this.btnLoginUser.Name = "btnLoginUser";
            this.btnLoginUser.Size = new System.Drawing.Size(258, 52);
            this.btnLoginUser.TabIndex = 5;
            this.btnLoginUser.Text = "Login as User";
            this.btnLoginUser.UseVisualStyleBackColor = true;
            this.btnLoginUser.Click += new System.EventHandler(this.btnSignUpUser_Click);
            // 
            // btnAuthenticateAdmin
            // 
            this.btnAuthenticateAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAuthenticateAdmin.Location = new System.Drawing.Point(256, 276);
            this.btnAuthenticateAdmin.Name = "btnAuthenticateAdmin";
            this.btnAuthenticateAdmin.Size = new System.Drawing.Size(258, 52);
            this.btnAuthenticateAdmin.TabIndex = 6;
            this.btnAuthenticateAdmin.Text = "Admin";
            this.btnAuthenticateAdmin.UseVisualStyleBackColor = true;
            this.btnAuthenticateAdmin.Click += new System.EventHandler(this.btnAuthenticateAdmin_Click);
            // 
            // btnSignUpUser
            // 
            this.btnSignUpUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSignUpUser.Location = new System.Drawing.Point(256, 176);
            this.btnSignUpUser.Name = "btnSignUpUser";
            this.btnSignUpUser.Size = new System.Drawing.Size(258, 52);
            this.btnSignUpUser.TabIndex = 7;
            this.btnSignUpUser.Text = "SignUp as User";
            this.btnSignUpUser.UseVisualStyleBackColor = true;
            this.btnSignUpUser.Click += new System.EventHandler(this.btnSignUpUser_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignUpUser);
            this.Controls.Add(this.btnAuthenticateAdmin);
            this.Controls.Add(this.btnLoginUser);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginUser;
        private System.Windows.Forms.Button btnAuthenticateAdmin;
        private System.Windows.Forms.Button btnSignUpUser;
    }
}

