using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system.FORMS
{
    public partial class ManageCirculationForm : Form
    {
        CLASSES.Books book = new CLASSES.Books();
        CLASSES.Members member = new CLASSES.Members();
        CLASSES.IssueBook issueBook = new CLASSES.IssueBook();
        THE_DATABASE.MyDb db = new THE_DATABASE.MyDb();
        public ManageCirculationForm()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageCirculationForm_Load(object sender, EventArgs e)
        {
            Btn_Close.Image = Image.FromFile("../../IMAGES/close_btn.png");
            Btn_Issue.Image = Image.FromFile("../../IMAGES/take.png");
            Btn_Return.Image = Image.FromFile("../../IMAGES/return.png");

            //show issue panel by default
            panelIssue.BringToFront();

            //customize dgv header
            Dgv_IssuedBooks.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.MenuText;
            Dgv_IssuedBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            Dgv_IssuedBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_IssuedBooks.EnableHeadersVisualStyles = false;
        }

        //show issue panel
        private void Btn_Issue_Click(object sender, EventArgs e)
        {
            panelIssue.BringToFront();
        }

        //search the book by id and display the title
        private void Btn_SearchBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Nud_BookId.Value);
            DataTable table = book.SearchByIdOrIsbn("Id", id, "");
                        
            //check if the book exist
            if(table.Rows.Count > 0)
            {
                Lbl_BookTitle.Text = table.Rows[0][2].ToString();
                Lbl_BookTitle.ForeColor = Color.Black;

                //check the book availability
                if (issueBook.CheckBookAvailability(id))
                {
                    Lbl_YesOrNo.Text = "Yes";
                }
                else
                {
                    Lbl_YesOrNo.Text = "No";
                }

            }
            else
            {
                Lbl_BookTitle.Text = "This book doesn't exist";
                Lbl_BookTitle.ForeColor = Color.Red;
            }
        }

        //search member by id and display full name
        private void Btn_SearchMember_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Nud_MemberId.Value);
            DataRow row = member.GetMemberById(id);

            if(row != null)
            {
                Lbl_MemberFullName.Text = row["FirstName"] + " " + row["LastName"];
                Lbl_MemberFullName.ForeColor = Color.Black;
            }
            else
            {
                Lbl_MemberFullName.Text = "This member doesn't exist";
                Lbl_MemberFullName.ForeColor = Color.Red;
            }
            
        }

        //display book info in form
        private void Lbl_BookTitle_Click(object sender, EventArgs e)
        {
            //get book id
            int bookId = Convert.ToInt32(Nud_BookId.Value);
            BookInfoCard bookCard = new BookInfoCard(bookId);
            bookCard.ShowDialog();
        }

        private void Lbl_BookTitle_MouseEnter(object sender, EventArgs e)
        {
            Lbl_BookTitle.Font = new Font(Lbl_BookTitle.Font.FontFamily, 14, FontStyle.Underline);
        }

        private void Lbl_BookTitle_MouseLeave(object sender, EventArgs e)
        {
            Lbl_BookTitle.Font = new Font(Lbl_BookTitle.Font.FontFamily, 12, FontStyle.Regular);
        }

        private void Lbl_MemberFullName_MouseEnter(object sender, EventArgs e)
        {
            Lbl_MemberFullName.Font = new Font(Lbl_BookTitle.Font.FontFamily, 14, FontStyle.Underline);
        }

        private void Lbl_MemberFullName_MouseLeave(object sender, EventArgs e)
        {
            Lbl_MemberFullName.Font = new Font(Lbl_BookTitle.Font.FontFamily, 12, FontStyle.Regular);
        }

        //display member info in a form
        private void Lbl_MemberFullName_Click(object sender, EventArgs e)
        {
            //get member id
            int memberId = Convert.ToInt32(Nud_MemberId.Value);
            MemberInfoCard memberCard = new MemberInfoCard(memberId);
            memberCard.ShowDialog();
        }

        //issue book
        private void Btn_IssueBook_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(Nud_BookId.Value);
            int memberId = Convert.ToInt32(Nud_MemberId.Value);
            DateTime issueDate = Dtp_Issue.Value;
            DateTime returnDate = Dtp_Return.Value;
            string note = Rtb_Note.Text;

            try
            {
                if (issueBook.IsBookStillIssuedByMember(memberId, bookId))
                {
                    MessageBox.Show("A copy of this book is already issued by this member", "Cannot proceed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //return date shouldn't be before issue date
                    if (issueBook.CheckBookAvailability(bookId))
                    {
                        if (issueDate < returnDate)
                        {
                            if (issueBook.IssueBooks(bookId, memberId, "issued", issueDate, returnDate, note))
                            {
                                MessageBox.Show("Book issued", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Return date shouldn't be before issue date");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book unavailable", "Not available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Empty data: " + ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //show return panel
        private void Btn_Return_Click(object sender, EventArgs e)
        {
            panelReturn.BringToFront();
            Dgv_IssuedBooks.DataSource = issueBook.IssueList("");
        }

        //display selected row data
        private void Dgv_IssuedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Nud_RetBookId.Value = (int)Dgv_IssuedBooks.CurrentRow.Cells[0].Value;
            Nud_RetMemberId.Value = (int)Dgv_IssuedBooks.CurrentRow.Cells[1].Value;
            Dtp_RetIssueDate.Value = (DateTime)Dgv_IssuedBooks.CurrentRow.Cells[3].Value;
            Dtp_RetReturnDate.Value = (DateTime)Dgv_IssuedBooks.CurrentRow.Cells[4].Value;
            Rtb_RetNote.Text = Dgv_IssuedBooks.CurrentRow.Cells[5].Value.ToString();

            //display book title
            int id = Convert.ToInt32(Nud_RetBookId.Value);
            DataRow bookData = book.GetBookInfo(id);
            Lbl_RetBookTitle.Text = bookData["Title"].ToString();

            //display member full name
            int memberId = Convert.ToInt32(Nud_RetMemberId.Value);
            DataRow memberData = member.GetMemberById(memberId);
            Lbl_RetMemberFullName.Text = memberData["FirstName"] + " " + memberData["LastName"];

        }

        //return book
        private void Btn_ReturnBook_Click(object sender, EventArgs e)
        {
            //the user can only edit status (to returne), return date & note
            int bookId = Convert.ToInt32(Nud_RetBookId.Value);
            int memberId = Convert.ToInt32(Nud_RetMemberId.Value);
            DateTime issueDate = Dtp_RetIssueDate.Value;
            DateTime returnDate = Dtp_RetReturnDate.Value;
            string note = Rtb_RetNote.Text;

            if (issueDate < returnDate)
            {
                if (issueBook.ReturnBook(bookId, memberId, "returned", issueDate, returnDate, note))
                {
                    MessageBox.Show("Book returned", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Return date shouldn't be before issue date");
            }
        }

        //book is lost
        private void Btn_BookLost_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(Nud_RetBookId.Value);
            int memberId = Convert.ToInt32(Nud_RetMemberId.Value);
            DateTime issueDate = Dtp_RetIssueDate.Value;
            DateTime returnDate = Dtp_RetReturnDate.Value;
            string note = Rtb_RetNote.Text;

            if (issueBook.ReturnBook(bookId, memberId, "lost", issueDate, issueDate, note))
            {
                MessageBox.Show("Book lost", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (book.BookQuantityMinusOne(bookId))
                {
                    MessageBox.Show("Book quantity updated", "Reduced quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Return date shouldn't be before issue date");
            }
        }

        //delete data
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(Nud_RetBookId.Value);
            int memberId = Convert.ToInt32(Nud_RetMemberId.Value);
            DateTime issueDate = Dtp_RetIssueDate.Value;

            if (issueBook.DeleteData(bookId, memberId, issueDate))
            {
                MessageBox.Show("Data deleted", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //display the issued books
        private void Btn_Issued_Click(object sender, EventArgs e)
        {
            Dgv_IssuedBooks.DataSource = issueBook.IssueList("issued");
        }

        //display the returned books
        private void Btn_Returned_Click(object sender, EventArgs e)
        {
            Dgv_IssuedBooks.DataSource = issueBook.IssueList("returned");
        }

        //display the lost books
        private void Btn_Lost_Click(object sender, EventArgs e)
        {
            Dgv_IssuedBooks.DataSource = issueBook.IssueList("lost");
        }

        private void Btn_All_Click(object sender, EventArgs e)
        {
            Dgv_IssuedBooks.DataSource = issueBook.IssueList("");
        }
    }
}