
using ProjetoExemploCerto.Models;
using ProjetoExemploCerto.Services;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoExemploCerto.Controllers
{
    public class VeiculoController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(Veiculo veiculo)
        {
            string query =
                "INSERT INTO Veiculo " +
                "(cliente_id, placa, marca, modelo, ano, cor, motor, combustivel) " +
                "VALUES " +
                "(@ClienteId, @Placa, @Marca, @Modelo, @Ano, @Cor, @Motor, @Combustivel)";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@ClienteId", veiculo.IdCliente);
            command.Parameters.AddWithValue("@Placa", veiculo.Placa);
            command.Parameters.AddWithValue("@Marca", veiculo.Marca);
            command.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
            command.Parameters.AddWithValue("@Ano", veiculo.Ano);
            command.Parameters.AddWithValue("@Cor", string.IsNullOrWhiteSpace(veiculo.Cor) ? (object)System.DBNull.Value : veiculo.Cor);
            command.Parameters.AddWithValue("@Motor", (object)veiculo.Motor ?? System.DBNull.Value);
            command.Parameters.AddWithValue("@Combustivel", (object)veiculo.Combustivel ?? System.DBNull.Value);

            return dataBase.ExecuteSQL(command);
        }

        public int Alterar(Veiculo veiculo)
        {
            string query =
                "UPDATE Veiculo SET " +
                "cliente_id = @ClienteId, placa = @Placa, marca = @Marca, " +
                "modelo = @Modelo, ano = @Ano, cor = @Cor, " +
                "motor = @Motor, combustivel = @Combustivel " +
                "WHERE veiculo_id = @VeiculoId";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@ClienteId", veiculo.IdCliente);
            command.Parameters.AddWithValue("@Placa", veiculo.Placa);
            command.Parameters.AddWithValue("@Marca", veiculo.Marca);
            command.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
            command.Parameters.AddWithValue("@Ano", veiculo.Ano);
            command.Parameters.AddWithValue("@Cor", string.IsNullOrWhiteSpace(veiculo.Cor) ? (object)System.DBNull.Value : veiculo.Cor);
            command.Parameters.AddWithValue("@Motor", (object)veiculo.Motor ?? System.DBNull.Value);
            command.Parameters.AddWithValue("@Combustivel", (object)veiculo.Combustivel ?? System.DBNull.Value);
            command.Parameters.AddWithValue("@VeiculoId", veiculo.IdVeiculo);

            return dataBase.ExecuteSQL(command);
        }

        public int Excluir(int veiculoId)
        {
            string query = "DELETE FROM Veiculo WHERE veiculo_id = @Id";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Id", veiculoId);

            return dataBase.ExecuteSQL(command);
        }

        public List<Veiculo> GetAll()
        {
            string query =
                "SELECT V.*, C.nome AS cliente_nome " +
                "FROM Veiculo V " +
                "INNER JOIN Cliente C ON V.cliente_id = C.cliente_id " +
                "ORDER BY V.modelo";

            SqlCommand command = new SqlCommand(query);
            DataTable tabela = dataBase.GetDataTable(command);

            return ConverterTabela(tabela);
        }

        public List<Veiculo> GetByFilter(string filtro)
        {
            string query =
                "SELECT V.*, C.nome AS cliente_nome " +
                "FROM Veiculo V " +
                "INNER JOIN Cliente C ON V.cliente_id = C.cliente_id " +
                "WHERE V.placa LIKE @Filtro " +
                "OR V.modelo LIKE @Filtro " +
                "OR V.marca LIKE @Filtro " +
                "OR C.nome LIKE @Filtro " +
                "ORDER BY V.modelo";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

            DataTable tabela = dataBase.GetDataTable(command);

            return ConverterTabela(tabela);
        }

        private List<Veiculo> ConverterTabela(DataTable tabela)
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            foreach (DataRow row in tabela.Rows)
            {
                Veiculo veiculo = new Veiculo();

                veiculo.IdVeiculo = (int)row["veiculo_id"];
                veiculo.IdCliente = (int)row["cliente_id"];
                veiculo.ClienteNome = row["cliente_nome"].ToString();
                veiculo.Placa = row["placa"].ToString();
                veiculo.Marca = row["marca"].ToString();
                veiculo.Modelo = row["modelo"].ToString();
                veiculo.Ano = (int)row["ano"];
                veiculo.Cor = row["cor"].ToString();
                veiculo.Motor = row["motor"].ToString();
                veiculo.Combustivel = row["combustivel"].ToString();

                veiculos.Add(veiculo);
            }

            return veiculos;
        }

        public List<Veiculo> GetByClienteId(int clienteId)
        {
            string query =
                "SELECT V.*, C.nome AS cliente_nome " +
                "FROM Veiculo V " +
                "INNER JOIN Cliente C ON V.cliente_id = C.cliente_id " +
                "WHERE V.cliente_id = @ClienteId " +
                "ORDER BY V.modelo";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@ClienteId", clienteId);

            DataTable tabela = dataBase.GetDataTable(command);

            return ConverterTabela(tabela);
        }
    }
}
