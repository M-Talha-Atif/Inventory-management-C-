namespace InventoryManagement
{
    partial class UserModify
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
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.EditUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbEmailUser = new System.Windows.Forms.TextBox();
            this.emailUser = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswordUser = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditUser,
            this.RemoveUser});
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridUsers.Location = new System.Drawing.Point(0, 283);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersWidth = 62;
            this.dataGridUsers.RowTemplate.Height = 28;
            this.dataGridUsers.Size = new System.Drawing.Size(1379, 382);
            this.dataGridUsers.TabIndex = 0;
            this.dataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridUsers_CellContentClick);
            // 
            // EditUser
            // 
            this.EditUser.HeaderText = "EditUser";
            this.EditUser.MinimumWidth = 8;
            this.EditUser.Name = "EditUser";
            this.EditUser.Width = 150;
            // 
            // RemoveUser
            // 
            this.RemoveUser.HeaderText = "RemoveUser";
            this.RemoveUser.MinimumWidth = 8;
            this.RemoveUser.Name = "RemoveUser";
            this.RemoveUser.Width = 150;
            // 
            // tbEmailUser
            // 
            this.tbEmailUser.Location = new System.Drawing.Point(515, 21);
            this.tbEmailUser.Name = "tbEmailUser";
            this.tbEmailUser.Size = new System.Drawing.Size(141, 26);
            this.tbEmailUser.TabIndex = 13;
            // 
            // emailUser
            // 
            this.emailUser.AutoSize = true;
            this.emailUser.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailUser.Location = new System.Drawing.Point(281, 16);
            this.emailUser.Name = "emailUser";
            this.emailUser.Size = new System.Drawing.Size(137, 30);
            this.emailUser.TabIndex = 12;
            this.emailUser.Text = "Enter Email:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.Location = new System.Drawing.Point(304, 195);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(192, 52);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(281, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter UserName:";
            // 
            // tbPasswordUser
            // 
            this.tbPasswordUser.Location = new System.Drawing.Point(515, 128);
            this.tbPasswordUser.Name = "tbPasswordUser";
            this.tbPasswordUser.Size = new System.Drawing.Size(141, 26);
            this.tbPasswordUser.TabIndex = 8;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(515, 70);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(141, 26);
            this.tbUserName.TabIndex = 7;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUser.Location = new System.Drawing.Point(541, 195);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(192, 52);
            this.btnUpdateUser.TabIndex = 14;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(37, 32);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(42, 30);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID:";
            this.labelID.Visible = false;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(103, 32);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(141, 26);
            this.tbID.TabIndex = 16;
            this.tbID.Visible = false;
            // 
            // UserModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1379, 665);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.tbEmailUser);
            this.Controls.Add(this.emailUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPasswordUser);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.dataGridUsers);
            this.Name = "UserModify";
            this.Text = "UserModify";
            this.Load += new System.EventHandler(this.UserModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TextBox tbEmailUser;
        private System.Windows.Forms.Label emailUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswordUser;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DataGridViewButtonColumn EditUser;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveUser;
    }
}