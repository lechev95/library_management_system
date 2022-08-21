namespace library_management_system.FORMS
{
    partial class ManageGenresForm
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
            this.Lbl_Genres = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Dgv_Genres = new System.Windows.Forms.DataGridView();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Genres)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Genres
            // 
            this.Lbl_Genres.BackColor = System.Drawing.SystemColors.Info;
            this.Lbl_Genres.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Genres.Location = new System.Drawing.Point(1, -1);
            this.Lbl_Genres.Name = "Lbl_Genres";
            this.Lbl_Genres.Size = new System.Drawing.Size(738, 78);
            this.Lbl_Genres.TabIndex = 2;
            this.Lbl_Genres.Text = "Genres";
            this.Lbl_Genres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.Btn_Delete);
            this.panel1.Controls.Add(this.Btn_Update);
            this.panel1.Controls.Add(this.Btn_Add);
            this.panel1.Controls.Add(this.Dgv_Genres);
            this.panel1.Controls.Add(this.Txt_Name);
            this.panel1.Controls.Add(this.Txt_ID);
            this.panel1.Controls.Add(this.Lbl_Name);
            this.panel1.Controls.Add(this.Lbl_ID);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 250);
            this.panel1.TabIndex = 3;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Delete.Location = new System.Drawing.Point(242, 176);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(102, 58);
            this.Btn_Delete.TabIndex = 7;
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
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Update.Location = new System.Drawing.Point(126, 176);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(102, 58);
            this.Btn_Update.TabIndex = 6;
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
            this.Btn_Add.Location = new System.Drawing.Point(10, 176);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(102, 58);
            this.Btn_Add.TabIndex = 5;
            this.Btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Dgv_Genres
            // 
            this.Dgv_Genres.AllowUserToAddRows = false;
            this.Dgv_Genres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Genres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Genres.Location = new System.Drawing.Point(350, 11);
            this.Dgv_Genres.Name = "Dgv_Genres";
            this.Dgv_Genres.RowHeadersWidth = 51;
            this.Dgv_Genres.RowTemplate.Height = 24;
            this.Dgv_Genres.Size = new System.Drawing.Size(352, 223);
            this.Dgv_Genres.TabIndex = 4;
            this.Dgv_Genres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Genres_CellClick);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_Name.Location = new System.Drawing.Point(118, 75);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(200, 38);
            this.Txt_Name.TabIndex = 3;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_ID.Location = new System.Drawing.Point(118, 11);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(100, 38);
            this.Txt_ID.TabIndex = 2;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Name.Location = new System.Drawing.Point(15, 75);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(97, 32);
            this.Lbl_Name.TabIndex = 1;
            this.Lbl_Name.Text = "Name:";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_ID.Location = new System.Drawing.Point(63, 11);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(49, 32);
            this.Lbl_ID.TabIndex = 0;
            this.Lbl_ID.Text = "ID:";
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Location = new System.Drawing.Point(709, -1);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // ManageGenresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 350);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_Genres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageGenresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageGenresForm";
            this.Load += new System.EventHandler(this.ManageGenresForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Genres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Genres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.DataGridView Dgv_Genres;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
    }
}