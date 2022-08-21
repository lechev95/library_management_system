using System;
using System.Data.SqlClient;
using System.Data;

namespace library_management_system.CLASSES
{
    internal class Books
    {
        THE_DATABASE.MyDb db = new THE_DATABASE.MyDb();

        //add book
        public Boolean AddBook(string isbn, string title, int authorId, int genreId, int quantity,
            decimal price, string publisher, DateTime dateReceived, string description, byte[] cover)
        {
            string query = "INSERT INTO BOOKS(Isbn, Title, AuthorId, Genre_Id, Quantity, Price, Publisher, DateReceived, [Description], Cover) " +
                "VALUES (@Isbn, @Title, @AuthorId, @Genre_Id, @Quantity, @Price, @Publisher, @DateReceived, @Description, @Cover)";

            SqlParameter[] parameters = new SqlParameter[10];
            parameters[0] = new SqlParameter("@Isbn", SqlDbType.VarChar);
            parameters[0].Value = isbn;

            parameters[1] = new SqlParameter("@Title", SqlDbType.VarChar);
            parameters[1].Value = title;

            parameters[2] = new SqlParameter("@AuthorId", SqlDbType.Int);
            parameters[2].Value = authorId;

            parameters[3] = new SqlParameter("@Genre_Id", SqlDbType.Int);
            parameters[3].Value = genreId;

            parameters[4] = new SqlParameter("@Quantity", SqlDbType.Int);
            parameters[4].Value = quantity;

            parameters[5] = new SqlParameter("@Price", SqlDbType.Decimal);
            parameters[5].Value = price;

            parameters[6] = new SqlParameter("@Publisher", SqlDbType.VarChar);
            parameters[6].Value = publisher;

            parameters[7] = new SqlParameter("@DateReceived", SqlDbType.Date);
            parameters[7].Value = dateReceived;

            parameters[8] = new SqlParameter("@Description", SqlDbType.VarChar);
            parameters[8].Value = description;

            parameters[9] = new SqlParameter("@Cover", SqlDbType.VarBinary);
            parameters[9].Value = cover;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //update book
        public Boolean UpdateBook(int id, string isbn, string title, int authorId, int genreId, int quantity,
            decimal price, string publisher, DateTime dateReceived, string description, byte[] cover)
        {
            string query = "UPDATE BOOKS SET Isbn = @Isbn, Title = @Title, AuthorId = @AuthorId, Genre_Id = @Genre_Id, Quantity = @Quantity, Price = @Price, Publisher = @Publisher, DateReceived = @DateReceived, Description = @Description, Cover = @Cover WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[11];
            parameters[0] = new SqlParameter("@Isbn", SqlDbType.VarChar);
            parameters[0].Value = isbn;

            parameters[1] = new SqlParameter("@Title", SqlDbType.VarChar);
            parameters[1].Value = title;

            parameters[2] = new SqlParameter("@AuthorId", SqlDbType.Int);
            parameters[2].Value = authorId;

            parameters[3] = new SqlParameter("@Genre_Id", SqlDbType.Int);
            parameters[3].Value = genreId;

            parameters[4] = new SqlParameter("@Quantity", SqlDbType.Int);
            parameters[4].Value = quantity;

            parameters[5] = new SqlParameter("@Price", SqlDbType.Decimal);
            parameters[5].Value = price;

            parameters[6] = new SqlParameter("@Publisher", SqlDbType.VarChar);
            parameters[6].Value = publisher;

            parameters[7] = new SqlParameter("@DateReceived", SqlDbType.Date);
            parameters[7].Value = dateReceived;

            parameters[8] = new SqlParameter("@Description", SqlDbType.VarChar);
            parameters[8].Value = description;

            parameters[9] = new SqlParameter("@Cover", SqlDbType.VarBinary);
            parameters[9].Value = cover;

            parameters[10] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[10].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete book
        public Boolean DeleteBook(int id)
        {
            string query = "DELETE FROM BOOKS WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[0].Value = id;

            if(db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //edit book quantity
        public Boolean BookQuantityMinusOne(int bookId)
        {
            string query = "UPDATE BOOKS SET Quantity = Quantity - 1 WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[0].Value = bookId;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //return table of books
        public DataTable BookList()
        {
            string query = "SELECT * FROM BOOKS ORDER BY Id DESC";

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        //return table of books by author
        public DataTable AuthorsBooks(int authorId)
        {
            string query = "SELECT * FROM BOOKS WHERE AuthorId = @AuthorId";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@AuthorId", SqlDbType.Int);
            parameters[0].Value = authorId;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
        }

        //check if book isbn already exists
        public Boolean IsIsbnExists(string isbn, int id)
        {
            string query = "SELECT * FROM BOOKS WHERE Isbn = @Isbn AND Id <> @Id";

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Isbn", SqlDbType.VarChar);
            parameters[0].Value = isbn;

            parameters[1] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[1].Value = id;

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

        //check if book title already exists
        public Boolean IsTitleExists(string title, int id)
        {
            string query = "SELECT * FROM BOOKS WHERE Title = @Title AND Id <> @Id";

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Title", SqlDbType.VarChar);
            parameters[0].Value = title;

            parameters[1] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[1].Value = id;

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

        //search book by id or isbn
        public DataTable SearchByIdOrIsbn(string idOrIsbn, int id, string isbn)
        {
            string query;
            SqlParameter[] parameters = new SqlParameter[1];

            if (idOrIsbn.Equals("Id"))
            {
                query = "SELECT * FROM BOOKS WHERE Id = @Id";
                parameters[0] = new SqlParameter("@Id", SqlDbType.VarChar);
                parameters[0].Value = id;
            }
            else
            {
                query = "SELECT * FROM BOOKS WHERE Isbn = @Isbn";
                parameters[0] = new SqlParameter("@Isbn", SqlDbType.VarChar);
                parameters[0].Value = isbn;
            }

            DataTable table = db.getData(query, parameters);

            return table;
        }

        //return book info with author full name and genre
        public DataRow GetBookInfo(int bookId)
        {
            string query = "SELECT b.Id, Isbn, Title, CONCAT(a.FirstName, ' ', a.LastName) AS Author, " +
                "g.GenreName as Genre, Quantity, Price, Publisher, DateReceived, Description, Cover FROM BOOKS b, " +
                "AUTHORS a, GENRES g WHERE b.AuthorId = a.Id AND b.Genre_Id = g.Id AND b.Id = @Id";
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@Id", SqlDbType.VarChar);
            parameters[0].Value = bookId;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);

            return table.Rows[0];
        }
    }
}
