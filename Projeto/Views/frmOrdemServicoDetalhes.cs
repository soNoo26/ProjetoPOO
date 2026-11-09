using System;
using System.Windows.Forms;
using ProjetoExemploCerto.Models;
using ProjetoExemploCerto.Controllers;

namespace ProjetoExemploCerto.Views
{
    public partial class frmOrdemServicoDetalhes : Form
    {
        OrdemServicoController osController =
            new OrdemServicoController();

        private int osId;

        public frmOrdemServicoDetalhes(int id)
        {
            InitializeComponent();

            osId = id;

            btnFechar.Click += btnFechar_Click;

            ConfigurarGrid();
            CarregarDetalhes();
        }

        private void ConfigurarGrid()
        {
            dgvItens.ReadOnly = true;
            dgvItens.AllowUserToAddRows = false;
            dgvItens.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvItens.AutoGenerateColumns = true;
        }

        private void CarregarDetalhes()
        {
            try
            {
                OrdemServiço os =
                    osController.GetById(osId);

                if (os == null)
                {
                    MessageBox.Show(
                        "Ordem de Serviço não encontrada."
                    );

                    Close();
                    return;
                }

                lblNumero.Text =
                    "Ordem de Serviço Nº " + os.OrdemServicoId;

                lblCliente.Text =
                    "Cliente: " + os.ClienteNome;

                lblVeiculo.Text =
                    "Veículo: " + os.VeiculoDescricao;

                lblAbertura.Text =
                    "Abertura: " + os.DataAbertura;

                lblPrevisao.Text =
                    "Previsão: " + os.DataPrevisao;

                lblStatus.Text =
                    "Status: " + os.Status;

                lblProblema.Text =
                    "Problema: " + os.DescricaoProblema;

                lblDiagnostico.Text =
                    "Diagnóstico: " + os.Diagnostico;

                lblObservacoes.Text =
                    "Observações: " + os.Observacoes;

                lblMaoDeObra.Text =
                    "Mão de obra: " +
                    os.ValorMaoDeObra.ToString("C2");

                lblTotal.Text =
                    "TOTAL: " + os.ValorTotal.ToString("C2");

                dgvItens.DataSource =
                    osController.GetItens(osId);

                dgvHistorico.DataSource = osController.GetHistorico(osId);

                ConfigurarHistorico();

                ConfigurarColunas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar detalhes: " + ex.Message
                );
            }
        }

        private void ConfigurarColunas()
        {
            string[] ocultar =
            {
                "ItemId",
                "OrdemServicoId"
            };

            foreach (string coluna in ocultar)
            {
                if (dgvItens.Columns[coluna] != null)
                    dgvItens.Columns[coluna].Visible = false;
            }

            if (dgvItens.Columns["Tipo"] != null)
                dgvItens.Columns["Tipo"].HeaderText = "Tipo";

            if (dgvItens.Columns["Descricao"] != null)
                dgvItens.Columns["Descricao"].HeaderText = "Descrição";

            if (dgvItens.Columns["Quantidade"] != null)
                dgvItens.Columns["Quantidade"].HeaderText = "Quantidade";

            if (dgvItens.Columns["ValorUnitario"] != null)
            {
                dgvItens.Columns["ValorUnitario"].HeaderText =
                    "Valor unitário";

                dgvItens.Columns["ValorUnitario"]
                    .DefaultCellStyle.Format = "C2";
            }

            if (dgvItens.Columns["Subtotal"] != null)
            {
                dgvItens.Columns["Subtotal"].HeaderText =
                    "Subtotal";

                dgvItens.Columns["Subtotal"]
                    .DefaultCellStyle.Format = "C2";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigurarHistorico()
        {
            dgvHistorico.ReadOnly = true;
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AutoGenerateColumns = true;
            dgvHistorico.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            if (dgvHistorico.Columns["HistoricoId"] != null)
                dgvHistorico.Columns["HistoricoId"].Visible = false;

            if (dgvHistorico.Columns["OrdemServicoId"] != null)
                dgvHistorico.Columns["OrdemServicoId"].Visible = false;

            if (dgvHistorico.Columns["StatusAnterior"] != null)
                dgvHistorico.Columns["StatusAnterior"].HeaderText =
                    "Status anterior";

            if (dgvHistorico.Columns["StatusNovo"] != null)
                dgvHistorico.Columns["StatusNovo"].HeaderText =
                    "Novo status";

            if (dgvHistorico.Columns["DataAlteracao"] != null)
            {
                dgvHistorico.Columns["DataAlteracao"].HeaderText =
                    "Data da alteração";

                dgvHistorico.Columns["DataAlteracao"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
        }
    }
}