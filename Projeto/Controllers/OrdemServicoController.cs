using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ProjetoExemploCerto.Models;
using ProjetoExemploCerto.Services;

namespace ProjetoExemploCerto.Controllers
{
    public class OrdemServicoController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(OrdemServiço os)
        {
            string query =
                "INSERT INTO OrdemServico " +
                "(cliente_id, veiculo_id, data_abertura, data_previsao, " +
                "status, descricao_problema, diagnostico, observacoes, " +
                "valor_mao_obra, valor_total) " +
                "VALUES " +
                "(@ClienteId, @VeiculoId, @DataAbertura, @DataPrevisao, " +
                "@Status, @Problema, @Diagnostico, @Observacoes, " +
                "@MaoDeObra, @ValorTotal); " +
                "SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@ClienteId", os.ClienteId);
            command.Parameters.AddWithValue("@VeiculoId", os.VeiculoId);
            command.Parameters.AddWithValue("@DataAbertura",
                Convert.ToDateTime(os.DataAbertura));

            command.Parameters.AddWithValue("@DataPrevisao",
                string.IsNullOrWhiteSpace(os.DataPrevisao)
                ? (object)DBNull.Value
                : Convert.ToDateTime(os.DataPrevisao));

            command.Parameters.AddWithValue("@Status", os.Status);
            command.Parameters.AddWithValue("@Problema", os.DescricaoProblema ?? "");
            command.Parameters.AddWithValue("@Diagnostico", os.Diagnostico ?? "");
            command.Parameters.AddWithValue("@Observacoes", os.Observacoes ?? "");
            command.Parameters.AddWithValue("@MaoDeObra", os.ValorMaoDeObra);
            command.Parameters.AddWithValue("@ValorTotal", os.ValorTotal);

            object resultado = dataBase.ExecuteScalar(command);

            int osId = Convert.ToInt32(resultado);

            if (osId > 0)
            {
                RegistrarHistorico(
                    osId,
                    "Cadastro",
                    os.Status
                );
            }

