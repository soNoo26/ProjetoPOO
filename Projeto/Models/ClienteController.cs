
using ProjetoExemploCerto.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoExemploCerto.Models
{
    public class ClienteController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(Cliente cliente)
        {
            string query = "INSERT INTO Cliente " +
                "(nome, cpf, qt_veiculos, email, telefone, cep, endereco, cidade) " +
                "VALUES (@Nome, @CPF, @QtVeiculos, @Email, @Telefone, @CEP, @Endereco, @Cidade)";

            SqlCommand command = new SqlCommand(query);

            AdicionarParametros(command, cliente);

            return dataBase.ExecuteSQL(command);
        }

        public int Alterar(Cliente cliente)
        {
            string query = "UPDATE Cliente SET " +
                "nome = @Nome, cpf = @CPF, qt_veiculos = @QtVeiculos, " +
                "email = @Email, telefone = @Telefone, cep = @CEP, " +
                "endereco = @Endereco, cidade = @Cidade " +
                "WHERE cliente_id = @ClienteId";

            SqlCommand command = new SqlCommand(query);

            AdicionarParametros(command, cliente);
            command.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);

            return dataBase.ExecuteSQL(command);
        }

        public int Excluir(int clienteId)
        {
            string query = "DELETE FROM Cliente WHERE cliente_id = @ClienteId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@ClienteId", clienteId);

            return dataBase.ExecuteSQL(command);
        }

        public Cliente GetbyID(int clienteId)
        {
            string query = "SELECT * FROM Cliente WHERE cliente_id = @ClienteId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@ClienteId", clienteId);

            DataTable tabela = dataBase.GetDataTable(command);

            if (tabela.Rows.Count == 0)
                return null;

            return ConverterCliente(tabela.Rows[0]);
        }

        public List<Cliente> GetAll()
        {
            string query = "SELECT * FROM Cliente";

            SqlCommand command = new SqlCommand(query);

            DataTable tabela = dataBase.GetDataTable(command);

            List<Cliente> clientes = new List<Cliente>();

            foreach (DataRow row in tabela.Rows)
            {
                clientes.Add(ConverterCliente(row));
            }

            return clientes;
        }

        public List<Cliente> GetByName(string nome)
        {
            string query = "SELECT * FROM Cliente WHERE nome LIKE @Nome";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", "%" + nome + "%");

            DataTable tabela = dataBase.GetDataTable(command);

            List<Cliente> clientes = new List<Cliente>();

            foreach (DataRow row in tabela.Rows)
            {
                clientes.Add(ConverterCliente(row));
            }

            return clientes;
        }

        private void AdicionarParametros(SqlCommand command, Cliente cliente)
        {
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CadastroNacional);
            command.Parameters.AddWithValue("@QtVeiculos", cliente.QtVeiculos);
            command.Parameters.AddWithValue("@Email",
                string.IsNullOrWhiteSpace(cliente.Email) ? (object)DBNull.Value : cliente.Email);
            command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            command.Parameters.AddWithValue("@CEP", cliente.CEP);
            command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            command.Parameters.AddWithValue("@Cidade", cliente.Cidade);
        }

        private Cliente ConverterCliente(DataRow row)
        {
            return new Cliente
            {
                ClienteId = Convert.ToInt32(row["cliente_id"]),
                Nome = row["nome"].ToString(),
                CadastroNacional = row["cpf"].ToString(),
                QtVeiculos = Convert.ToInt32(row["qt_veiculos"]),
                Email = row["email"] == DBNull.Value ? "" : row["email"].ToString(),
                Telefone = row["telefone"].ToString(),
                CEP = Convert.ToInt32(row["cep"]),
                Endereco = row["endereco"].ToString(),
                Cidade = row["cidade"].ToString()
            };
        }
    }
}
