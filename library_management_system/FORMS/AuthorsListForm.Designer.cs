namespace library_management_system.FORMS
{
    partial class AuthorsListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lbx_Authors = new System.Windows.Forms.ListBox();
            this.Btn_SelectAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Authors List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Location = new System.Drawing.Point(350, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 7;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Lbx_Authors
            // 
            this.Lbx_Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbx_Authors.FormattingEnabled = true;
            this.Lbx_Authors.ItemHeight = 25;
            this.Lbx_Authors.Location = new System.Drawing.Point(11, 90);
            this.Lbx_Authors.Name = "Lbx_Authors";
            this.Lbx_Authors.Size = new System.Drawing.Size(362, 354);
            this.Lbx_Authors.TabIndex = 8;
            // 
            // Btn_SelectAuthor
            // 
            this.Btn_SelectAuthor.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_SelectAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SelectAuthor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_SelectAuthor.FlatAppearance.BorderSize = 0;
            this.Btn_SelectAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SelectAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_SelectAuthor.Location = new System.Drawing.Point(116, 466);
            this.Btn_SelectAuthor.Name = "Btn_SelectAuthor";
            this.Btn_SelectAuthor.Size = new System.Drawing.Size(159, 33);
            this.Btn_SelectAuthor.TabIndex = 32;
            this.Btn_SelectAuthor.Text = "Select Author";
            this.Btn_SelectAuthor.UseVisualStyleBackColor = false;
            this.Btn_SelectAuthor.Click += new System.EventHandler(this.Btn_SelectAuthor_Click);
            // 
            // AuthorsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 511);
            this.Controls.Add(this.Btn_SelectAuthor);
            this.Controls.Add(this.Lbx_Authors);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorsListForm";
            this.Load += new System.EventHandler(this.AuthorsListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.ListBox Lbx_Authors;
        private System.Windows.Forms.Button Btn_SelectAuthor;
    }
}