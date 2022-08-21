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
    public partial class MemberInfoCard : Form
    {
        int memberId;
        public MemberInfoCard(int id)
        {
            InitializeComponent();
            memberId = id;
        }

        CLASSES.Members member = new CLASSES.Members();

        private void MemberInfoCard_Load(object sender, EventArgs e)
        {
            //display button images
            Btn_Close.Image = Image.FromFile("../../IMAGES/close_btn.png");

            try
            {
                DataRow data = member.GetMemberById(memberId);

                if(data != null)
                {
                    Lbl_ID.Text = data["Id"].ToString();

                    Lbl_FullName.Text = data["FirstName"].ToString() + " " + data["LastName"].ToString();
                    Lbl_Gender.Text = data["Gender"].ToString();
                    Lbl_Phone.Text = data["Phone"].ToString();
                    Lbl_Email.Text = data["Email"].ToString();

                    //display member picture
                    byte[] picture = (byte[])data["Picture"];
                    MemoryStream ms = new MemoryStream(picture);
                    Pb_ProfilePicture.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Empty card: " + ex.Message);
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
