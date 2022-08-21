using System;
using System.Data;
using System.Data.SqlClient;

namespace library_management_system.CLASSES
{
    internal class Author
    {
        THE_DATABASE.MyDb db = new THE_DATABASE.MyDb();

        //add author
        public Boolean AddAuthor(string fName, string lName, string education, string bio)
        {
            string query = "INSERT INTO AUTHORS(FirstName, LastName, Education, Bio) VALUES (@FirstName, @LastName, @Education, @Bio)";

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            parameters[0].Value = fName;

            parameters[1] = new SqlParameter("@LastName", SqlDbType.VarChar);
            parameters[1].Value = lName;

            parameters[2] = new SqlParameter("@Education", SqlDbType.VarChar);
            parameters[2].Value = education;

            parameters[3] = new SqlParameter("@Bio", SqlDbType.VarChar);
            parameters[3].Value = bio;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //update author
        public Boolean UpdateAuthor(int id, string fName, string lName, string education, string bio)
        {
            string query = "UPDATE AUTHORS SET FirstName = @FirstName, LastName = @LastName, Education = @Education, Bio = @Bio WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            parameters[0].Value = fName;

            parameters[1] = new SqlParameter("@LastName", SqlDbType.VarChar);
            parameters[1].Value = lName;

            parameters[2] = new SqlParameter("@Education", SqlDbType.VarChar);
            parameters[2].Value = education;

            parameters[3] = new SqlParameter("@Bio", SqlDbType.VarChar);
            parameters[3].Value = bio;

            parameters[4] = new SqlParameter("@Id", SqlDbType.VarChar);
            parameters[4].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete author
        public Boolean DeleteAuthor(int id)
        {
            string query = "DELETE FROM AUTHORS WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[0].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //return table of authors
        public DataTable GetAuthorsById(int id)
        {
            string query = "SELECT * FROM AUTHORS WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", SqlDbType.VarChar);
            parameters[0].Value = id;
            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
        }

        //create a function to get author by id
        public DataTable AuthorList(Boolean displayFullName)
        {
            string query = "SELECT * FROM AUTHORS";

            if (displayFullName)
            {
                query = "SELECT Id, CONCAT(FirstName, ' ', LastName) AS FullName, Education, Bio FROM Authors";
            }

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }
    }
}
