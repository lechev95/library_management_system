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
    public partial class ManageGenresForm : Form
    {
        public ManageGenresForm()
        {
            InitializeComponent();
        }

        CLASSES.Genres genre = new CLASSES.Genres();

        //close current window
       private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageGenresForm_Load(object sender, EventArgs e)
        {
            //display button images
            Btn_Close.Image = Image.FromFile("../../IMAGES/close_btn.png");
            Btn_Add.Image = Image.FromFile("../../IMAGES/add.png");
            Btn_Update.Image = Image.FromFile("../../IMAGES/update.png");
            Btn_Delete.Image = Image.FromFile("../../IMAGES/delete.png");

            //populate dataGridView with genres
            Dgv_Genres.DataSource = genre.GenreList();

            //customize dgv header
            Dgv_Genres.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.MenuText;
            Dgv_Genres.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            Dgv_Genres.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Genres.EnableHeadersVisualStyles = false;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string name = Txt_Name.Text;

            if (name.Trim().Equals(""))
            {
                MessageBox.Show("Enter Genre name","Empty Genre name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (genre.AddGenre(name))
                {
                    Txt_ID.Text = "";
                    Txt_Name.Text = "";
                    MessageBox.Show("New Genre added successfully", "Genre added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //populate dataGridView with genres
                    Dgv_Genres.DataSource = genre.GenreList();
                }
                else
                {
                    MessageBox.Show("Genre not added", "Add error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Txt_ID.Text);
            string name = Txt_Name.Text;

            if (name.Trim().Equals(""))
            {
                MessageBox.Show("Enter Genre name", "Empty Genre name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (genre.UpdateGenre(id, name))
                    {
                        MessageBox.Show("Genre name updated successfully", "Genre updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //populate dataGridView with genres
                        Txt_ID.Text = "";
                        Txt_Name.Text = "";
                        Dgv_Genres.DataSource = genre.GenreList();
                    }
                    else
                    {
                        MessageBox.Show("Genre name not updated", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Invalid ID");
                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Txt_ID.Text);

                //show confirmation message before deleting author
                if (MessageBox.Show("Do you really want to delete this genre?", "Confirmation box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (genre.DeleteGenre(id))
                    {
                        Txt_ID.Text = "";
                        Txt_Name.Text = "";
                        MessageBox.Show("Genre name deleted successfully", "Genre deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //populate dataGridView with genres
                        Dgv_Genres.DataSource = genre.GenreList();
                    }
                    else
                    {
                        MessageBox.Show("Genre name not deleted", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
            }

        //display selected genre data in textboxes
        private void Dgv_Genres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_ID.Text = Dgv_Genres.CurrentRow.Cells[0].Value.ToString();
            Txt_Name.Text = Dgv_Genres.CurrentRow.Cells[1].Value.ToString();
        }
    }
    }
