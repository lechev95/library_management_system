using System;
using System.Data;
using System.Data.SqlClient;

namespace library_management_system.CLASSES
{
    internal class IssueBook
    {
        THE_DATABASE.MyDb db = new THE_DATABASE.MyDb();
        Books book = new Books();

        //add issue
        public Boolean IssueBooks(int bookId, int memberId, string status, DateTime issueDate, DateTime returnDate, string note)
        {
            string query = "INSERT INTO ISSUEBOOK(BookId, MemberId, [Status], IssueDate, ReturnDate, Note) " +
                "VALUES (@BookId, @MemberId, @Status, @IssueDate, @ReturnDate, @Note)";

            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@BookId", SqlDbType.Int);
            parameters[0].Value = bookId;

            parameters[1] = new SqlParameter("@MemberId", SqlDbType.Int);
            parameters[1].Value = memberId;

            parameters[2] = new SqlParameter("@Status", SqlDbType.VarChar);
            parameters[2].Value = status;

            parameters[3] = new SqlParameter("@IssueDate", SqlDbType.Date);
            parameters[3].Value = issueDate;

            parameters[4] = new SqlParameter("@ReturnDate", SqlDbType.Date);
            parameters[4].Value = returnDate;

            parameters[5] = new SqlParameter("@Note", SqlDbType.VarChar);
            parameters[5].Value = note;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //count the issued books
        public int CountIssuedCopiesOfThisBook(int bookId)
        {
            string query = "SELECT * FROM ISSUEBOOK WHERE BookId = @Id AND Status = 'issued'";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[0].Value = bookId;

            return db.getData(query, parameters).Rows.Count;
        }

        public Boolean CheckBookAvailability(int bookId)
        {
            Boolean availability;

            //get book quantity
            int bookQuantity = Convert.ToInt32(book.GetBookInfo(bookId)["Quantity"].ToString());

            //get number of issued copies of the same book
            int issuedCopies = CountIssuedCopiesOfThisBook(bookId);

            if(bookQuantity > issuedCopies)
            {
                availability = true;
            }
            else
            {
                availability = false;
            }

            return availability;
        }

        //return data from issue book table
        public DataTable IssueList(string status)
        {
            string query = "SELECT BookId AS Book, MemberId AS Member, Status, IssueDate AS Issued," +
                " ReturnDate AS Returned, Note FROM ISSUEBOOK";

            if (!status.Equals(""))
            {
                query = "SELECT BookId AS Book, MemberId AS Member, Status, IssueDate AS Issued," +
                    " ReturnDate AS Returned, Note FROM ISSUEBOOK WHERE Status ='"+status+"'";
            }

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        public Boolean ReturnBook(int bookId, int memberId, string status, DateTime issueDate, DateTime returnDate, string note)
        {
            string query = "UPDATE ISSUEBOOK SET Status = @Status, ReturnDate = @ReturnDate, Note = @Note " +
                "WHERE BookId = @BookId AND MemberId = @MemberId AND IssueDate = @IssueDate";

            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@BookId", SqlDbType.Int);
            parameters[0].Value = bookId;

            parameters[1] = new SqlParameter("@MemberId", SqlDbType.Int);
            parameters[1].Value = memberId;

            parameters[2] = new SqlParameter("@Status", SqlDbType.VarChar);
            parameters[2].Value = status;

            parameters[3] = new SqlParameter("@IssueDate", SqlDbType.Date);
            parameters[3].Value = issueDate;

            parameters[4] = new SqlParameter("@ReturnDate", SqlDbType.Date);
            parameters[4].Value = returnDate;

            parameters[5] = new SqlParameter("@Note", SqlDbType.VarChar);
            parameters[5].Value = note;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete selected data
        public Boolean DeleteData(int bookId, int memberId, DateTime issueDate)
        {
            string query = "DELETE FROM ISSUEBOOK WHERE BookId = @BookId AND MemberId = @MemberId AND IssueDate = @IssueDate";

            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@BookId", SqlDbType.Int);
            parameters[0].Value = bookId;

            parameters[1] = new SqlParameter("@MemberId", SqlDbType.Int);
            parameters[1].Value = memberId;

            parameters[2] = new SqlParameter("@IssueDate", SqlDbType.Date);
            parameters[2].Value = issueDate;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check if a book is issued more than once by the same member
        public Boolean IsBookStillIssuedByMember(int memberId, int bookId)
        {
            string query = "SELECT * FROM ISSUEBOOK WHERE Status = 'issued' AND BookId = @BookId AND MemberId = @MemberId";

            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@BookId", SqlDbType.Int);
            parameters[0].Value = bookId;

            parameters[1] = new SqlParameter("@MemberId", SqlDbType.Int);
            parameters[1].Value = memberId;

            DataTable table = db.getData(query, parameters);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