            return osId;
        }
        public int Alterar(OrdemServiço os)
        {

            OrdemServiço osAnterior = GetById(Convert.ToInt32(os.OrdemServicoId));

            if (osAnterior == null)
                return 0;

            string query =
                "UPDATE OrdemServico SET " +
                "cliente_id = @ClienteId, " +
                "veiculo_id = @VeiculoId, " +
                "data_previsao = @DataPrevisao, " +
                "data_fechamento = @DataFechamento, " +
                "status = @Status, " +
                "descricao_problema = @Problema, " +
                "diagnostico = @Diagnostico, " +
                "observacoes = @Observacoes, " +
                "valor_mao_obra = @MaoDeObra, " +
                "valor_total = @ValorTotal " +
                "WHERE ordem_servico_id = @Id";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@ClienteId", os.ClienteId);
            command.Parameters.AddWithValue("@VeiculoId", os.VeiculoId);

            command.Parameters.AddWithValue("@DataPrevisao",
                string.IsNullOrWhiteSpace(os.DataPrevisao)
                ? (object)DBNull.Value
                : Convert.ToDateTime(os.DataPrevisao));

            command.Parameters.AddWithValue("@DataFechamento",
                string.IsNullOrWhiteSpace(os.DataFechamento)
                ? (object)DBNull.Value
                : Convert.ToDateTime(os.DataFechamento));

            command.Parameters.AddWithValue("@Status", os.Status);
            command.Parameters.AddWithValue("@Problema", os.DescricaoProblema ?? "");
            command.Parameters.AddWithValue("@Diagnostico", os.Diagnostico ?? "");
            command.Parameters.AddWithValue("@Observacoes", os.Observacoes ?? "");
            command.Parameters.AddWithValue("@MaoDeObra", os.ValorMaoDeObra);
            command.Parameters.AddWithValue("@ValorTotal", os.ValorTotal);
            command.Parameters.AddWithValue("@Id", Convert.ToInt32(os.OrdemServicoId));

            int resultado = dataBase.ExecuteSQL(command);

            if (resultado > 0 &&
                osAnterior.Status != os.Status)
            {
                RegistrarHistorico(
                    Convert.ToInt32(os.OrdemServicoId),
                    osAnterior.Status,
                    os.Status
                );
            }

            return resultado;
        }

        public int Excluir(int osId)
        {
            SqlCommand commandItens = new SqlCommand(
                "DELETE FROM OrdemServicoItem WHERE ordem_servico_id = @Id");

            commandItens.Parameters.AddWithValue("@Id", osId);
            dataBase.ExecuteSQL(commandItens);

            SqlCommand commandOS = new SqlCommand(
                "DELETE FROM OrdemServico WHERE ordem_servico_id = @Id");

            commandOS.Parameters.AddWithValue("@Id", osId);

            return dataBase.ExecuteSQL(commandOS);
        }

        public List<OrdemServiço> GetAll()
        {
            string query =
                "SELECT OS.*, C.nome AS cliente_nome, " +
                "(V.marca + ' ' + V.modelo + ' - ' + V.placa) AS veiculo_descricao " +
                "FROM OrdemServico OS " +
                "INNER JOIN Cliente C ON OS.cliente_id = C.cliente_id " +
                "INNER JOIN Veiculo V ON OS.veiculo_id = V.veiculo_id " +
                "ORDER BY OS.ordem_servico_id DESC";

            SqlCommand command = new SqlCommand(query);

            DataTable tabela = dataBase.GetDataTable(command);

            return ConverterTabela(tabela);
        }
        public OrdemServiço GetById(int osId)
        {
            string query =
                "SELECT OS.*, C.nome AS cliente_nome, " +
                "(V.marca + ' ' + V.modelo + ' - ' + V.placa) AS veiculo_descricao " +
                "FROM OrdemServico OS " +
                "INNER JOIN Cliente C ON OS.cliente_id = C.cliente_id " +
                "INNER JOIN Veiculo V ON OS.veiculo_id = V.veiculo_id " +
                "WHERE OS.ordem_servico_id = @Id";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Id", osId);

            DataTable tabela = dataBase.GetDataTable(command);

            List<OrdemServiço> lista = ConverterTabela(tabela);

            if (lista.Count == 0)
                return null;

            return lista[0];
        }

        private List<OrdemServiço> ConverterTabela(DataTable tabela)
        {
            List<OrdemServiço> lista = new List<OrdemServiço>();

            foreach (DataRow row in tabela.Rows)
            {
                OrdemServiço os = new OrdemServiço();

                os.OrdemServicoId = Convert.ToInt32(row["ordem_servico_id"]);
                os.ClienteId = Convert.ToInt32(row["cliente_id"]);
                os.VeiculoId = Convert.ToInt32(row["veiculo_id"]);
                os.DataAbertura = row["data_abertura"].ToString();
                os.DataPrevisao = row["data_previsao"].ToString();
                os.DataFechamento = row["data_fechamento"].ToString();
                os.Status = row["status"].ToString();
                os.DescricaoProblema = row["descricao_problema"].ToString();
                os.Diagnostico = row["diagnostico"].ToString();
                os.Observacoes = row["observacoes"].ToString();
                os.ValorMaoDeObra = Convert.ToDecimal(row["valor_mao_obra"]);
                os.ValorTotal = Convert.ToDecimal(row["valor_total"]);
                os.ClienteNome = row["cliente_nome"].ToString();
                os.VeiculoDescricao = row["veiculo_descricao"].ToString();

                lista.Add(os);
            }

            return lista;
        }

        public int InserirItem(OrdemServicoItem item)
        {
            string query =
                "INSERT INTO OrdemServicoItem " +
                "(ordem_servico_id, tipo, descricao, quantidade, " +
                "valor_unitario, subtotal) " +
                "VALUES " +
                "(@OSId, @Tipo, @Descricao, @Quantidade, " +
                "@ValorUnitario, @Subtotal)";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@OSId", item.OrdemServicoId);
            command.Parameters.AddWithValue("@Tipo", item.Tipo);
            command.Parameters.AddWithValue("@Descricao", item.Descricao);
            command.Parameters.AddWithValue("@Quantidade", item.Quantidade);
            command.Parameters.AddWithValue("@ValorUnitario", item.ValorUnitario);
            command.Parameters.AddWithValue("@Subtotal", item.Subtotal);

            return dataBase.ExecuteSQL(command);
        }

        public List<OrdemServicoItem> GetItens(int osId)
        {
            string query =
                "SELECT * FROM OrdemServicoItem " +
                "WHERE ordem_servico_id = @Id ORDER BY item_id";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Id", osId);

            DataTable tabela = dataBase.GetDataTable(command);

            List<OrdemServicoItem> itens =
                new List<OrdemServicoItem>();

            foreach (DataRow row in tabela.Rows)
            {
                OrdemServicoItem item = new OrdemServicoItem();

                item.ItemId = Convert.ToInt32(row["item_id"]);
                item.OrdemServicoId =
                    Convert.ToInt32(row["ordem_servico_id"]);

                item.Tipo = row["tipo"].ToString();
                item.Descricao = row["descricao"].ToString();

                item.Quantidade = Convert.ToDecimal(row["quantidade"]);
                item.ValorUnitario =
                    Convert.ToDecimal(row["valor_unitario"]);

                item.Subtotal = Convert.ToDecimal(row["subtotal"]);

                itens.Add(item);
            }

            return itens;
        }

        public int ExcluirItens(int osId)
        {
            SqlCommand command = new SqlCommand(
                "DELETE FROM OrdemServicoItem WHERE ordem_servico_id = @Id");

            command.Parameters.AddWithValue("@Id", osId);

            return dataBase.ExecuteSQL(command);
        }

        public int RegistrarHistorico(
        int osId,
        string statusAnterior,
        string statusNovo)
        {
            string query =
                "INSERT INTO OrdemServicoHistorico " +
                "(ordem_servico_id, status_anterior, status_novo) " +
                "VALUES (@OSId, @Anterior, @Novo)";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@OSId", osId);
            command.Parameters.AddWithValue("@Anterior", statusAnterior);
            command.Parameters.AddWithValue("@Novo", statusNovo);

            return dataBase.ExecuteSQL(command);
        }

        public List<OrdemServicoHistorico> GetHistorico(int osId)
        {
            string query =
                "SELECT * FROM OrdemServicoHistorico " +
                "WHERE ordem_servico_id = @Id " +
                "ORDER BY data_alteracao DESC";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Id", osId);

            DataTable tabela = dataBase.GetDataTable(command);

            List<OrdemServicoHistorico> historico =
                new List<OrdemServicoHistorico>();

            foreach (DataRow row in tabela.Rows)
            {
                OrdemServicoHistorico registro =
                    new OrdemServicoHistorico();

                registro.HistoricoId =
                    Convert.ToInt32(row["historico_id"]);

                registro.OrdemServicoId =
                    Convert.ToInt32(row["ordem_servico_id"]);

                registro.StatusAnterior =
                    row["status_anterior"].ToString();

                registro.StatusNovo =
                    row["status_novo"].ToString();

                registro.DataAlteracao =
                    Convert.ToDateTime(row["data_alteracao"]);

                historico.Add(registro);
            }

            return historico;
        }
    }
}
