namespace library_management_system.FORMS
{
    partial class Login_Form
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Txt_Pass = new System.Windows.Forms.TextBox();
            this.Pb_Pass = new System.Windows.Forms.PictureBox();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Pb_User = new System.Windows.Forms.PictureBox();
            this.Lbl_Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_User)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Controls.Add(this.Btn_Login);
            this.panel1.Controls.Add(this.Txt_Pass);
            this.panel1.Controls.Add(this.Pb_Pass);
            this.panel1.Controls.Add(this.Txt_UserName);
            this.panel1.Controls.Add(this.Pb_User);
            this.panel1.Controls.Add(this.Lbl_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 291);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(86, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(86, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Exit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Btn_Exit.Location = new System.Drawing.Point(232, 243);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(120, 36);
            this.Btn_Exit.TabIndex = 7;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Login.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Btn_Login.Location = new System.Drawing.Point(85, 243);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(120, 36);
            this.Btn_Login.TabIndex = 6;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.Location = new System.Drawing.Point(85, 215);
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.PasswordChar = '*';
            this.Txt_Pass.Size = new System.Drawing.Size(267, 22);
            this.Txt_Pass.TabIndex = 5;
            // 
            // Pb_Pass
            // 
            this.Pb_Pass.BackColor = System.Drawing.SystemColors.Window;
            this.Pb_Pass.Location = new System.Drawing.Point(24, 183);
            this.Pb_Pass.Name = "Pb_Pass";
            this.Pb_Pass.Size = new System.Drawing.Size(55, 54);
            this.Pb_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Pass.TabIndex = 4;
            this.Pb_Pass.TabStop = false;
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(85, 133);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(267, 22);
            this.Txt_UserName.TabIndex = 3;
            // 
            // Pb_User
            // 
            this.Pb_User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pb_User.BackColor = System.Drawing.SystemColors.Window;
            this.Pb_User.Location = new System.Drawing.Point(24, 101);
            this.Pb_User.Name = "Pb_User";
            this.Pb_User.Size = new System.Drawing.Size(55, 54);
            this.Pb_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_User.TabIndex = 2;
            this.Pb_User.TabStop = false;
            // 
            // Lbl_Exit
            // 
            this.Lbl_Exit.BackColor = System.Drawing.SystemColors.Info;
            this.Lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Exit.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Exit.Location = new System.Drawing.Point(361, 0);
            this.Lbl_Exit.Name = "Lbl_Exit";
            this.Lbl_Exit.Size = new System.Drawing.Size(26, 26);
            this.Lbl_Exit.TabIndex = 1;
            this.Lbl_Exit.Text = "X";
            this.Lbl_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Exit.Click += new System.EventHandler(this.Lbl_Exit_Click);
            this.Lbl_Exit.MouseEnter += new System.EventHandler(this.Lbl_Exit_MouseEnter);
            this.Lbl_Exit.MouseLeave += new System.EventHandler(this.Lbl_Exit_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 291);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox Txt_Pass;
        private System.Windows.Forms.PictureBox Pb_Pass;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.PictureBox Pb_User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}