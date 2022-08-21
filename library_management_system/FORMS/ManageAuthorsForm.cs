using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace library_management_system.FORMS
{
    public partial class ManageAuthorsForm : Form
    {
        CLASSES.Author author = new CLASSES.Author();
        public ManageAuthorsForm()
        {
            InitializeComponent();
        }

        //close current window
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageAuthorsForm_Load(object sender, EventArgs e)
        {
            //display button images
            Btn_Close.Image = Image.FromFile("../../IMAGES/close_btn.png");
            Btn_Add.Image = Image.FromFile("../../IMAGES/add.png");
            Btn_Update.Image = Image.FromFile("../../IMAGES/update.png");
            Btn_Delete.Image = Image.FromFile("../../IMAGES/delete.png");
            Btn_ShowBooks.Image = Image.FromFile("../../IMAGES/literature.png");
            Btn_ExportToTxt.Image = Image.FromFile("../../IMAGES/export.png");


            //populate dataGridView with authors
            Dgv_Authors.DataSource = author.AuthorList(false);

            //customize dgv header
            Dgv_Authors.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.MenuText;
            Dgv_Authors.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);
            Dgv_Authors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Authors.EnableHeadersVisualStyles = false;

            //show the authors counter
            Lbl_AuthorsCount.Text = author.AuthorList(false).Rows.Count.ToString() + " Authors";
        }

        //add new author
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string fName = Txt_FName.Text;
            string lName = Txt_LName.Text;
            string edu = Txt_Edu.Text; ;
            string bio = RTxt_Bio.Text;

            //check if first or last name is empty
            if(fName.Trim().Equals("") || lName.Trim().Equals(""))
            {
                MessageBox.Show("You need to enter first & last name", "Empty data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(author.AddAuthor(fName, lName, edu, bio))
                {
                    Txt_ID.Text = "";
                    Txt_FName.Text = "";
                    Txt_LName.Text = "";
                    Txt_Edu.Text = "";
                    RTxt_Bio.Text = "";
                    MessageBox.Show("New Author added successfully", "Author added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh dataGridView 
                    Dgv_Authors.DataSource = author.AuthorList(false);
                    //show the authors counter
                    Lbl_AuthorsCount.Text = author.AuthorList(false).Rows.Count.ToString() + " Authors";
                }
                else
                {
                    MessageBox.Show("Author not added", "Add error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //update author
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Txt_ID.Text);
                string fName = Txt_FName.Text;
                string lName = Txt_LName.Text;
                string edu = Txt_Edu.Text; ;
                string bio = RTxt_Bio.Text;

                //check if first or last name is empty
                if (fName.Trim().Equals("") || lName.Trim().Equals(""))
                {
                    MessageBox.Show("You need to enter first & last name", "Empty data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (author.UpdateAuthor(id, fName, lName, edu, bio))
                    {
                        Txt_ID.Text = "";
                        Txt_FName.Text = "";
                        Txt_LName.Text = "";
                        Txt_Edu.Text = "";
                        RTxt_Bio.Text = "";
                        MessageBox.Show("New Author updated successfully", "Author updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh dataGridView
                        Dgv_Authors.DataSource = author.AuthorList(false);
                    }
                    else
                    {
                        MessageBox.Show("Author not updated", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
        }

        //delete author
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Txt_ID.Text);

                //show confirmation message before deleting author
                if(MessageBox.Show("Do you really want to delete this author?","Confirmation box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (author.DeleteAuthor(id))
                    {
                        MessageBox.Show("Selected Author deleted successfully", "Author deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_ID.Text = "";
                        Txt_FName.Text = "";
                        Txt_LName.Text = "";
                        Txt_Edu.Text = "";
                        RTxt_Bio.Text = "";
                        //refresh dataGridView
                        Dgv_Authors.DataSource = author.AuthorList(false);
                        //show the authors counter
                        Lbl_AuthorsCount.Text = author.AuthorList(false).Rows.Count.ToString() + " Authors";
                    }
                    else
                    {
                        MessageBox.Show("Author not deleted", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
        }
        private void Dgv_Authors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_ID.Text = Dgv_Authors.CurrentRow.Cells[0].Value.ToString();
            Txt_FName.Text = Dgv_Authors.CurrentRow.Cells[1].Value.ToString();
            Txt_LName.Text = Dgv_Authors.CurrentRow.Cells[2].Value.ToString();
            Txt_Edu.Text = Dgv_Authors.CurrentRow.Cells[3].Value.ToString();
            RTxt_Bio.Text = Dgv_Authors.CurrentRow.Cells[4].Value.ToString(); 
        }

        //show the selected author books
        private void Btn_ShowBooks_Click(object sender, EventArgs e)
        {
            int authorId = Convert.ToInt32(Dgv_Authors.CurrentRow.Cells[0].Value.ToString());
            string fName = Dgv_Authors.CurrentRow.Cells[1].Value.ToString();
            string lName = Dgv_Authors.CurrentRow.Cells[2].Value.ToString();
            string fullName = fName + " " + lName;

            BooksListForm blf = new BooksListForm(authorId, fullName);
            blf.Show();
        }

        //export authors from data grid view to txt file
        private void Btn_ExportToTxt_Click(object sender, EventArgs e)
        {
            string filePath = "../../EXPORT/authors.txt";

            if (!File.Exists(filePath)) //check if this file exists
            {
                File.Create(filePath).Close();//create file
                MessageBox.Show("File created.");
            }

            //populate file with author id and full name
            TextWriter writer = new StreamWriter(filePath);

            string id;
            string fName;
            string lName;
            string fullName;

            for (int rows = 0; rows < Dgv_Authors.Rows.Count; rows++)
            {
                //for (int cols = 0; cols < Dgv_Authors.Columns.Count; cols++)
                //{
                //    writer.Write(Dgv_Authors.Rows[rows].Cells[cols].Value.ToString());
                //}
                id = Dgv_Authors.Rows[rows].Cells[0].Value.ToString();
                fName = Dgv_Authors.Rows[rows].Cells[1].Value.ToString();
                lName = Dgv_Authors.Rows[rows].Cells[2].Value.ToString();
                fullName = fName + " " + lName;
                writer.Write(id + " " + fullName);
                writer.WriteLine();
                writer.WriteLine("----------------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }
    }
}
