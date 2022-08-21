using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system.CLASSES
{
    internal class Members
    {
        THE_DATABASE.MyDb db = new THE_DATABASE.MyDb();

        //add member
        public Boolean AddMember(string fName, string lName, string gender, string phone, string email, byte[] picture)
        {
            string query = "INSERT INTO MEMBERS(FirstName, LastName, Gender, Phone, Email, Picture) VALUES (@FirstName, @LastName, @Gender, @Phone, @Email, @Picture)";

            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            parameters[0].Value = fName;

            parameters[1] = new SqlParameter("@LastName", SqlDbType.VarChar);
            parameters[1].Value = lName;

            parameters[2] = new SqlParameter("@Gender", SqlDbType.VarChar);
            parameters[2].Value = gender;

            parameters[3] = new SqlParameter("@Phone", SqlDbType.VarChar);
            parameters[3].Value = phone;

            parameters[4] = new SqlParameter("@Email", SqlDbType.VarChar);
            parameters[4].Value = email;

            parameters[5] = new SqlParameter("@Picture", SqlDbType.VarBinary);
            parameters[5].Value = picture;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //update member
        public Boolean UpdateMember(int id, string fName, string lName, string gender, string phone, string email, byte[] picture)
        {
            string query = "UPDATE MEMBERS SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, Phone = @Phone, Email = @Email, Picture = @Picture WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[0].Value = id;

            parameters[1] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            parameters[1].Value = fName;

            parameters[2] = new SqlParameter("@LastName", SqlDbType.VarChar);
            parameters[2].Value = lName;

            parameters[3] = new SqlParameter("@Gender", SqlDbType.VarChar);
            parameters[3].Value = gender;

            parameters[4] = new SqlParameter("@Phone", SqlDbType.VarChar);
            parameters[4].Value = phone;

            parameters[5] = new SqlParameter("@Email", SqlDbType.VarChar);
            parameters[5].Value = email;

            parameters[6] = new SqlParameter("@Picture", SqlDbType.VarBinary);
            parameters[6].Value = picture;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete member
        public Boolean DeleteMember(int id)
        {
            string query = "DELETE FROM MEMBERS WHERE Id = @Id";

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


        //create a function to return table of members
        public DataTable MemberList()
        {
            string query = "SELECT * FROM MEMBERS";

            //{
            //    query = "SELECT Id, CONCAT(FirstName, ' ', LastName) AS FullName, Gender, Phone, Email, Picture FROM MEMBERS";
            //}

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        public DataRow GetMemberById(int memberId)
        {
            string query = "SELECT * FROM MEMBERS WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[0].Value = memberId;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);

            DataRow dr = null;
            if(table.Rows.Count > 0)
            {
                dr = table.Rows[0];
            }
            return dr;
        }
    }
}
