using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace library_management_system.FORMS
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        CLASSES.Author author = new CLASSES.Author();
        CLASSES.Books book = new CLASSES.Books();
        CLASSES.Members member = new CLASSES.Members();

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            Pb_Logo.Image = Image.FromFile("../../IMAGES/library_logo.png");
            Btn_Close.Image = Image.FromFile("../../IMAGES/close_btn.png");
            Btn_Books.Image = Image.FromFile("../../IMAGES/literature.png");
            Btn_Authors.Image = Image.FromFile("../../IMAGES/author.png");
            Btn_Members.Image = Image.FromFile("../../IMAGES/members.png");
            Btn_Genres.Image = Image.FromFile("../../IMAGES/tag.png");
            Btn_Circulation.Image = Image.FromFile("../../IMAGES/circulation.png");
            Btn_Users.Image = Image.FromFile("../../IMAGES/users.png");

            //display the last 5 books images in main screen
            DataTable bookData = book.BookList();
            byte[] img;
            MemoryStream ms;
            int i = 0;

            //loop to display all images
            foreach (var control in panelDisplayBooks.Controls)
            {
                if (control.GetType() == typeof(Panel))
                {
                    Panel panel = (Panel)control;
                    img = (byte[])bookData.Rows[i][10];
                    ms = new MemoryStream(img);
                    panel.BackgroundImage = Image.FromStream(ms);
                    panel.BackgroundImageLayout = ImageLayout.Stretch;

                    //display book price
                    foreach (var lblControl in panel.Controls)
                    {
                        if (lblControl.GetType() == typeof(Label))
                        {
                            Label label = (Label)lblControl;
                            label.Text = "$" + bookData.Rows[i][6].ToString();
                        }
                    }
                    i++;
                }
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;

            //show login form
            Login_Form lgf = new Login_Form(this);
            lgf.Show();

            //show the authors counter
            Lbl_AuthorsCount.Text = author.AuthorList(false).Rows.Count.ToString();

            //show the books counter
            Lbl_BooksCount.Text = book.BookList().Rows.Count.ToString();

            //show the users counter
            Lbl_UsersCount.Text = member.MemberList().Rows.Count.ToString();
        }

        private void Btn_Genres_Click(object sender, EventArgs e)
        {
            ManageGenresForm mgf = new ManageGenresForm();
            mgf.Show();
        }

        private void Btn_Authors_Click(object sender, EventArgs e)
        {
            ManageAuthorsForm maf = new ManageAuthorsForm();
            maf.Show();
        }

        private void Btn_Books_Click(object sender, EventArgs e)
        {
            ManageBooksForm mbf = new ManageBooksForm();
            mbf.Show();
        }

        private void Btn_Members_Click(object sender, EventArgs e)
        {
            ManageMembersForm mmf = new ManageMembersForm();
            mmf.Show();
        }

        //view changes on main screen
        private void Pb_Logo_Click(object sender, EventArgs e)
        {
            //show the authors counter
            Lbl_AuthorsCount.Text = author.AuthorList(false).Rows.Count.ToString();

            //show the books counter
            Lbl_BooksCount.Text = book.BookList().Rows.Count.ToString();

            //show the users counter
            Lbl_UsersCount.Text = member.MemberList().Rows.Count.ToString();

            //display the last 5 books images in main screen
            DataTable bookData = book.BookList();
            byte[] img;
            MemoryStream ms;
            int i = 0;

            //loop to display all images
            foreach (var control in panelDisplayBooks.Controls)
            {
                if (control.GetType() == typeof(Panel))
                {
                    Panel panel = (Panel)control;
                    img = (byte[])bookData.Rows[i][10];
                    ms = new MemoryStream(img);
                    panel.BackgroundImage = Image.FromStream(ms);
                    panel.BackgroundImageLayout = ImageLayout.Stretch;

                    //display book price
                    foreach (var lblControl in panel.Controls)
                    {
                        if (lblControl.GetType() == typeof(Label))
                        {
                            Label label = (Label)lblControl;
                            label.Text = "$" + bookData.Rows[i][6].ToString();
                        }
                    }
                    i++;
                }
            }
        }

        private void Btn_Circulation_Click(object sender, EventArgs e)
        {
            ManageCirculationForm mcf = new ManageCirculationForm();
            mcf.Show();
        }

        private void Btn_Users_Click(object sender, EventArgs e)
        {
            ManageUsersForm muf = new ManageUsersForm();
            muf.Show();
        }
    }
}
