using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace library_management_system.FORMS
{
    public partial class BooksListForm : Form
    {
        int authorId;
        string fullName;
        public BooksListForm(int id, string name)
        {
            InitializeComponent();
            this.authorId = id;
            this.fullName = name;
        }

        private void Lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BooksListForm_Load(object sender, EventArgs e)
        {
            //display the selected author fullname
            Lbl_BooksBy.Text = "Books by: " + fullName;
            //display author books in the listview
            CLASSES.Books book = new CLASSES.Books();
            DataTable booksList = book.AuthorsBooks(authorId);

            ListViewItem[] items = new ListViewItem[booksList.Rows.Count];
            String[] titles = new String[booksList.Rows.Count];

            //loop to populate titles and images
            for (int i = 0; i < booksList.Rows.Count; i++)
            {
                byte[] img = (byte[])booksList.Rows[i][10];
                MemoryStream ms = new MemoryStream(img);

                //add image to image list
                Il_BooksCovers.Images.Add(Image.FromStream(ms));

                //add title to the titles array
                titles[i] = booksList.Rows[i][2].ToString();
            }

            Lv_Books.View = View.LargeIcon;
            Il_BooksCovers.ImageSize = new Size(200, 250);
            Lv_Books.LargeImageList = Il_BooksCovers;

            //loop to display the data in the listview
            for (int j = 0; j < Il_BooksCovers.Images.Count; j++)
            {
                Lv_Books.Items.Add(new ListViewItem()
                {
                    Text = titles[j].ToString(),
                    ImageIndex = j
                });
            }
        }
    }
}
