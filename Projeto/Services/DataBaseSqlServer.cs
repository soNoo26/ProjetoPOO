
using System.Data;
using System.Data.SqlClient;

namespace ProjetoExemploCerto.Services
{
    public class DataBaseSqlServer
    {
        // Cria e abre a conexão com o banco
        private SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString =
                "Data Source=.\\SQLEXPRESS;" +
                "Initial Catalog=ProjetoMVC;" +
                "Integrated Security=SSPI;" +
                "Connect Timeout=5;";

            connection.Open();

            return connection;
        }

        // INSERT, UPDATE e DELETE
        public int ExecuteSQL(SqlCommand command)
        {
            using (SqlConnection connection = GetConnection())
            {
                command.Connection = connection;
                command.CommandTimeout = 10;

                return command.ExecuteNonQuery();
            }
        }

        // Retorna um único valor
        public object ExecuteScalar(SqlCommand command)
        {
            using (SqlConnection connection = GetConnection())
            {
                command.Connection = connection;
                command.CommandTimeout = 10;

                return command.ExecuteScalar();
            }
        }

        // Retorna uma tabela com os resultados
        public DataTable GetDataTable(SqlCommand command)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                command.Connection = connection;
                command.CommandTimeout = 10;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}
