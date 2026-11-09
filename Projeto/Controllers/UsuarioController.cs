
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ProjetoExemploCerto.Models;
using ProjetoExemploCerto.Services;

namespace ProjetoExemploCerto.Controllers
{
    public class UsuarioController
    {
        private DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(Usuario usuario)
        {
            string query = @"INSERT INTO Usuario
                (nome, email, senha, cpf, telefone, cargo)
                VALUES
                (@Nome, @Email, @Senha, @CPF, @Telefone, @Cargo)";

            SqlCommand command = new SqlCommand(query);

            AdicionarParametros(command, usuario);

            return dataBase.ExecuteSQL(command);
        }

        public int Alterar(Usuario usuario)
        {
            string query = @"UPDATE Usuario SET
                nome = @Nome,
                email = @Email,
                senha = @Senha,
                cpf = @CPF,
                telefone = @Telefone,
                cargo = @Cargo
                WHERE usuario_id = @Id";

            SqlCommand command = new SqlCommand(query);

            AdicionarParametros(command, usuario);
            command.Parameters.AddWithValue("@Id", usuario.UsuarioId);

            return dataBase.ExecuteSQL(command);
        }

        public int Excluir(int id)
        {
            string query = "DELETE FROM Usuario WHERE usuario_id = @Id";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Id", id);

            return dataBase.ExecuteSQL(command);
        }

        public List<Usuario> GetAll()
        {
            string query = "SELECT * FROM Usuario ORDER BY nome";

            SqlCommand command = new SqlCommand(query);

            DataTable tabela = dataBase.GetDataTable(command);

            List<Usuario> usuarios = new List<Usuario>();

            foreach (DataRow row in tabela.Rows)
            {
                Usuario usuario = new Usuario();

                usuario.UsuarioId = Convert.ToInt32(row["usuario_id"]);
                usuario.Nome = row["nome"].ToString();
                usuario.Email = row["email"].ToString();
                usuario.Senha = row["senha"].ToString();
                usuario.CPF = row["cpf"].ToString();
                usuario.Telefone = row["telefone"].ToString();
                usuario.Cargo = row["cargo"].ToString();

                usuarios.Add(usuario);
            }

            return usuarios;
        }

        private void AdicionarParametros(
            SqlCommand command, Usuario usuario)
        {
            command.Parameters.AddWithValue("@Nome", usuario.Nome);
            command.Parameters.AddWithValue("@Email", usuario.Email);
            command.Parameters.AddWithValue("@Senha", usuario.Senha);
            command.Parameters.AddWithValue("@CPF", usuario.CPF ?? "");
            command.Parameters.AddWithValue("@Telefone", usuario.Telefone ?? "");
            command.Parameters.AddWithValue("@Cargo", usuario.Cargo ?? "");
        }
    }
}
