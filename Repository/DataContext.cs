using Microsoft.Data.SqlClient;
using System.Data;

namespace AnnonsAB.Repository
{
    public class DataContext
    {

        private static string _connString = "Data Source=localhost;Initial Catalog = AnnonsAB; Integrated Security = SSPI; TrustServerCertificate=True;";

        public static DataTable ExecuteQueryReturnTable(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }

                DataTable result = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);

                return result;
            }
        }

        public static void ExecuteNonQuery(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }

                cmd.ExecuteNonQuery();
            }
        }
    }
}
