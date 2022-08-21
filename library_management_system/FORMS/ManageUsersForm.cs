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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        CLASSES.Users user = new CLASSES.Users();

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            //display button images
            Btn_Close.Image = Image.FromFile("../../IMAGES/close_btn.png");
            Btn_Add.Image = Image.FromFile("../../IMAGES/add.png");
            Btn_Update.Image = Image.FromFile("../../IMAGES/update.png");
            Btn_Delete.Image = Image.FromFile("../../IMAGES/delete.png");

            //populate dataGridView with authors
            Dgv_Users.DataSource = user.UserList();

            //customize dgv header
            Dgv_Users.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.MenuText;
            Dgv_Users.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);
            Dgv_Users.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Users.EnableHeadersVisualStyles = false;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //add user
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string fName = Txt_FName.Text;
            string lName = Txt_LName.Text;
            string username = Txt_Username.Text;
            string password = Txt_Password.Text;
            string userType = "user";
            if (Chck_Admin.Checked)
            {
                userType = "admin";
            }

            if (Verify())
            {
                if (user.IsUserNameExists(username, 00))
                {
                    MessageBox.Show("This Username already exists. Enter a new one.", "Duplicate username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (user.AddUser(fName, lName, username, password, userType))
                    {
                        Txt_FName.Text = "";
                        Txt_LName.Text = "";
                        Txt_Username.Text = "";
                        Txt_Password.Text = "";
                        Txt_RepeatPassword.Text = "";
                        Chck_Admin.Checked = false;

                        MessageBox.Show("New user added successfully", "User added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //refresh dataGridView 
                        Dgv_Users.DataSource = user.UserList();
                    }
                    else
                    {
                        MessageBox.Show("User not added", "Add error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect data entered", "Add error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //update user
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            int id;
            string fName = Txt_FName.Text;
            string lName = Txt_LName.Text;
            string username = Txt_Username.Text;
            string password = Txt_Password.Text;
            string userType = "user";
            if (Chck_Admin.Checked)
            {
                userType = "admin";
            }
            else
            {
                userType = "user";
            }

            if (Verify())
            {
                try
                {
                    id = Convert.ToInt32(Txt_ID.Text);

                    if (user.IsUserNameExists(username, id))
                    {
                        MessageBox.Show("This Username already exists. Enter a new one.", "Duplicate username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (user.UpdateUser(id, fName, lName, username, password, userType))
                        {
                            Txt_FName.Text = "";
                            Txt_LName.Text = "";
                            Txt_Username.Text = "";
                            Txt_Password.Text = "";
                            Txt_RepeatPassword.Text = "";
                            Chck_Admin.Checked = false;

                            MessageBox.Show("User updated successfully", "User updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //refresh dataGridView 
                            Dgv_Users.DataSource = user.UserList();
                        }
                        else
                        {
                            MessageBox.Show("User not updated", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Select user ID from table " + ex.Message, "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect data entered", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete user
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Txt_ID.Text);

                //show confirmation message before deleting author
                if (MessageBox.Show("Do you really want to delete this user?", "Confirmation box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (user.DeleteUser(id))
                    {
                        MessageBox.Show("Selected User deleted successfully", "User deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_FName.Text = "";
                        Txt_LName.Text = "";
                        Txt_Username.Text = "";
                        Txt_Password.Text = "";
                        Txt_RepeatPassword.Text = "";
                        Chck_Admin.Checked = false;
                        //refresh dataGridView
                        Dgv_Users.DataSource = user.UserList();
                    }
                    else
                    {
                        MessageBox.Show("User not deleted", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
        }

        private void Dgv_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_ID.Text = Dgv_Users.CurrentRow.Cells[0].Value.ToString();
            Txt_FName.Text = Dgv_Users.CurrentRow.Cells[1].Value.ToString();
            Txt_LName.Text = Dgv_Users.CurrentRow.Cells[2].Value.ToString();
            Txt_Username.Text = Dgv_Users.CurrentRow.Cells[3].Value.ToString();
            Txt_Password.Text = Dgv_Users.CurrentRow.Cells[4].Value.ToString();
            Txt_RepeatPassword.Text = Dgv_Users.CurrentRow.Cells[4].Value.ToString();
            string userType = Dgv_Users.CurrentRow.Cells[5].Value.ToString();

            if (userType.Equals("admin"))
            {
                Chck_Admin.Checked = true;
            }
            else
            {
                Chck_Admin.Checked = false;
            }
        }

        public Boolean Verify()
        {
            string fName = Txt_FName.Text.Trim();
            string lName = Txt_LName.Text.Trim();
            string username = Txt_Username.Text.Trim();
            string password = Txt_Password.Text.Trim();
            string rePass = Txt_RepeatPassword.Text.Trim();

            if(fName.Equals("") || lName.Equals("") || username.Equals("") || password.Equals(""))
            {
                return false;
            }
            else if(!rePass.Equals(password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
