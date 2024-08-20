using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DBManager
    {
        SqlConnection sqlConnection;
        SqlCommand command;
        SqlDataAdapter sqlDataAdaptor;
        DataTable dt;

        public DBManager()
        {
            try
            {
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindDB"].ConnectionString;

                command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = sqlConnection;

                sqlDataAdaptor = new SqlDataAdapter(command);
                dt = new DataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while initializing the DBManager: " + ex.Message);
                
            }

        }

        public int ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            int result = -1;
            try
            {
                if (sqlConnection?.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                command.CommandText = sql;
                command.Parameters.Clear();

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while executing the command: " + ex.Message);
            }
            finally
            {
                if (sqlConnection?.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            return result;
        }
    
    public Object ExecuteScalar(String sql) {
            object R = new object ();
            try
            {
                if (sqlConnection?.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();

                    command.CommandText = sql;
                    command.Parameters.Clear();

                    R = command.ExecuteScalar();

                    sqlConnection.Close(); 

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred while initializing the DBManager: " + ex.Message);
            }
            return R;
        }
        public DataTable ExecuteDataTable(String sql) {
            dt.Clear();

            try
            {
  
                command.Parameters.Clear();
                command.CommandText = sql;
                
                sqlDataAdaptor.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
                

            }
            return dt;
        }

    }
}
