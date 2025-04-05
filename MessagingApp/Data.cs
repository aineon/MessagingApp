using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MessagingApp
{
    public class Data
    {
        static string connectionString = ConfigurationManager.AppSettings["connectionString"];

        // Retrieve a list of rows from the DB
        // 'T' references the Type eg SMS or MMS
        public static List<T> GetData<T>(string SQL, CommandType cmdType)
        {
            // Creates new SqlConnection object to provide connection to the database
            // By using using() it automatically closes the connection when the code block has finished running 
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                // holds the values for each column and row in the Messages table
                var objProps = Activator.CreateInstance<T>().GetType().GetProperties();
                var returnList = new List<T>();

                // Creates new SqlCommand object
                using (SqlCommand cmd = new SqlCommand(SQL, cnn))
                {
                    cmd.CommandType = cmdType;

                    // Kills the command if there is no response in 30secs and throws an exception
                    cmd.CommandTimeout = 30000;

                    try
                    {
                        // open the connection
                        cnn.Open();

                        // Create new object to read the data from the database
                        SqlDataReader reader = cmd.ExecuteReader();    // retrieves multiple records;

                        // Select everything in each column/row, convert to string and put each row in a list   
                        var columns = reader.GetSchemaTable().Rows.Cast<DataRow>().Select(row => row["ColumnName"].ToString().ToLower()).ToList();

                        while (reader.Read())
                        {
                            // Creates instance of the current row
                            var thisRow = Activator.CreateInstance<T>();

                            foreach (var prop in objProps)
                            {
                                // If the column we are reading the data from contains the same column name as name of the object being created - 'T' is SMS or MMS
                                // mapping the data to the member name if that type 
                                if (columns.Contains(prop.Name.ToLower()))
                                {
                                    // if the value we get back from the database is null we nned to convert it to a C# null so we can handle the null value
                                    if (reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        prop.SetValue(thisRow, null, null);  // for null from the DB
                                    }
                                    else
                                    {
                                        prop.SetValue(thisRow, reader[prop.Name], null); //for null from empty string etc.
                                    }
                                }
                            }
                            // Adds the row to the list
                            returnList.Add(thisRow);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        // if the conenction does not close automaticaly - close it
                        if (cnn.State != ConnectionState.Closed)
                        {
                            cnn.Close();
                        }
                    }
                }
                return returnList;
            }
        }
        // ExecuteNonQuery()  - can be used for inserts, updates and deletes on the DB
        public static int ExecuteSqlNonQuery(string sql, CommandType cmdType)
        {
            int num = 0;
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = cmdType;
                        // if there is no response in 30secs, timesout and throws an exception
                        cmd.CommandTimeout = 30000;

                        cnn.Open();
                        num = cmd.ExecuteNonQuery();
                    }
                }
                return num;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return num;
            }
        }

        // Retrieves a single value. returns the value in the first column of the first row from the resultset
        public static string ExecuteSqlScaler(string sql, CommandType cmdType)
        {
            string result = "";

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = cmdType;
                        cmd.CommandTimeout = 30000;

                        cnn.Open();

                        var sqlResult = cmd.ExecuteScalar(); // returns only 1 value - the value in the first column of the first row 

                        result = sqlResult.ToString();
                    }
                }
                return result;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return result;
            }
        }
    }
}
