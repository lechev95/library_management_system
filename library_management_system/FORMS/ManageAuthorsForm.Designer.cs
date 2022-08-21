namespace library_management_system.FORMS
{
    partial class ManageAuthorsForm
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
            this.RTxt_Bio = new System.Windows.Forms.RichTextBox();
            this.Dgv_Authors = new System.Windows.Forms.DataGridView();
            this.Lbl_Bio = new System.Windows.Forms.Label();
            this.Txt_Edu = new System.Windows.Forms.TextBox();
            this.Lbl_Education = new System.Windows.Forms.Label();
            this.Txt_LName = new System.Windows.Forms.TextBox();
            this.Lbl_LastName = new System.Windows.Forms.Label();
            this.Txt_FName = new System.Windows.Forms.TextBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_FirstName = new System.Windows.Forms.Label();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_AuthorsCount = new System.Windows.Forms.Label();
            this.Btn_ShowBooks = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lbl_Authors = new System.Windows.Forms.Label();
            this.Btn_ExportToTxt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Authors)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Btn_Close);
            this.panel1.Controls.Add(this.Lbl_Authors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 584);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.RTxt_Bio);
            this.panel3.Controls.Add(this.Dgv_Authors);
            this.panel3.Controls.Add(this.Lbl_Bio);
            this.panel3.Controls.Add(this.Txt_Edu);
            this.panel3.Controls.Add(this.Lbl_Education);
            this.panel3.Controls.Add(this.Txt_LName);
            this.panel3.Controls.Add(this.Lbl_LastName);
            this.panel3.Controls.Add(this.Txt_FName);
            this.panel3.Controls.Add(this.Txt_ID);
            this.panel3.Controls.Add(this.Lbl_FirstName);
            this.panel3.Controls.Add(this.Lbl_ID);
            this.panel3.Location = new System.Drawing.Point(204, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 501);
            this.panel3.TabIndex = 7;
            // 
            // RTxt_Bio
            // 
            this.RTxt_Bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RTxt_Bio.Location = new System.Drawing.Point(168, 251);
            this.RTxt_Bio.Name = "RTxt_Bio";
            this.RTxt_Bio.Size = new System.Drawing.Size(200, 247);
            this.RTxt_Bio.TabIndex = 15;
            this.RTxt_Bio.Text = "";
            // 
            // Dgv_Authors
            // 
            this.Dgv_Authors.AllowUserToAddRows = false;
            this.Dgv_Authors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Authors.Location = new System.Drawing.Point(374, 4);
            this.Dgv_Authors.Name = "Dgv_Authors";
            this.Dgv_Authors.RowHeadersWidth = 51;
            this.Dgv_Authors.RowTemplate.Height = 24;
            this.Dgv_Authors.Size = new System.Drawing.Size(630, 494);
            this.Dgv_Authors.TabIndex = 14;
            this.Dgv_Authors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Authors_CellClick);
            // 
            // Lbl_Bio
            // 
            this.Lbl_Bio.AutoSize = true;
            this.Lbl_Bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Bio.Location = new System.Drawing.Point(93, 252);
            this.Lbl_Bio.Name = "Lbl_Bio";
            this.Lbl_Bio.Size = new System.Drawing.Size(64, 32);
            this.Lbl_Bio.TabIndex = 12;
            this.Lbl_Bio.Text = "Bio:";
            // 
            // Txt_Edu
            // 
            this.Txt_Edu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_Edu.Location = new System.Drawing.Point(168, 192);
            this.Txt_Edu.Name = "Txt_Edu";
            this.Txt_Edu.Size = new System.Drawing.Size(200, 30);
            this.Txt_Edu.TabIndex = 11;
            // 
            // Lbl_Education
            // 
            this.Lbl_Education.AutoSize = true;
            this.Lbl_Education.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Education.Location = new System.Drawing.Point(7, 192);
            this.Lbl_Education.Name = "Lbl_Education";
            this.Lbl_Education.Size = new System.Drawing.Size(150, 32);
            this.Lbl_Education.TabIndex = 10;
            this.Lbl_Education.Text = "Education:";
            // 
            // Txt_LName
            // 
            this.Txt_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_LName.Location = new System.Drawing.Point(168, 133);
            this.Txt_LName.Name = "Txt_LName";
            this.Txt_LName.Size = new System.Drawing.Size(200, 30);
            this.Txt_LName.TabIndex = 9;
            // 
            // Lbl_LastName
            // 
            this.Lbl_LastName.AutoSize = true;
            this.Lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_LastName.Location = new System.Drawing.Point(7, 132);
            this.Lbl_LastName.Name = "Lbl_LastName";
            this.Lbl_LastName.Size = new System.Drawing.Size(154, 32);
            this.Lbl_LastName.TabIndex = 8;
            this.Lbl_LastName.Text = "Last name:";
            // 
            // Txt_FName
            // 
            this.Txt_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_FName.Location = new System.Drawing.Point(168, 74);
            this.Txt_FName.Name = "Txt_FName";
            this.Txt_FName.Size = new System.Drawing.Size(200, 30);
            this.Txt_FName.TabIndex = 7;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_ID.Location = new System.Drawing.Point(168, 15);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(100, 30);
            this.Txt_ID.TabIndex = 6;
            // 
            // Lbl_FirstName
            // 
            this.Lbl_FirstName.AutoSize = true;
            this.Lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_FirstName.Location = new System.Drawing.Point(7, 72);
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
            this.panel2.Controls.Add(this.Btn_ExportToTxt);
            this.panel2.Controls.Add(this.Lbl_AuthorsCount);
            this.panel2.Controls.Add(this.Btn_ShowBooks);
            this.panel2.Controls.Add(this.Btn_Delete);
            this.panel2.Controls.Add(this.Btn_Update);
            this.panel2.Controls.Add(this.Btn_Add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 506);
            this.panel2.TabIndex = 6;
            // 
            // Lbl_AuthorsCount
            // 
            this.Lbl_AuthorsCount.AutoSize = true;
            this.Lbl_AuthorsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_AuthorsCount.Location = new System.Drawing.Point(1, 471);
            this.Lbl_AuthorsCount.Name = "Lbl_AuthorsCount";
            this.Lbl_AuthorsCount.Size = new System.Drawing.Size(199, 32);
            this.Lbl_AuthorsCount.TabIndex = 35;
            this.Lbl_AuthorsCount.Text = "99999 Authors";
            // 
            // Btn_ShowBooks
            // 
            this.Btn_ShowBooks.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_ShowBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ShowBooks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_ShowBooks.FlatAppearance.BorderSize = 0;
            this.Btn_ShowBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ShowBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_ShowBooks.Location = new System.Drawing.Point(12, 272);
            this.Btn_ShowBooks.Name = "Btn_ShowBooks";
            this.Btn_ShowBooks.Size = new System.Drawing.Size(173, 80);
            this.Btn_ShowBooks.TabIndex = 11;
            this.Btn_ShowBooks.Text = "Show Author Books";
            this.Btn_ShowBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ShowBooks.UseVisualStyleBackColor = false;
            this.Btn_ShowBooks.Click += new System.EventHandler(this.Btn_ShowBooks_Click);
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
            this.Btn_Close.Location = new System.Drawing.Point(1184, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Lbl_Authors
            // 
            this.Lbl_Authors.BackColor = System.Drawing.SystemColors.Info;
            this.Lbl_Authors.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Authors.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Authors.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Authors.Name = "Lbl_Authors";
            this.Lbl_Authors.Size = new System.Drawing.Size(1214, 78);
            this.Lbl_Authors.TabIndex = 3;
            this.Lbl_Authors.Text = "Authors";
            this.Lbl_Authors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_ExportToTxt
            // 
            this.Btn_ExportToTxt.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_ExportToTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExportToTxt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_ExportToTxt.FlatAppearance.BorderSize = 0;
            this.Btn_ExportToTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ExportToTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_ExportToTxt.Location = new System.Drawing.Point(12, 358);
            this.Btn_ExportToTxt.Name = "Btn_ExportToTxt";
            this.Btn_ExportToTxt.Size = new System.Drawing.Size(173, 80);
            this.Btn_ExportToTxt.TabIndex = 36;
            this.Btn_ExportToTxt.Text = "Export Authors To Txt File";
            this.Btn_ExportToTxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ExportToTxt.UseVisualStyleBackColor = false;
            this.Btn_ExportToTxt.Click += new System.EventHandler(this.Btn_ExportToTxt_Click);
            // 
            // ManageAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 584);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAuthorsForm";
            this.Load += new System.EventHandler(this.ManageAuthorsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Authors)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Authors;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label Lbl_Bio;
        private System.Windows.Forms.TextBox Txt_Edu;
        private System.Windows.Forms.Label Lbl_Education;
        private System.Windows.Forms.TextBox Txt_LName;
        private System.Windows.Forms.Label Lbl_LastName;
        private System.Windows.Forms.TextBox Txt_FName;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Lbl_FirstName;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.RichTextBox RTxt_Bio;
        private System.Windows.Forms.DataGridView Dgv_Authors;
        private System.Windows.Forms.Button Btn_ShowBooks;
        private System.Windows.Forms.Label Lbl_AuthorsCount;
        private System.Windows.Forms.Button Btn_ExportToTxt;
    }
}