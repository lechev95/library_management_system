using System.Data;
using System.Data.SqlClient;

namespace library_management_system.THE_DATABASE
{
    internal class MyDb
    {
        private SqlConnection connection
            = new SqlConnection("Server=localhost;Database=LMS");

        //open connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //close connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //return connection
        public SqlConnection getConnection()
        {
            return connection;
        }

        //return a table of data
        public DataTable getData(string query, SqlParameter[] parameter)
        {
            SqlCommand command = new SqlCommand(query, getConnection());

            if (parameter != null)
            {
                foreach (var item in parameter)
                {
                    command.Parameters.Add(item);
                }
            }
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        //set data and execute query
        public int setData(string query, SqlParameter[] parameter)
        {
            SqlCommand command = new SqlCommand(query, getConnection());

            if (parameter != null)
            {

                foreach (var item in parameter)
                {
                    command.Parameters.Add(item);
                }
                //command.Parameters.Add(parameter[0]);
                //if(parameter.Length == 2)
                //{
                //    command.Parameters.Add(parameter[1]);
                //}
                //else if (parameter.Length == 3)
                //{
                //    command.Parameters.Add(parameter[1]);
                //    command.Parameters.Add(parameter[2]);
                //}
                //else if(parameter.Length == 4)
                //{
                //    command.Parameters.Add(parameter[1]);
                //    command.Parameters.Add(parameter[2]);
                //    command.Parameters.Add(parameter[3]);
                //}
                //else if (parameter.Length == 5)
                //{
                //    command.Parameters.Add(parameter[1]);
                //    command.Parameters.Add(parameter[2]);
                //    command.Parameters.Add(parameter[3]);
                //    command.Parameters.Add(parameter[4]);
                //}
                //else if (parameter.Length == 6)
                //{
                //    command.Parameters.Add(parameter[1]);
                //    command.Parameters.Add(parameter[2]);
                //    command.Parameters.Add(parameter[3]);
                //    command.Parameters.Add(parameter[4]);
                //    command.Parameters.Add(parameter[5]);
 
                //}
                //else if (parameter.Length == 7)
                //{
                //    command.Parameters.Add(parameter[1]);
                //    command.Parameters.Add(parameter[2]);
                //    command.Parameters.Add(parameter[3]);
                //    command.Parameters.Add(parameter[4]);
                //    command.Parameters.Add(parameter[5]);
                //    command.Parameters.Add(parameter[6]);
                //}
                //else if (parameter.Length == 8)
                //{
                //    command.Parameters.Add(parameter[1]);
                //    command.Parameters.Add(parameter[2]);
                //    command.Parameters.Add(parameter[3]);
                //    command.Parameters.Add(parameter[4]);
                //    command.Parameters.Add(parameter[5]);
                //    command.Parameters.Add(parameter[6]);
                //    command.Parameters.Add(parameter[7]);
                //}
                //else if (parameter.Length == 9)
                //{
                //    command.Parameters.Add(parameter[1]);
                //    command.Parameters.Add(parameter[2]);
                //    command.Parameters.Add(parameter[3]);
                //    command.Parameters.Add(parameter[4]);
                //    command.Parameters.Add(parameter[5]);
                //    command.Parameters.Add(parameter[6]);
                //    command.Parameters.Add(parameter[7]);
                //    command.Parameters.Add(parameter[8]);
                //}
                //else if (parameter.Length == 10)
                //{
                //    command.Parameters.Add(parameter[1]);
                //    command.Parameters.Add(parameter[2]);
                //    command.Parameters.Add(parameter[3]);
                //    command.Parameters.Add(parameter[4]);
                //    command.Parameters.Add(parameter[5]);
                //    command.Parameters.Add(parameter[6]);
                //    command.Parameters.Add(parameter[7]);
                //    command.Parameters.Add(parameter[8]);
                //    command.Parameters.Add(parameter[9]);
                //}
                //else if (parameter.Length == 11)
                //{
                //    command.Parameters.Add(parameter[1]);
                //    command.Parameters.Add(parameter[2]);
                //    command.Parameters.Add(parameter[3]);
                //    command.Parameters.Add(parameter[4]);
                //    command.Parameters.Add(parameter[5]);
                //    command.Parameters.Add(parameter[6]);
                //    command.Parameters.Add(parameter[7]);
                //    command.Parameters.Add(parameter[8]);
                //    command.Parameters.Add(parameter[9]);
                //    command.Parameters.Add(parameter[10]);
                //}
                //else if (parameter.Length == 12)
                //{
                //    command.Parameters.Add(parameter[1]);
                //    command.Parameters.Add(parameter[2]);
                //    command.Parameters.Add(parameter[3]);
                //    command.Parameters.Add(parameter[4]);
                //    command.Parameters.Add(parameter[5]);
                //    command.Parameters.Add(parameter[6]);
                //    command.Parameters.Add(parameter[7]);
                //    command.Parameters.Add(parameter[8]);
                //    command.Parameters.Add(parameter[9]);
                //    command.Parameters.Add(parameter[10]);
                //    command.Parameters.Add(parameter[11]);
                //}
            }

            openConnection();

            int commandState = command.ExecuteNonQuery();

            closeConnection();
            return commandState;
        }
    }
}
