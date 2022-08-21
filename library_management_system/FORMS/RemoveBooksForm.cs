using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system.FORMS
{
    public partial class RemoveBooksForm : Form
    {
        public RemoveBooksForm()
        {
            InitializeComponent();
        }

        CLASSES.Books book = new CLASSES.Books();

        //close the form
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveBooksForm_Load(object sender, EventArgs e)
        {
            //display button images
            Btn_Close.Image = Image.FromFile("../../IMAGES/close_btn.png");
        }

        //remove book
        private void Btn_RemoveId_Click(object sender, EventArgs e)
        {
            int bookId = (int)Nud_ID.Value;

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
    }
}
