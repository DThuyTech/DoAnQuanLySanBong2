using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DoAnQuanLySanBong2.DAO
{
    class DataProvider
    {
        private string connectionSTR = "Data Source=.\\SQLexpress;Initial Catalog=QLSB;Integrated Security=True";



        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;


        }
        public int Executenonquery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public string ExecuteoneQuery(string query,string paramater)
        {
            DataTable data = new DataTable();
            string resluts;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                resluts = data.Rows[0][paramater].ToString();
                connection.Close();
            }
           
            return resluts;


        }

        public int Executenoquery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }



    }
}
