namespace library_management_system.FORMS
{
    partial class BooksListForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Exit = new System.Windows.Forms.Label();
            this.Lbl_AuthorBooks = new System.Windows.Forms.Label();
            this.Lv_Books = new System.Windows.Forms.ListView();
            this.Lbl_BooksBy = new System.Windows.Forms.Label();
            this.Il_BooksCovers = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.Lbl_BooksBy);
            this.panel1.Controls.Add(this.Lv_Books);
            this.panel1.Controls.Add(this.Lbl_Exit);
            this.panel1.Controls.Add(this.Lbl_AuthorBooks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 639);
            this.panel1.TabIndex = 1;
            // 
            // Lbl_Exit
            // 
            this.Lbl_Exit.BackColor = System.Drawing.SystemColors.Info;
            this.Lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Exit.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Exit.Location = new System.Drawing.Point(542, 0);
            this.Lbl_Exit.Name = "Lbl_Exit";
            this.Lbl_Exit.Size = new System.Drawing.Size(26, 26);
            this.Lbl_Exit.TabIndex = 1;
            this.Lbl_Exit.Text = "X";
            this.Lbl_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Exit.Click += new System.EventHandler(this.Lbl_Exit_Click);
            // 
            // Lbl_AuthorBooks
            // 
            this.Lbl_AuthorBooks.BackColor = System.Drawing.SystemColors.Info;
            this.Lbl_AuthorBooks.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_AuthorBooks.Location = new System.Drawing.Point(-2, 0);
            this.Lbl_AuthorBooks.Name = "Lbl_AuthorBooks";
            this.Lbl_AuthorBooks.Size = new System.Drawing.Size(573, 78);
            this.Lbl_AuthorBooks.TabIndex = 1;
            this.Lbl_AuthorBooks.Text = "Author Books";
            this.Lbl_AuthorBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lv_Books
            // 
            this.Lv_Books.HideSelection = false;
            this.Lv_Books.Location = new System.Drawing.Point(12, 106);
            this.Lv_Books.Name = "Lv_Books";
            this.Lv_Books.Size = new System.Drawing.Size(547, 522);
            this.Lv_Books.TabIndex = 2;
            this.Lv_Books.UseCompatibleStateImageBehavior = false;
            // 
            // Lbl_BooksBy
            // 
            this.Lbl_BooksBy.AutoSize = true;
            this.Lbl_BooksBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_BooksBy.Location = new System.Drawing.Point(3, 78);
            this.Lbl_BooksBy.Name = "Lbl_BooksBy";
            this.Lbl_BooksBy.Size = new System.Drawing.Size(274, 25);
            this.Lbl_BooksBy.TabIndex = 3;
            this.Lbl_BooksBy.Text = "Books by: the author full name";
            // 
            // Il_BooksCovers
            // 
            this.Il_BooksCovers.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Il_BooksCovers.ImageSize = new System.Drawing.Size(16, 16);
            this.Il_BooksCovers.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BooksListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 640);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksListForm";
            this.Load += new System.EventHandler(this.BooksListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Exit;
        private System.Windows.Forms.Label Lbl_AuthorBooks;
        private System.Windows.Forms.Label Lbl_BooksBy;
        private System.Windows.Forms.ListView Lv_Books;
        private System.Windows.Forms.ImageList Il_BooksCovers;
    }
}