using System;
using System.Data;
using System.Data.SqlClient;

namespace library_management_system.CLASSES
{
    internal class Genres
    {
        THE_DATABASE.MyDb db = new THE_DATABASE.MyDb();

        //add genre
        public Boolean AddGenre(string name)
        {
            string query = "INSERT INTO GENRES(GenreName) VALUES (@GenreName)";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@GenreName", SqlDbType.VarChar);
            parameters[0].Value = name;

            if(db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //update genre
        public Boolean UpdateGenre(int id, string name)
        {
            string query = "UPDATE GENRES SET GenreName = @GenreName WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[1] = new SqlParameter("@GenreName", SqlDbType.VarChar);
            parameters[1].Value = name;

            parameters[0] = new SqlParameter("@Id", SqlDbType.VarChar);
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

        //delete genre
        public Boolean DeleteGenre(int id)
        {
            string query = "DELETE FROM GENRES WHERE Id = @Id";

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

        //return table of genres
        public DataTable GenreList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM Genres", null);
            return table;
        }
    }
}
