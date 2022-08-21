namespace library_management_system.FORMS
{
    partial class ManageUsersForm
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
            this.Lbl_Users = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Dgv_Users = new System.Windows.Forms.DataGridView();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Lbl_Username = new System.Windows.Forms.Label();
            this.Txt_LName = new System.Windows.Forms.TextBox();
            this.Lbl_LastName = new System.Windows.Forms.Label();
            this.Txt_FName = new System.Windows.Forms.TextBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_FirstName = new System.Windows.Forms.Label();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txt_RepeatPassword = new System.Windows.Forms.TextBox();
            this.Lbl_RepeatPass = new System.Windows.Forms.Label();
            this.Chck_Admin = new System.Windows.Forms.CheckBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Users
            // 
            this.Lbl_Users.BackColor = System.Drawing.SystemColors.Info;
            this.Lbl_Users.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Users.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Users.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Users.Name = "Lbl_Users";
            this.Lbl_Users.Size = new System.Drawing.Size(1261, 78);
            this.Lbl_Users.TabIndex = 6;
            this.Lbl_Users.Text = "Users";
            this.Lbl_Users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Location = new System.Drawing.Point(1231, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 8;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Dgv_Users
            // 
            this.Dgv_Users.AllowUserToAddRows = false;
            this.Dgv_Users.AllowUserToDeleteRows = false;
            this.Dgv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Users.Location = new System.Drawing.Point(663, 93);
            this.Dgv_Users.Name = "Dgv_Users";
            this.Dgv_Users.RowHeadersWidth = 51;
            this.Dgv_Users.RowTemplate.Height = 24;
            this.Dgv_Users.Size = new System.Drawing.Size(586, 521);
            this.Dgv_Users.TabIndex = 9;
            this.Dgv_Users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Users_CellClick);
            // 
            // Txt_Username
            // 
            this.Txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_Username.Location = new System.Drawing.Point(259, 273);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(200, 30);
            this.Txt_Username.TabIndex = 19;
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Username.Location = new System.Drawing.Point(101, 271);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(152, 32);
            this.Lbl_Username.TabIndex = 18;
            this.Lbl_Username.Text = "Username:";
            // 
            // Txt_LName
            // 
            this.Txt_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_LName.Location = new System.Drawing.Point(259, 214);
            this.Txt_LName.Name = "Txt_LName";
            this.Txt_LName.Size = new System.Drawing.Size(200, 30);
            this.Txt_LName.TabIndex = 17;
            // 
            // Lbl_LastName
            // 
            this.Lbl_LastName.AutoSize = true;
            this.Lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_LastName.Location = new System.Drawing.Point(99, 212);
            this.Lbl_LastName.Name = "Lbl_LastName";
            this.Lbl_LastName.Size = new System.Drawing.Size(154, 32);
            this.Lbl_LastName.TabIndex = 16;
            this.Lbl_LastName.Text = "Last name:";
            // 
            // Txt_FName
            // 
            this.Txt_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_FName.Location = new System.Drawing.Point(259, 155);
            this.Txt_FName.Name = "Txt_FName";
            this.Txt_FName.Size = new System.Drawing.Size(200, 30);
            this.Txt_FName.TabIndex = 15;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_ID.Location = new System.Drawing.Point(259, 96);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.ReadOnly = true;
            this.Txt_ID.Size = new System.Drawing.Size(100, 30);
            this.Txt_ID.TabIndex = 14;
            // 
            // Lbl_FirstName
            // 
            this.Lbl_FirstName.AutoSize = true;
            this.Lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_FirstName.Location = new System.Drawing.Point(98, 152);
            this.Lbl_FirstName.Name = "Lbl_FirstName";
            this.Lbl_FirstName.Size = new System.Drawing.Size(155, 32);
            this.Lbl_FirstName.TabIndex = 13;
            this.Lbl_FirstName.Text = "First name:";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_ID.Location = new System.Drawing.Point(204, 93);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(49, 32);
            this.Lbl_ID.TabIndex = 12;
            this.Lbl_ID.Text = "ID:";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_Password.Location = new System.Drawing.Point(259, 332);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(200, 30);
            this.Txt_Password.TabIndex = 21;
            this.Txt_Password.UseSystemPasswordChar = true;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Password.Location = new System.Drawing.Point(107, 330);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(146, 32);
            this.Lbl_Password.TabIndex = 20;
            this.Lbl_Password.Text = "Password:";
            // 
            // Txt_RepeatPassword
            // 
            this.Txt_RepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_RepeatPassword.Location = new System.Drawing.Point(259, 391);
            this.Txt_RepeatPassword.Name = "Txt_RepeatPassword";
            this.Txt_RepeatPassword.Size = new System.Drawing.Size(200, 30);
            this.Txt_RepeatPassword.TabIndex = 23;
            this.Txt_RepeatPassword.UseSystemPasswordChar = true;
            // 
            // Lbl_RepeatPass
            // 
            this.Lbl_RepeatPass.AutoSize = true;
            this.Lbl_RepeatPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_RepeatPass.Location = new System.Drawing.Point(8, 388);
            this.Lbl_RepeatPass.Name = "Lbl_RepeatPass";
            this.Lbl_RepeatPass.Size = new System.Drawing.Size(245, 32);
            this.Lbl_RepeatPass.TabIndex = 22;
            this.Lbl_RepeatPass.Text = "Repeat Password:";
            // 
            // Chck_Admin
            // 
            this.Chck_Admin.AutoSize = true;
            this.Chck_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chck_Admin.Location = new System.Drawing.Point(259, 439);
            this.Chck_Admin.Name = "Chck_Admin";
            this.Chck_Admin.Size = new System.Drawing.Size(168, 33);
            this.Chck_Admin.TabIndex = 24;
            this.Chck_Admin.Text = "Make Admin";
            this.Chck_Admin.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Delete.Location = new System.Drawing.Point(426, 521);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(173, 80);
            this.Btn_Delete.TabIndex = 27;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Update.Location = new System.Drawing.Point(242, 521);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(173, 80);
            this.Btn_Update.TabIndex = 26;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Add.Location = new System.Drawing.Point(58, 521);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(173, 80);
            this.Btn_Add.TabIndex = 25;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 626);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Chck_Admin);
            this.Controls.Add(this.Txt_RepeatPassword);
            this.Controls.Add(this.Lbl_RepeatPass);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.Lbl_Username);
            this.Controls.Add(this.Txt_LName);
            this.Controls.Add(this.Lbl_LastName);
            this.Controls.Add(this.Txt_FName);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Lbl_FirstName);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Dgv_Users);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lbl_Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsersForm";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Users;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.DataGridView Dgv_Users;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.Label Lbl_Username;
        private System.Windows.Forms.TextBox Txt_LName;
        private System.Windows.Forms.Label Lbl_LastName;
        private System.Windows.Forms.TextBox Txt_FName;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Lbl_FirstName;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Txt_RepeatPassword;
        private System.Windows.Forms.Label Lbl_RepeatPass;
        private System.Windows.Forms.CheckBox Chck_Admin;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Add;
    }
}