using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace library_management_system.FORMS
{
    public partial class BookInfoCard : Form
    {
        int bookId;
        public BookInfoCard(int id)
        {
            InitializeComponent();
            bookId = id;
        }
        CLASSES.Books book = new CLASSES.Books();
        CLASSES.Author author = new CLASSES.Author();
        private void BookInfoCard_Load(object sender, EventArgs e)
        {
            //display button images
            Btn_Close.Image = Image.FromFile("../../IMAGES/close_btn.png");

            try
            {

                //display book info
                DataRow data = book.GetBookInfo(bookId);

                Lbl_ISBN.Text = data["Isbn"].ToString();
                Lbl_Title.Text = data["Title"].ToString();

                //fullname
                Lbl_Author.Text = data["Author"].ToString();
                Lbl_Price.Text = data["Price"].ToString();
                Lbl_Genre.Text = data["Genre"].ToString();

                int quantity = Convert.ToInt32(data["Quantity"].ToString());


                Lbl_NumOfBooks.Text = data["Quantity"].ToString();
                Lbl_Publisher.Text = data["Publisher"].ToString();
                Lbl_DateAdded.Text = data["DateReceived"].ToString();
                Rtb_Description.Text = data["Description"].ToString();

                //display the book cover
                byte[] cover = (byte[])data["Cover"];
                MemoryStream ms = new MemoryStream(cover);
                Pb_BookCover.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No book to show: " + ex.Message);
                Lbl_NumOfBooks.Visible = false;
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
