namespace library_management_system.FORMS
{
    partial class ManageMembersForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Lbl_Picture = new System.Windows.Forms.Label();
            this.Grp_Gender = new System.Windows.Forms.GroupBox();
            this.Rbtn_Female = new System.Windows.Forms.RadioButton();
            this.Rbtn_Male = new System.Windows.Forms.RadioButton();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.Lbl_Phone = new System.Windows.Forms.Label();
            this.Btn_UploadPicture = new System.Windows.Forms.Button();
            this.Pb_Picture = new System.Windows.Forms.PictureBox();
            this.Dgv_Members = new System.Windows.Forms.DataGridView();
            this.Lbl_Gender = new System.Windows.Forms.Label();
            this.Txt_LName = new System.Windows.Forms.TextBox();
            this.Lbl_LastName = new System.Windows.Forms.Label();
            this.Txt_FName = new System.Windows.Forms.TextBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_FirstName = new System.Windows.Forms.Label();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_MembersCount = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lbl_Members = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Grp_Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Members)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Btn_Close);
            this.panel1.Controls.Add(this.Lbl_Members);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 794);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.Btn_Refresh);
            this.panel3.Controls.Add(this.Lbl_Picture);
            this.panel3.Controls.Add(this.Grp_Gender);
            this.panel3.Controls.Add(this.Txt_Email);
            this.panel3.Controls.Add(this.Lbl_Email);
            this.panel3.Controls.Add(this.Txt_Phone);
            this.panel3.Controls.Add(this.Lbl_Phone);
            this.panel3.Controls.Add(this.Btn_UploadPicture);
            this.panel3.Controls.Add(this.Pb_Picture);
            this.panel3.Controls.Add(this.Dgv_Members);
            this.panel3.Controls.Add(this.Lbl_Gender);
            this.panel3.Controls.Add(this.Txt_LName);
            this.panel3.Controls.Add(this.Lbl_LastName);
            this.panel3.Controls.Add(this.Txt_FName);
            this.panel3.Controls.Add(this.Txt_ID);
            this.panel3.Controls.Add(this.Lbl_FirstName);
            this.panel3.Controls.Add(this.Lbl_ID);
            this.panel3.Location = new System.Drawing.Point(204, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 711);
            this.panel3.TabIndex = 7;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Refresh.FlatAppearance.BorderSize = 0;
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Refresh.Location = new System.Drawing.Point(617, 638);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(200, 64);
            this.Btn_Refresh.TabIndex = 35;
            this.Btn_Refresh.Text = "Refresh table";
            this.Btn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Lbl_Picture
            // 
            this.Lbl_Picture.AutoSize = true;
            this.Lbl_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Picture.Location = new System.Drawing.Point(50, 462);
            this.Lbl_Picture.Name = "Lbl_Picture";
            this.Lbl_Picture.Size = new System.Drawing.Size(111, 32);
            this.Lbl_Picture.TabIndex = 34;
            this.Lbl_Picture.Text = "Picture:";
            // 
            // Grp_Gender
            // 
            this.Grp_Gender.Controls.Add(this.Rbtn_Female);
            this.Grp_Gender.Controls.Add(this.Rbtn_Male);
            this.Grp_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Grp_Gender.Location = new System.Drawing.Point(168, 171);
            this.Grp_Gender.Name = "Grp_Gender";
            this.Grp_Gender.Size = new System.Drawing.Size(200, 50);
            this.Grp_Gender.TabIndex = 33;
            this.Grp_Gender.TabStop = false;
            // 
            // Rbtn_Female
            // 
            this.Rbtn_Female.AutoSize = true;
            this.Rbtn_Female.Location = new System.Drawing.Point(96, 18);
            this.Rbtn_Female.Name = "Rbtn_Female";
            this.Rbtn_Female.Size = new System.Drawing.Size(98, 29);
            this.Rbtn_Female.TabIndex = 36;
            this.Rbtn_Female.TabStop = true;
            this.Rbtn_Female.Text = "Female";
            this.Rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Male
            // 
            this.Rbtn_Male.AutoSize = true;
            this.Rbtn_Male.Checked = true;
            this.Rbtn_Male.Location = new System.Drawing.Point(6, 18);
            this.Rbtn_Male.Name = "Rbtn_Male";
            this.Rbtn_Male.Size = new System.Drawing.Size(76, 29);
            this.Rbtn_Male.TabIndex = 35;
            this.Rbtn_Male.TabStop = true;
            this.Rbtn_Male.Text = "Male";
            this.Rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_Email.Location = new System.Drawing.Point(168, 300);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(200, 30);
            this.Txt_Email.TabIndex = 32;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Email.Location = new System.Drawing.Point(67, 297);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(94, 32);
            this.Lbl_Email.TabIndex = 31;
            this.Lbl_Email.Text = "Email:";
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_Phone.Location = new System.Drawing.Point(168, 243);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Size = new System.Drawing.Size(200, 30);
            this.Txt_Phone.TabIndex = 30;
            this.Txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Phone_KeyPress);
            // 
            // Lbl_Phone
            // 
            this.Lbl_Phone.AutoSize = true;
            this.Lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Phone.Location = new System.Drawing.Point(57, 240);
            this.Lbl_Phone.Name = "Lbl_Phone";
            this.Lbl_Phone.Size = new System.Drawing.Size(105, 32);
            this.Lbl_Phone.TabIndex = 29;
            this.Lbl_Phone.Text = "Phone:";
            // 
            // Btn_UploadPicture
            // 
            this.Btn_UploadPicture.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_UploadPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_UploadPicture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_UploadPicture.FlatAppearance.BorderSize = 0;
            this.Btn_UploadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UploadPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_UploadPicture.Location = new System.Drawing.Point(168, 638);
            this.Btn_UploadPicture.Name = "Btn_UploadPicture";
            this.Btn_UploadPicture.Size = new System.Drawing.Size(200, 64);
            this.Btn_UploadPicture.TabIndex = 27;
            this.Btn_UploadPicture.Text = "Upload";
            this.Btn_UploadPicture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_UploadPicture.UseVisualStyleBackColor = false;
            this.Btn_UploadPicture.Click += new System.EventHandler(this.Btn_UploadPicture_Click);
            // 
            // Pb_Picture
            // 
            this.Pb_Picture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pb_Picture.ImageLocation = "../../IMAGES/default_profile_picture.png";
            this.Pb_Picture.Location = new System.Drawing.Point(168, 352);
            this.Pb_Picture.Name = "Pb_Picture";
            this.Pb_Picture.Size = new System.Drawing.Size(200, 257);
            this.Pb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Picture.TabIndex = 28;
            this.Pb_Picture.TabStop = false;
            // 
            // Dgv_Members
            // 
            this.Dgv_Members.AllowUserToAddRows = false;
            this.Dgv_Members.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Members.Location = new System.Drawing.Point(404, 4);
            this.Dgv_Members.Name = "Dgv_Members";
            this.Dgv_Members.RowHeadersWidth = 51;
            this.Dgv_Members.RowTemplate.Height = 24;
            this.Dgv_Members.Size = new System.Drawing.Size(630, 605);
            this.Dgv_Members.TabIndex = 14;
            this.Dgv_Members.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Members_CellClick);
            // 
            // Lbl_Gender
            // 
            this.Lbl_Gender.AutoSize = true;
            this.Lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Gender.Location = new System.Drawing.Point(44, 183);
            this.Lbl_Gender.Name = "Lbl_Gender";
            this.Lbl_Gender.Size = new System.Drawing.Size(117, 32);
            this.Lbl_Gender.TabIndex = 10;
            this.Lbl_Gender.Text = "Gender:";
            // 
            // Txt_LName
            // 
            this.Txt_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_LName.Location = new System.Drawing.Point(168, 129);
            this.Txt_LName.Name = "Txt_LName";
            this.Txt_LName.Size = new System.Drawing.Size(200, 30);
            this.Txt_LName.TabIndex = 9;
            // 
            // Lbl_LastName
            // 
            this.Lbl_LastName.AutoSize = true;
            this.Lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_LastName.Location = new System.Drawing.Point(7, 126);
            this.Lbl_LastName.Name = "Lbl_LastName";
            this.Lbl_LastName.Size = new System.Drawing.Size(154, 32);
            this.Lbl_LastName.TabIndex = 8;
            this.Lbl_LastName.Text = "Last name:";
            // 
            // Txt_FName
            // 
            this.Txt_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_FName.Location = new System.Drawing.Point(168, 72);
            this.Txt_FName.Name = "Txt_FName";
            this.Txt_FName.Size = new System.Drawing.Size(200, 30);
            this.Txt_FName.TabIndex = 7;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_ID.Location = new System.Drawing.Point(168, 15);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.ReadOnly = true;
            this.Txt_ID.Size = new System.Drawing.Size(100, 30);
            this.Txt_ID.TabIndex = 6;
            // 
            // Lbl_FirstName
            // 
            this.Lbl_FirstName.AutoSize = true;
            this.Lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_FirstName.Location = new System.Drawing.Point(7, 69);
            this.Lbl_FirstName.Name = "Lbl_FirstName";
            this.Lbl_FirstName.Size = new System.Drawing.Size(155, 32);
            this.Lbl_FirstName.TabIndex = 5;
            this.Lbl_FirstName.Text = "First name:";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_ID.Location = new System.Drawing.Point(113, 12);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(49, 32);
            this.Lbl_ID.TabIndex = 4;
            this.Lbl_ID.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.Lbl_MembersCount);
            this.panel2.Controls.Add(this.Btn_Clear);
            this.panel2.Controls.Add(this.Btn_Delete);
            this.panel2.Controls.Add(this.Btn_Update);
            this.panel2.Controls.Add(this.Btn_Add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 716);
            this.panel2.TabIndex = 6;
            // 
            // Lbl_MembersCount
            // 
            this.Lbl_MembersCount.AutoSize = true;
            this.Lbl_MembersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_MembersCount.Location = new System.Drawing.Point(1, 681);
            this.Lbl_MembersCount.Name = "Lbl_MembersCount";
            this.Lbl_MembersCount.Size = new System.Drawing.Size(202, 32);
            this.Lbl_MembersCount.TabIndex = 35;
            this.Lbl_MembersCount.Text = "9999 Members";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Clear.FlatAppearance.BorderSize = 0;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Clear.Location = new System.Drawing.Point(12, 272);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(173, 80);
            this.Btn_Clear.TabIndex = 11;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Delete.Location = new System.Drawing.Point(12, 186);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(173, 80);
            this.Btn_Delete.TabIndex = 10;
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
            this.Btn_Update.Location = new System.Drawing.Point(12, 100);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(173, 80);
            this.Btn_Update.TabIndex = 9;
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
            this.Btn_Add.Location = new System.Drawing.Point(12, 14);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(173, 80);
            this.Btn_Add.TabIndex = 8;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Location = new System.Drawing.Point(1211, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Lbl_Members
            // 
            this.Lbl_Members.BackColor = System.Drawing.SystemColors.Info;
            this.Lbl_Members.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Members.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Members.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Members.Name = "Lbl_Members";
            this.Lbl_Members.Size = new System.Drawing.Size(1244, 78);
            this.Lbl_Members.TabIndex = 3;
            this.Lbl_Members.Text = "Members";
            this.Lbl_Members.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManageMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 794);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMembersForm";
            this.Load += new System.EventHandler(this.ManageMembersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Grp_Gender.ResumeLayout(false);
            this.Grp_Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Members)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Dgv_Members;
        private System.Windows.Forms.Label Lbl_Gender;
        private System.Windows.Forms.TextBox Txt_LName;
        private System.Windows.Forms.Label Lbl_LastName;
        private System.Windows.Forms.TextBox Txt_FName;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Lbl_FirstName;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_MembersCount;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Lbl_Members;
        private System.Windows.Forms.Button Btn_UploadPicture;
        private System.Windows.Forms.PictureBox Pb_Picture;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Txt_Phone;
        private System.Windows.Forms.Label Lbl_Phone;
        private System.Windows.Forms.Label Lbl_Picture;
        private System.Windows.Forms.GroupBox Grp_Gender;
        private System.Windows.Forms.RadioButton Rbtn_Female;
        private System.Windows.Forms.RadioButton Rbtn_Male;
        private System.Windows.Forms.Button Btn_Refresh;
    }
}