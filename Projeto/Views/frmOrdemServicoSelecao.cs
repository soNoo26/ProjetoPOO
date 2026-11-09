using ProjetoExemploCerto.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjetoExemploCerto.Models;
using ProjetoExemploCerto.Controllers;

namespace ProjetoExemploCerto.Views
{
    public partial class frmOrdemServicoSelecao : Form
    {
        OrdemServicoController osController =
            new OrdemServicoController();

        List<OrdemServiço> ordens =
            new List<OrdemServiço>();

        public frmOrdemServicoSelecao()
        {
            InitializeComponent();

            dgvRegistros.ReadOnly = true;
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.MultiSelect = false;
            dgvRegistros.AutoGenerateColumns = true;
            dgvRegistros.CellDoubleClick += dgvRegistros_CellDoubleClick;

            btnPesquisar.Click += btnPesquisar_Click_1;
            btnAdicionar.Click += btnAdicionar_Click_1;
            btnEditar.Click += btnEditar_Click_1;
            btnExcluir.Click += btnExcluir_Click_1;

            CarregarOrdens();
        }

        // BUSCAR TODAS AS ORDENS
        private void CarregarOrdens()
        {
            try
            {
                ordens = osController.GetAll();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar as Ordens de Serviço: " + ex.Message
                );
            }
        }

        // APLICAR PESQUISA E FILTRO DE STATUS
        private void AplicarFiltros()
        {
            string pesquisa = txtPesquisa.Text.Trim().ToLower();

            List<OrdemServiço> resultado = ordens
                .Where(os =>
                    pesquisa == "" ||
                    os.OrdemServicoId.ToString().Contains(pesquisa) ||
                    (os.ClienteNome ?? "").ToLower().Contains(pesquisa) ||
                    (os.VeiculoDescricao ?? "").ToLower().Contains(pesquisa) ||
                    (os.DescricaoProblema ?? "").ToLower().Contains(pesquisa) ||
                    (os.Status ?? "").ToLower().Contains(pesquisa)
                )
                .ToList();

            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = resultado;

            ConfigurarColunas();

            lblRegistros.Text =
                "Ordens encontradas: " + resultado.Count;
        }

        // CONFIGURAR COLUNAS DA TABELA
        private void ConfigurarColunas()
        {
            if (dgvRegistros.Columns["OrdemServicoId"] != null)
                dgvRegistros.Columns["OrdemServicoId"].HeaderText = "Nº OS";

            if (dgvRegistros.Columns["ClienteNome"] != null)
                dgvRegistros.Columns["ClienteNome"].HeaderText = "Cliente";

            if (dgvRegistros.Columns["VeiculoDescricao"] != null)
                dgvRegistros.Columns["VeiculoDescricao"].HeaderText = "Veículo";

            if (dgvRegistros.Columns["DataAbertura"] != null)
                dgvRegistros.Columns["DataAbertura"].HeaderText = "Abertura";

            if (dgvRegistros.Columns["DataPrevisao"] != null)
                dgvRegistros.Columns["DataPrevisao"].HeaderText = "Previsão";

            if (dgvRegistros.Columns["Status"] != null)
                dgvRegistros.Columns["Status"].HeaderText = "Status";

            if (dgvRegistros.Columns["DescricaoProblema"] != null)
                dgvRegistros.Columns["DescricaoProblema"].HeaderText = "Problema";

            // Ocultar campos que não precisam aparecer na listagem
            string[] colunasOcultas =
            {
                "ClienteId",
                "VeiculoId",
                "DataFechamento",
                "Diagnostico",
                "Observacoes",
                "ValorMaoDeObra",
                "ValorTotal"
            };

            foreach (string coluna in colunasOcultas)
            {
                if (dgvRegistros.Columns[coluna] != null)
                    dgvRegistros.Columns[coluna].Visible = false;
            }
        }

        // PESQUISAR
        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            AplicarFiltros();
        }


        // CADASTRAR NOVA OS
        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            frmOrdemServicoCadastro tela =
                new frmOrdemServicoCadastro();

            tela.ShowDialog();

            CarregarOrdens();
        }

        // VISUALIZAR OS SELECIONADA
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvRegistros.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma Ordem de Serviço.");
                return;
            }

            OrdemServiço os =
                dgvRegistros.CurrentRow.DataBoundItem as OrdemServiço;

            if (os == null)
                return;

            frmOrdemServicoCadastro tela =
                new frmOrdemServicoCadastro(os);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                CarregarOrdens();
            }
        }

        // EXCLUIR OS
        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (dgvRegistros.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma Ordem de Serviço.");
                return;
            }

            OrdemServiço os =
                dgvRegistros.CurrentRow.DataBoundItem as OrdemServiço;

            if (os == null)
                return;

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir a OS nº " +
                os.OrdemServicoId + "?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    osController.Excluir(os.OrdemServicoId);

                    MessageBox.Show("Ordem de Serviço excluída.");

                    CarregarOrdens();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao excluir a Ordem de Serviço: " + ex.Message
                    );
                }
            }
        }
        private void dgvRegistros_CellDoubleClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            OrdemServiço os =
                dgvRegistros.Rows[e.RowIndex].DataBoundItem
                as OrdemServiço;

            if (os == null)
                return;

            frmOrdemServicoDetalhes tela =
                new frmOrdemServicoDetalhes(os.OrdemServicoId);

            tela.ShowDialog();
        }
    }
}
