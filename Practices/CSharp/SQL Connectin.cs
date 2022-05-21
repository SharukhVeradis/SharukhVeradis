using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;

namespace SQL_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");

            

            //your connection string 
            string connString = "Data Source=10.10.30.20;Initial Catalog=Sharuk;User ID=sa;Password=abc123!@#";

            //create instanace of database connection
            SqlConnection conn = new SqlConnection(connString);


            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                conn.Open();

                Console.WriteLine("Connection successful!");

                //create a new SQL Query using StringBuilder
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append("select * from dbo.PDKT");
                //strBuilder.Append("(N'Harsh', N'harsh@gmail.com', N'Class X'), ");
                //strBuilder.Append("(N'Ronak', N'ronak@gmail.com', N'Class X') ");

                string sqlQuery = strBuilder.ToString();
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("select * from dbo.PDKT", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.WriteLine(reader.GetValue(i));
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

         

      
        }
    }
}
