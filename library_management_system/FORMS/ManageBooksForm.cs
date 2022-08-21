using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace library_management_system.FORMS
{
    public partial class ManageBooksForm : Form
    {
        public ManageBooksForm()
        {
            InitializeComponent();
        }

        CLASSES.Books book = new CLASSES.Books();
        CLASSES.Genres genre = new CLASSES.Genres();
        CLASSES.Author author = new CLASSES.Author();

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            //display button images
            Btn_Close.Image = Image.FromFile("../../IMAGES/close_btn.png");
            Btn_Add.Image = Image.FromFile("../../IMAGES/add.png");
            Btn_Update.Image = Image.FromFile("../../IMAGES/update.png");
            Btn_Delete.Image = Image.FromFile("../../IMAGES/delete.png");
            Btn_UploadCover.Image = Image.FromFile("../../IMAGES/upload.png");
            Btn_UpdateUploadCover.Image = Image.FromFile("../../IMAGES/upload.png");
            Btn_ShowBooksList.Image = Image.FromFile("../../IMAGES/literature.png");
            Btn_ExportToTxt.Image = Image.FromFile("../../IMAGES/export.png");

            //populate combobox with genres
            Cmb_Genre.DataSource = genre.GenreList();
            Cmb_Genre.DisplayMember = "GenreName";
            Cmb_Genre.ValueMember = "Id";

            int numberOfBooks = book.BookList().Rows.Count + 1;
            Txt_ID.Text = numberOfBooks.ToString();

            //show add panel by default
            panelAdd.BringToFront();

            //show the books counter
            Lbl_BooksCount.Text = book.BookList().Rows.Count.ToString() + " Books";

            //customize dgv header
            Dgv_Books.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.MenuText;
            Dgv_Books.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
            Dgv_Books.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Books.EnableHeadersVisualStyles = false;
        }

        //close current window
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //browse and display book cover
        private void Btn_UploadCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //image types
            ofd.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //display image in the picturebox
                Pbx_Cover.Image = Image.FromFile(ofd.FileName);
            }
        }

        //show authors list in new form
        private void Btn_SelectAuthor_Click(object sender, EventArgs e)
        {
            AuthorsListForm authorsListForm = new AuthorsListForm(this);
            authorsListForm.Show();
        }

        //add new book
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //get data

            int authorId;
            int genreId;
            int quantity;
            decimal price;
            string isbn = Txt_ISBN.Text;
            string title = Txt_Title.Text;
            string publisher = Txt_Publisher.Text;
            string description = RTxt_Description.Text;
            DateTime dtRcv = Dtp_DateReceived.Value;

            MemoryStream ms = new MemoryStream();
            Pbx_Cover.Image.Save(ms, Pbx_Cover.Image.RawFormat);
            byte[] bookCover = ms.ToArray();

            try
            {
                authorId = Convert.ToInt32(Lbl_AuthorID.Text);
                genreId = Convert.ToInt32(Cmb_Genre.SelectedValue);
                quantity = Convert.ToInt32(Nud_Quantity.Value);
                price = Convert.ToDecimal(Txt_Price.Text);

                //the book isbn needs to be unique
                if (!book.IsIsbnExists(isbn, 0))
                {
                    if (!book.IsTitleExists(title, 0))
                    {
                        if (book.AddBook(isbn, title, authorId, genreId, quantity, price, publisher, dtRcv, description, bookCover))
                        {
                            MessageBox.Show("New Book added successfully", "Book added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //refresh the books counter
                            Lbl_BooksCount.Text = book.BookList().Rows.Count.ToString() + " Books";
                        }
                        else
                        {
                            MessageBox.Show("Book not added", "Add error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Book title already exists, enter a new one", "Duplicate Title", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("This Book ISBN already exists, enter a new one", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (var control in panelAdd.Controls)
            {
                if(control.GetType() == typeof(TextBox))
                {
                    TextBox tb = control as TextBox;
                    tb.Text = "";
                } 
            }

            RTxt_Description.Text = "";
            Lbl_AuthorID.Text = "ID:";
            Nud_Quantity.Value = 0;
            Cmb_Genre.Text = "";
            Cmb_Author.Text = ""; 
            Dtp_DateReceived.Value = DateTime.Now;
            Pbx_Cover.ImageLocation = "../../IMAGES/default_book.png";

            int numberOfBooks = book.BookList().Rows.Count;
            int lastBookId = 1;

            if (numberOfBooks > 0)
            {
                lastBookId = Convert.ToInt32(book.BookList().Rows[numberOfBooks - 1][0].ToString()) + 1;
            }

            Txt_ID.Text = lastBookId.ToString();
        }

        //show the add panel
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            panelAdd.BringToFront();

            //clear authorId and txtbox
            Cmb_Author.Text = "";
            Lbl_AuthorID.Text = "ID:";
        }

        //show edit panel
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            panelUpdate.BringToFront();

            //populate combobox with genres
            Cmb_UpdateGenre.DataSource = genre.GenreList();
            Cmb_UpdateGenre.DisplayMember = "GenreName";
            Cmb_UpdateGenre.ValueMember = "Id";

            //clear authorId and txtbox
            Cmb_UpdateAuthor.Text = "";
            Lbl_UpdateAuthorID.Text = "ID:";
        }

        private void Btn_UpdateUploadCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //image types
            ofd.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //display image in the picturebox
                Pb_UpdateCover.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Btn_SearchId_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Txt_UpdateID.Text);
                DataTable data = book.SearchByIdOrIsbn("Id", id, "");

                if (data.Rows.Count > 0)
                {
                    DisplayData(data);
                }
                else
                {
                    MessageBox.Show("This ID doesn't exist, enter a valid one", "ID not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_SearchISBN_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = Txt_UpdateISBN.Text;
                DataTable data = book.SearchByIdOrIsbn("Isbn", 00, isbn);

                if (data.Rows.Count > 0)
                {
                    DisplayData(data);
                }
                else
                {
                    MessageBox.Show("This ISBN doesn't exist, enter a valid one", "ISBN not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_UpdateSelectAuthor_Click(object sender, EventArgs e)
        {
            AuthorsListForm authorsListForm = new AuthorsListForm(this);
            authorsListForm.Show();
        }

        private void Btn_UpdateClear_Click(object sender, EventArgs e)
        {
            foreach (var control in panelUpdate.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox tb = control as TextBox;
                    tb.Text = "";
                }
            }

            Rtx_UpdateDescription.Text = "";
            Lbl_UpdateAuthorID.Text = "ID:";
            Nud_UpdateQuantity.Value = 0;
            Cmb_UpdateGenre.Text = "";
            Cmb_UpdateAuthor.Text = "";
            Dtp_UpdateDrcv.Value = DateTime.Now;
            Pb_UpdateCover.ImageLocation = "../../IMAGES/default_book.png";

            //int numberOfBooks = book.BookList().Rows.Count + 1;
            //Txt_ID.Text = numberOfBooks.ToString();
        }

        //save updated books
        private void Btn_UpdateSave_Click(object sender, EventArgs e)
        {
            //get data
            int id; 

            int authorId;
            int genreId;
            int quantity;
            decimal price;
            string isbn = Txt_UpdateISBN.Text;
            string title = Txt_UpdateTitle.Text;
            string publisher = Txt_UpdatePublisher.Text;
            string description = Rtx_UpdateDescription.Text;
            DateTime dtRcv = Dtp_UpdateDrcv.Value;

            MemoryStream ms = new MemoryStream();
            Pb_UpdateCover.Image.Save(ms, Pb_UpdateCover.Image.RawFormat);
            byte[] bookCover = ms.ToArray();

            try
            {
                id = Convert.ToInt32(Txt_UpdateID.Text);
                authorId = Convert.ToInt32(Lbl_UpdateAuthorID.Text);
                genreId = Convert.ToInt32(Cmb_UpdateGenre.SelectedValue);
                quantity = Convert.ToInt32(Nud_UpdateQuantity.Value);
                price = Convert.ToDecimal(Txt_UpdatePrice.Text);

                //the book isbn needs to be unique
                if (!book.IsIsbnExists(isbn, id))
                {
                    if (!book.IsTitleExists(title, id))
                    {
                        if (book.UpdateBook(id, isbn, title, authorId, genreId, quantity, price, publisher, dtRcv, description, bookCover))
                        {
                            MessageBox.Show("Book updated successfully", "Book updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Book not updated", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Book title already exists, enter a new one", "Duplicate Title", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("This Book ISBN already exists, enter a new one", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //display data in fields
        public void DisplayData(DataTable data)
        {
            //display book data
            Txt_UpdateID.Text = data.Rows[0][0].ToString();
            Txt_UpdateISBN.Text = data.Rows[0][1].ToString();

            //get author data
            int authorId = Convert.ToInt32(data.Rows[0][3].ToString());
            DataTable authorData = author.GetAuthorsById(authorId);
            Txt_UpdateTitle.Text = data.Rows[0][2].ToString();
            Cmb_UpdateAuthor.Text = authorData.Rows[0][1].ToString() + " " + authorData.Rows[0][2].ToString();
            Lbl_UpdateAuthorID.Text = data.Rows[0][3].ToString();
            Cmb_UpdateGenre.SelectedValue = data.Rows[0][4].ToString();
            Nud_UpdateQuantity.Value = Convert.ToInt32(data.Rows[0][5]);
            Txt_UpdatePrice.Text = data.Rows[0][6].ToString();
            Txt_UpdatePublisher.Text = data.Rows[0][7].ToString();
            Dtp_UpdateDrcv.Value = (DateTime)data.Rows[0][8];
            Rtx_UpdateDescription.Text = data.Rows[0][9].ToString();

            //display the book cover
            byte[] cover = (byte[])data.Rows[0][10];
            MemoryStream ms = new MemoryStream(cover);
            Pb_UpdateCover.Image = Image.FromStream(ms);
        }

        //show the books list
        private void Btn_ShowBooksList_Click(object sender, EventArgs e)
        {
            panelShowBooks.BringToFront();

            //customize the data grid view rows height
            Dgv_Books.RowTemplate.Height = 75;

            //display books in datagridView
            Dgv_Books.DataSource = book.BookList();

            //customize the data grid view image column
            DataGridViewImageColumn dgvImgCol = new DataGridViewImageColumn();
            dgvImgCol = (DataGridViewImageColumn)Dgv_Books.Columns[10];
            dgvImgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //customize dgv header
            Dgv_Books.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.MenuText;
            Dgv_Books.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
            Dgv_Books.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Books.EnableHeadersVisualStyles = false;
        }

        //delete the selected book
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //show remove book form
            RemoveBooksForm rmvBkF = new RemoveBooksForm();
            rmvBkF.Show();
        }

        //update book - in book list panel
        private void Btn_UpdateBook_Click(object sender, EventArgs e)
        {
            //show update panel and display selected book (from data grid view) data in the fields
            panelUpdate.BringToFront();

            //populate combobox with genres
            Cmb_UpdateGenre.DataSource = genre.GenreList();
            Cmb_UpdateGenre.DisplayMember = "GenreName";
            Cmb_UpdateGenre.ValueMember = "Id";

            int id = Convert.ToInt32(Dgv_Books.CurrentRow.Cells[0].Value);
            DataTable data = book.SearchByIdOrIsbn("Id", id, "");

            if (data.Rows.Count > 0)
            {
                DisplayData(data);
            }
            else
            {
                MessageBox.Show("This ID doesn't exist, enter a valid one", "ID not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Btn_ExportToTxt_Click(object sender, EventArgs e)
        {
            Btn_ShowBooksList.PerformClick();

            string filePath = "../../EXPORT/books.txt";

            if (!File.Exists(filePath)) //check if this file exists
            {
                File.Create(filePath).Close();//create file
                MessageBox.Show("File created.");
            }

            //populate file with author id and full name
            TextWriter writer = new StreamWriter(filePath);

            string id;
            string isbn;
            string title;

            for (int rows = 0; rows < Dgv_Books.Rows.Count; rows++)
            {
                //for (int cols = 0; cols < Dgv_Authors.Columns.Count; cols++)
                //{
                //    writer.Write(Dgv_Authors.Rows[rows].Cells[cols].Value.ToString());
                //}
                id = Dgv_Books.Rows[rows].Cells[0].Value.ToString();
                isbn = Dgv_Books.Rows[rows].Cells[1].Value.ToString();
                title = Dgv_Books.Rows[rows].Cells[2].Value.ToString();
                writer.Write(id + " " + isbn + " " + title);
                writer.WriteLine();
                writer.WriteLine("----------------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void Btn_ClearFields_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = Convert.ToInt32(Dgv_Books.CurrentRow.Cells[0].Value.ToString());

                //show confirmation message before deleting book
                if (MessageBox.Show("Do you really want to delete this book?", "Confirmation box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (book.DeleteBook(bookId))
                    {
                        MessageBox.Show("Selected book deleted successfully", "Book deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Book not deleted", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No book is selected " + ex.Message, "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
