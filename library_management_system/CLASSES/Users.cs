using System;
using System.Data;
using System.Data.SqlClient;

namespace library_management_system.CLASSES
{
    internal class Users
    {
        THE_DATABASE.MyDb db = new THE_DATABASE.MyDb();

        //add author
        public Boolean AddUser(string fName, string lName, string username, string password, string userType)
        {
            string query = "INSERT INTO APP_USERS(FirstName, LastName, UserName, Password, UserType) " +
                "VALUES (@FirstName, @LastName, @UserName, @Password, @UserType)";

            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            parameters[0].Value = fName;

            parameters[1] = new SqlParameter("@LastName", SqlDbType.VarChar);
            parameters[1].Value = lName;

            parameters[2] = new SqlParameter("@UserName", SqlDbType.VarChar);
            parameters[2].Value = username;

            parameters[3] = new SqlParameter("@Password", SqlDbType.VarChar);
            parameters[3].Value = password;

            parameters[4] = new SqlParameter("@UserType", SqlDbType.VarChar);
            parameters[4].Value = userType;

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
        public Boolean UpdateUser(int id, string fName, string lName, string username, string password, string userType)
        {
            string query = "UPDATE APP_USERS SET FirstName = @FirstName, LastName = @LastName, UserName = @UserName, " +
                "Password = @Password, UserType = @UserType WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            parameters[0].Value = fName;

            parameters[1] = new SqlParameter("@LastName", SqlDbType.VarChar);
            parameters[1].Value = lName;

            parameters[2] = new SqlParameter("@UserName", SqlDbType.VarChar);
            parameters[2].Value = username;

            parameters[3] = new SqlParameter("@Password", SqlDbType.VarChar);
            parameters[3].Value = password;

            parameters[4] = new SqlParameter("@UserType", SqlDbType.VarChar);
            parameters[4].Value = userType;

            parameters[5] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[5].Value = id;

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
        public Boolean DeleteUser(int id)
        {
            string query = "DELETE FROM APP_USERS WHERE Id = @Id";

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

        //create a function to get author by id
        public DataTable UserList()
        {
            string query = "SELECT * FROM APP_USERS WHERE UserType <> 'owner'";

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        //check if user exists
        public Boolean IsUserNameExists(string username, int id)
        {
            string query = "SELECT * FROM APP_USERS WHERE UserName = @UserName AND Id <> @Id";

            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            parameters[0].Value = username;

            parameters[1] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[1].Value = id;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);

            if(table.Rows.Count > 0)
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
