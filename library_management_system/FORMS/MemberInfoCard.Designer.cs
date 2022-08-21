namespace library_management_system.FORMS
{
    partial class MemberInfoCard
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
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lbl_FullName = new System.Windows.Forms.Label();
            this.Lbl_Gender = new System.Windows.Forms.Label();
            this.Lbl_Phone = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Pb_ProfilePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Location = new System.Drawing.Point(863, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 48;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Lbl_FullName
            // 
            this.Lbl_FullName.AutoSize = true;
            this.Lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_FullName.Location = new System.Drawing.Point(401, 80);
            this.Lbl_FullName.Name = "Lbl_FullName";
            this.Lbl_FullName.Size = new System.Drawing.Size(151, 32);
            this.Lbl_FullName.TabIndex = 45;
            this.Lbl_FullName.Text = "Full Name:";
            // 
            // Lbl_Gender
            // 
            this.Lbl_Gender.AutoSize = true;
            this.Lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Gender.Location = new System.Drawing.Point(401, 148);
            this.Lbl_Gender.Name = "Lbl_Gender";
            this.Lbl_Gender.Size = new System.Drawing.Size(117, 32);
            this.Lbl_Gender.TabIndex = 44;
            this.Lbl_Gender.Text = "Gender:";
            // 
            // Lbl_Phone
            // 
            this.Lbl_Phone.AutoSize = true;
            this.Lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Phone.Location = new System.Drawing.Point(401, 216);
            this.Lbl_Phone.Name = "Lbl_Phone";
            this.Lbl_Phone.Size = new System.Drawing.Size(105, 32);
            this.Lbl_Phone.TabIndex = 43;
            this.Lbl_Phone.Text = "Phone:";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Email.Location = new System.Drawing.Point(401, 284);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(94, 32);
            this.Lbl_Email.TabIndex = 42;
            this.Lbl_Email.Text = "Email:";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_ID.Location = new System.Drawing.Point(401, 12);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(49, 32);
            this.Lbl_ID.TabIndex = 39;
            this.Lbl_ID.Text = "ID:";
            // 
            // Pb_ProfilePicture
            // 
            this.Pb_ProfilePicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pb_ProfilePicture.ImageLocation = "";
            this.Pb_ProfilePicture.Location = new System.Drawing.Point(12, 12);
            this.Pb_ProfilePicture.Name = "Pb_ProfilePicture";
            this.Pb_ProfilePicture.Size = new System.Drawing.Size(383, 304);
            this.Pb_ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_ProfilePicture.TabIndex = 38;
            this.Pb_ProfilePicture.TabStop = false;
            // 
            // MemberInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(895, 334);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lbl_FullName);
            this.Controls.Add(this.Lbl_Gender);
            this.Controls.Add(this.Lbl_Phone);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Pb_ProfilePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberInfoCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberInfoCard";
            this.Load += new System.EventHandler(this.MemberInfoCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Lbl_FullName;
        private System.Windows.Forms.Label Lbl_Gender;
        private System.Windows.Forms.Label Lbl_Phone;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.PictureBox Pb_ProfilePicture;
    }
}