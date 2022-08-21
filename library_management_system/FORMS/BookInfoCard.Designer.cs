namespace library_management_system.FORMS
{
    partial class BookInfoCard
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
            this.Pb_BookCover = new System.Windows.Forms.PictureBox();
            this.Lbl_ISBN = new System.Windows.Forms.Label();
            this.Lbl_Publisher = new System.Windows.Forms.Label();
            this.Lbl_Price = new System.Windows.Forms.Label();
            this.Lbl_Quantity = new System.Windows.Forms.Label();
            this.Lbl_Genre = new System.Windows.Forms.Label();
            this.Lbl_Author = new System.Windows.Forms.Label();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_DateAdded = new System.Windows.Forms.Label();
            this.Rtb_Description = new System.Windows.Forms.RichTextBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lbl_NumOfBooks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_BookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_BookCover
            // 
            this.Pb_BookCover.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pb_BookCover.ImageLocation = "";
            this.Pb_BookCover.Location = new System.Drawing.Point(12, 12);
            this.Pb_BookCover.Name = "Pb_BookCover";
            this.Pb_BookCover.Size = new System.Drawing.Size(383, 372);
            this.Pb_BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_BookCover.TabIndex = 27;
            this.Pb_BookCover.TabStop = false;
            // 
            // Lbl_ISBN
            // 
            this.Lbl_ISBN.AutoSize = true;
            this.Lbl_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_ISBN.Location = new System.Drawing.Point(401, 12);
            this.Lbl_ISBN.Name = "Lbl_ISBN";
            this.Lbl_ISBN.Size = new System.Drawing.Size(87, 32);
            this.Lbl_ISBN.TabIndex = 28;
            this.Lbl_ISBN.Text = "ISBN:";
            // 
            // Lbl_Publisher
            // 
            this.Lbl_Publisher.AutoSize = true;
            this.Lbl_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Publisher.Location = new System.Drawing.Point(401, 420);
            this.Lbl_Publisher.Name = "Lbl_Publisher";
            this.Lbl_Publisher.Size = new System.Drawing.Size(142, 32);
            this.Lbl_Publisher.TabIndex = 29;
            this.Lbl_Publisher.Text = "Publisher:";
            // 
            // Lbl_Price
            // 
            this.Lbl_Price.AutoSize = true;
            this.Lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Price.Location = new System.Drawing.Point(401, 352);
            this.Lbl_Price.Name = "Lbl_Price";
            this.Lbl_Price.Size = new System.Drawing.Size(87, 32);
            this.Lbl_Price.TabIndex = 30;
            this.Lbl_Price.Text = "Price:";
            // 
            // Lbl_Quantity
            // 
            this.Lbl_Quantity.AutoSize = true;
            this.Lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Quantity.Location = new System.Drawing.Point(401, 284);
            this.Lbl_Quantity.Name = "Lbl_Quantity";
            this.Lbl_Quantity.Size = new System.Drawing.Size(129, 32);
            this.Lbl_Quantity.TabIndex = 31;
            this.Lbl_Quantity.Text = "Quantity:";
            // 
            // Lbl_Genre
            // 
            this.Lbl_Genre.AutoSize = true;
            this.Lbl_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Genre.Location = new System.Drawing.Point(401, 216);
            this.Lbl_Genre.Name = "Lbl_Genre";
            this.Lbl_Genre.Size = new System.Drawing.Size(101, 32);
            this.Lbl_Genre.TabIndex = 32;
            this.Lbl_Genre.Text = "Genre:";
            // 
            // Lbl_Author
            // 
            this.Lbl_Author.AutoSize = true;
            this.Lbl_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Author.Location = new System.Drawing.Point(401, 148);
            this.Lbl_Author.Name = "Lbl_Author";
            this.Lbl_Author.Size = new System.Drawing.Size(106, 32);
            this.Lbl_Author.TabIndex = 33;
            this.Lbl_Author.Text = "Author:";
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Title.Location = new System.Drawing.Point(401, 80);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(77, 32);
            this.Lbl_Title.TabIndex = 34;
            this.Lbl_Title.Text = "Title:";
            // 
            // Lbl_DateAdded
            // 
            this.Lbl_DateAdded.AutoSize = true;
            this.Lbl_DateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_DateAdded.Location = new System.Drawing.Point(401, 488);
            this.Lbl_DateAdded.Name = "Lbl_DateAdded";
            this.Lbl_DateAdded.Size = new System.Drawing.Size(172, 32);
            this.Lbl_DateAdded.TabIndex = 35;
            this.Lbl_DateAdded.Text = "Date Added:";
            // 
            // Rtb_Description
            // 
            this.Rtb_Description.Location = new System.Drawing.Point(12, 390);
            this.Rtb_Description.Name = "Rtb_Description";
            this.Rtb_Description.Size = new System.Drawing.Size(383, 146);
            this.Rtb_Description.TabIndex = 36;
            this.Rtb_Description.Text = "";
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
            this.Btn_Close.TabIndex = 37;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Lbl_NumOfBooks
            // 
            this.Lbl_NumOfBooks.AutoSize = true;
            this.Lbl_NumOfBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_NumOfBooks.Location = new System.Drawing.Point(536, 284);
            this.Lbl_NumOfBooks.Name = "Lbl_NumOfBooks";
            this.Lbl_NumOfBooks.Size = new System.Drawing.Size(62, 32);
            this.Lbl_NumOfBooks.TabIndex = 38;
            this.Lbl_NumOfBooks.Text = "100";
            // 
            // BookInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(895, 548);
            this.Controls.Add(this.Lbl_NumOfBooks);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Rtb_Description);
            this.Controls.Add(this.Lbl_DateAdded);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Lbl_Author);
            this.Controls.Add(this.Lbl_Genre);
            this.Controls.Add(this.Lbl_Quantity);
            this.Controls.Add(this.Lbl_Price);
            this.Controls.Add(this.Lbl_Publisher);
            this.Controls.Add(this.Lbl_ISBN);
            this.Controls.Add(this.Pb_BookCover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookInfoCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfoCard";
            this.Load += new System.EventHandler(this.BookInfoCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_BookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_BookCover;
        private System.Windows.Forms.Label Lbl_ISBN;
        private System.Windows.Forms.Label Lbl_Publisher;
        private System.Windows.Forms.Label Lbl_Price;
        private System.Windows.Forms.Label Lbl_Quantity;
        private System.Windows.Forms.Label Lbl_Genre;
        private System.Windows.Forms.Label Lbl_Author;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_DateAdded;
        private System.Windows.Forms.RichTextBox Rtb_Description;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Lbl_NumOfBooks;
    }
}