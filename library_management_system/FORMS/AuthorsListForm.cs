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
    public partial class AuthorsListForm : Form
    {
        private ManageBooksForm mngBooks = null;

        public AuthorsListForm(ManageBooksForm sourceForm)
        {
            mngBooks = sourceForm as ManageBooksForm;
            InitializeComponent();
        }

        //close the current window
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //display authors on the list box
        private void AuthorsListForm_Load(object sender, EventArgs e)
        {
            //display button images
            Btn_Close.Image = Image.FromFile("../../IMAGES/close_btn.png");

            CLASSES.Author author = new CLASSES.Author();
            Lbx_Authors.DataSource = author.AuthorList(true);
            Lbx_Authors.DisplayMember = "FullName";
            Lbx_Authors.ValueMember = "Id";
        }

        //set selected id into manage books form and close
        private void Btn_SelectAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                //get author full name and id
                DataRowView drv = (DataRowView)Lbx_Authors.SelectedItem;
                string fullName = drv["FullName"].ToString();
                string id = drv["Id"].ToString();

                //display id and full name
                //for add
                mngBooks.Cmb_Author.Text = fullName;
                mngBooks.Lbl_AuthorID.Text = id;

                //for edit
                mngBooks.Cmb_UpdateAuthor.Text = fullName;
                mngBooks.Lbl_UpdateAuthorID.Text = id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No author selected " + ex.Message);
            }
            //close
            this.Close();
        }
    }
}
