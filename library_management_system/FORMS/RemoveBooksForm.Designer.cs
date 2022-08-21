namespace library_management_system.FORMS
{
    partial class RemoveBooksForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nud_ID = new System.Windows.Forms.NumericUpDown();
            this.Btn_RemoveId = new System.Windows.Forms.Button();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Remove Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Location = new System.Drawing.Point(786, -2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 7;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.Nud_ID);
            this.panel1.Controls.Add(this.Btn_RemoveId);
            this.panel1.Controls.Add(this.Lbl_ID);
            this.panel1.Location = new System.Drawing.Point(10, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 152);
            this.panel1.TabIndex = 8;
            // 
            // Nud_ID
            // 
            this.Nud_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nud_ID.Location = new System.Drawing.Point(139, 70);
            this.Nud_ID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Nud_ID.Name = "Nud_ID";
            this.Nud_ID.Size = new System.Drawing.Size(343, 30);
            this.Nud_ID.TabIndex = 38;
            // 
            // Btn_RemoveId
            // 
            this.Btn_RemoveId.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_RemoveId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RemoveId.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_RemoveId.FlatAppearance.BorderSize = 0;
            this.Btn_RemoveId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RemoveId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_RemoveId.Location = new System.Drawing.Point(502, 67);
            this.Btn_RemoveId.Name = "Btn_RemoveId";
            this.Btn_RemoveId.Size = new System.Drawing.Size(159, 33);
            this.Btn_RemoveId.TabIndex = 37;
            this.Btn_RemoveId.Text = "Remove";
            this.Btn_RemoveId.UseVisualStyleBackColor = false;
            this.Btn_RemoveId.Click += new System.EventHandler(this.Btn_RemoveId_Click);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_ID.Location = new System.Drawing.Point(84, 67);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(49, 32);
            this.Lbl_ID.TabIndex = 35;
            this.Lbl_ID.Text = "ID:";
            // 
            // RemoveBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 254);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveBooksForm";
            this.Load += new System.EventHandler(this.RemoveBooksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_ID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_RemoveId;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.NumericUpDown Nud_ID;
    }
}