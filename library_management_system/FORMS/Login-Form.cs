using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace library_management_system.FORMS
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            Pb_User.Image = Image.FromFile("../../IMAGES/user.png");
            Pb_Pass.Image = Image.FromFile("../../IMAGES/pass.png");
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lbl_Exit_MouseEnter(object sender, EventArgs e)
        {
            Lbl_Exit.ForeColor = Color.Red;
        }

        private void Lbl_Exit_MouseLeave(object sender, EventArgs e)
        {
            Lbl_Exit.ForeColor = Color.Black;
        }

        private void Lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // manipulate the dashboard from the login
        private Dashboard_Form dashF = null;
        public Login_Form(Dashboard_Form SourceForm)
        {
            dashF = SourceForm as Dashboard_Form;
            InitializeComponent();
        }

        // after login close the login form
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            THE_DATABASE.MyDb db = new THE_DATABASE.MyDb();

            string username = Txt_UserName.Text;
            string password = Txt_Pass.Text;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command 
                = new SqlCommand("SELECT * FROM APP_USERS " +
                "WHERE UserName=@usn AND Password=@pass", db.getConnection());

            command.Parameters.Add("@usn", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check if user exists
            if(table.Rows.Count > 0)
            {
                //check user type
                if (table.Rows[0][5].ToString().Equals("owner"))
                {
                    dashF.Enabled = true;
                    this.Close();
                }
                else if (table.Rows[0][5].ToString().Equals("admin"))
                {
                    dashF.Enabled = true;
                    dashF.Btn_Users.Enabled = false;
                    this.Close();
                }
                else if (table.Rows[0][5].ToString().Equals("user"))
                {
                    dashF.Enabled = true;
                    dashF.Btn_Users.Enabled = false;
                    dashF.Btn_Circulation.Enabled = false;
                    this.Close();
                }
            }
            else
            {
                if (username.Trim().Length.Equals(""))
                {
                    MessageBox.Show("Enter your Username to Login",
                        "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Length.Equals(""))
                {
                    MessageBox.Show("Enter your Password to Login",
                        "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password",
                        "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
