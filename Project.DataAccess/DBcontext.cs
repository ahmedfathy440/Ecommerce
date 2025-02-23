using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Project.DataAccess
{
    public class DBContext
    {
        SqlConnection con;

        public DBContext()
        {
            con = new SqlConnection("Server=DESKTOP-JCGFM7O;Database=ADOPROJECT;Trusted_connection=True;TrustServerCertificate=True");
        }

        //select
        public DataTable ExecuteQuery(string commandText)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(commandText, con);
            DataTable result = new DataTable();
            adapter.Fill(result);
            return result;
        }


        //insert ,update , delete
        public int ExecuteNonQuery(string commandText)
        {
            SqlCommand command = new SqlCommand(commandText, con);
            int rowsAffrcted = 0;
            try
            {
                con.Open();
                rowsAffrcted = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return rowsAffrcted;

        }
    }
}
