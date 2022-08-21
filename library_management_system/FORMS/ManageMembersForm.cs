using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system.FORMS
{
    public partial class ManageMembersForm : Form
    {
        public ManageMembersForm()
        {
            InitializeComponent();
        }

        CLASSES.Members member = new CLASSES.Members();

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageMembersForm_Load(object sender, EventArgs e)
        {
            //display button images
            Btn_Close.Image = Image.FromFile("../../IMAGES/close_btn.png");
            Btn_Add.Image = Image.FromFile("../../IMAGES/add.png");
            Btn_Update.Image = Image.FromFile("../../IMAGES/update.png");
            Btn_Delete.Image = Image.FromFile("../../IMAGES/delete.png");
            Btn_UploadPicture.Image = Image.FromFile("../../IMAGES/upload.png");
            Btn_Clear.Image = Image.FromFile("../../IMAGES/clear.png");
            Btn_Refresh.Image = Image.FromFile("../../IMAGES/refresh.png");

            //show the members counter
            Lbl_MembersCount.Text = member.MemberList().Rows.Count.ToString() + " Members";

            //customize the data grid view rows height
            Dgv_Members.RowTemplate.Height = 75;

            //populate data grid view with members
            Dgv_Members.DataSource = member.MemberList();

            //customize the data grid view image column
            DataGridViewImageColumn dgvImgCol = new DataGridViewImageColumn();
            dgvImgCol = (DataGridViewImageColumn)Dgv_Members.Columns[6];
            dgvImgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //customize dgv header
            Dgv_Members.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.MenuText;
            Dgv_Members.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
            Dgv_Members.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Members.EnableHeadersVisualStyles = false;
        }

        private void Btn_UploadPicture_Click(object sender, EventArgs e)
        {
            //browse and display picture
            OpenFileDialog ofd = new OpenFileDialog();
            //image types
            ofd.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //display image in the picturebox
                Pb_Picture.Image = Image.FromFile(ofd.FileName);
            }
        }

        //add new member
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string fName = Txt_FName.Text;
            string lName = Txt_LName.Text;
            string phone = Txt_Phone.Text; ;
            string email = Txt_Email.Text;
            string gender = "Male"; //by default

            if (Rbtn_Female.Checked)
            {
                gender = "Female";
            }

            MemoryStream ms = new MemoryStream();
            Pb_Picture.Image.Save(ms, Pb_Picture.Image.RawFormat);
            byte[] profilePicture = ms.ToArray();

            //check if first or last name is empty
            if (fName.Trim().Equals("") || lName.Trim().Equals("") || phone.Trim().Equals(""))
            {
                MessageBox.Show("You need to enter first & last name & phone", "Empty data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (member.AddMember(fName, lName, gender, phone, email, profilePicture))
                {
                    Txt_ID.Text = "";
                    Txt_FName.Text = "";
                    Txt_LName.Text = "";
                    Txt_Phone.Text = "";
                    Txt_Email.Text = "";
                    Rbtn_Male.Checked = true;
                    Rbtn_Female.Checked = false;
                    Pb_Picture.ImageLocation = "../../IMAGES/default_profile_picture.png";
                    MessageBox.Show("New Member added successfully", "Member added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh dataGridView
                    Dgv_Members.DataSource = member.MemberList();
                    //show the authors counter
                    Lbl_MembersCount.Text = member.MemberList().Rows.Count.ToString() + " Members";
                }
                else
                {
                    MessageBox.Show("Member not added", "Add error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            int id; 
            string fName = Txt_FName.Text;
            string lName = Txt_LName.Text;
            string phone = Txt_Phone.Text; ;
            string email = Txt_Email.Text;
            string gender = "Male"; //by default

            if (Rbtn_Female.Checked)
            {
                gender = "Female";
            }

            MemoryStream ms = new MemoryStream();
            Pb_Picture.Image.Save(ms, Pb_Picture.Image.RawFormat);
            byte[] profilePicture = ms.ToArray();

            if (!Txt_ID.Text.Trim().Equals(""))
            {
                //check if first or last name is empty
                if (fName.Trim().Equals("") || lName.Trim().Equals("") || phone.Trim().Equals(""))
                {
                    MessageBox.Show("You need to enter first & last name & phone", "Empty data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    id = Convert.ToInt32(Txt_ID.Text);
                    if (member.UpdateMember(id, fName, lName, gender, phone, email, profilePicture))
                    {
                        Txt_ID.Text = "";
                        Txt_FName.Text = "";
                        Txt_LName.Text = "";
                        Txt_Phone.Text = "";
                        Txt_Email.Text = "";
                        Rbtn_Male.Checked = true;
                        Rbtn_Female.Checked = false;
                        Pb_Picture.ImageLocation = "../../IMAGES/default_profile_picture.png";
                        MessageBox.Show("Member updated successfully", "Member updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh dataGridView
                        Dgv_Members.DataSource = member.MemberList();
                        //show the authors counter
                        Lbl_MembersCount.Text = member.MemberList().Rows.Count.ToString() + " Members";
                    }
                    else
                    {
                        MessageBox.Show("Member not updated", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select member from the table first", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //display selected member data
        private void Dgv_Members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_ID.Text = Dgv_Members.CurrentRow.Cells[0].Value.ToString();
            Txt_FName.Text = Dgv_Members.CurrentRow.Cells[1].Value.ToString();
            Txt_LName.Text = Dgv_Members.CurrentRow.Cells[2].Value.ToString();
            string gender = Dgv_Members.CurrentRow.Cells[3].Value.ToString();
            if (gender.Equals("Male"))
            {
                Rbtn_Male.Checked = true;
                Rbtn_Female.Checked = false;
            }
            else
            {
                Rbtn_Male.Checked = false;
                Rbtn_Female.Checked = true;
            }
            Txt_Phone.Text = Dgv_Members.CurrentRow.Cells[4].Value.ToString();
            Txt_Email.Text = Dgv_Members.CurrentRow.Cells[5].Value.ToString();

            byte[] pic = (byte[]) Dgv_Members.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(pic);
            Pb_Picture.Image = Image.FromStream(ms);
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Txt_ID.Text);

                //show confirmation message before deleting author
                if (MessageBox.Show("Do you really want to delete this member?", "Confirmation box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (member.DeleteMember(id))
                    {
                        MessageBox.Show("Selected Member deleted successfully", "Member deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Btn_Clear.PerformClick();
                        //refresh dataGridView
                        Dgv_Members.DataSource = member.MemberList();
                        //show the authors counter
                        Lbl_MembersCount.Text = member.MemberList().Rows.Count.ToString() + " Members";
                    }
                    else
                    {
                        MessageBox.Show("Member not deleted", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_ID.Text = "";
            Txt_FName.Text = "";
            Txt_LName.Text = "";
            Txt_Phone.Text = "";
            Txt_Email.Text = "";
            Rbtn_Male.Checked = true;
            Rbtn_Female.Checked = false;
            Pb_Picture.ImageLocation = "../../IMAGES/default_profile_picture.png";
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            //refresh dataGridView
            Dgv_Members.DataSource = member.MemberList();
        }

        //allow only numbers
        private void Txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
