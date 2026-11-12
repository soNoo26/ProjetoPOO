using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoExemploCerto.Models;
using ProjetoExemploCerto.Controllers;

namespace ProjetoExemploCerto.Views
{
    public partial class frmVeiculoSelecao : Form
    {
        VeiculoController veiculoController = new VeiculoController();

        public frmVeiculoSelecao()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            try
            {
                List<Veiculo> veiculos;

                if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    veiculos = veiculoController.GetAll();
                }
                else
                {
                    veiculos = veiculoController.GetByFilter(txtPesquisa.Text.Trim());
                }

                // A grade é preenchida com ou sem pesquisa
                dgvRegistros.DataSource = null;
                dgvRegistros.DataSource = veiculos;

                lblRegistros.Text = "Registros encontrados: " + veiculos.Count;

                if (dgvRegistros.Columns["IdVeiculo"] != null)
                    dgvRegistros.Columns["IdVeiculo"].HeaderText = "Codigo";

                if (dgvRegistros.Columns["IdCliente"] != null)
                    dgvRegistros.Columns["IdCliente"].HeaderText = "Codigo Cliente";

                if (dgvRegistros.Columns["Placa"] != null)
                    dgvRegistros.Columns["Placa"].HeaderText = "Placa";

                if (dgvRegistros.Columns["Marca"] != null)
                    dgvRegistros.Columns["Marca"].HeaderText = "Marca";

                if (dgvRegistros.Columns["Modelo"] != null)
                    dgvRegistros.Columns["Modelo"].HeaderText = "Modelo";

                if (dgvRegistros.Columns["Ano"] != null)
                    dgvRegistros.Columns["Ano"].HeaderText = "Ano";

                if (dgvRegistros.Columns["Motor"] != null)
                    dgvRegistros.Columns["Motor"].HeaderText = "Motor";

                if (dgvRegistros.Columns["Combustivel"] != null)
                    dgvRegistros.Columns["Combustivel"].HeaderText = "Combustível";

                if (dgvRegistros.Columns["ClienteNome"] != null)
                    dgvRegistros.Columns["ClienteNome"].HeaderText = "Proprietário";

                if (dgvRegistros.Columns["ClienteId"] != null)
                    dgvRegistros.Columns["ClienteId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar veiculos: " + ex.Message);
            }
        }
        private Veiculo GetVeiculoSelecionado()
        {
            if (dgvRegistros.CurrentRow == null)
                return null;

            return dgvRegistros.CurrentRow.DataBoundItem as Veiculo;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmVeiculoCadastro frmVeiculoCadastro = new frmVeiculoCadastro();
            frmVeiculoCadastro.ShowDialog();
            AtualizarGrid();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Veiculo veiculo = GetVeiculoSelecionado();
            if (veiculo == null)
            {
                MessageBox.Show("Selecione um veículo para editar.");
                return;
            }
            frmVeiculoCadastro frmVeiculoCadastro = new frmVeiculoCadastro(2, veiculo);
            frmVeiculoCadastro.ShowDialog();
            AtualizarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = GetVeiculoSelecionado();
            if (veiculo == null)
            {
                MessageBox.Show("Selecione um veículo para excluir.");
                return;
            }

            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir o veículo selecionado?", "Confirmação", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    veiculoController.Excluir(veiculo.IdVeiculo);
                    MessageBox.Show("Veículo excluído com sucesso.");
                    AtualizarGrid();
                }
                catch (System.Data.SqlClient.SqlException ex) when (ex.Number == 547)
                {
                    MessageBox.Show("Não é possível excluir: este veículo possui ordens de serviço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir veículo: " + ex.Message);
                }
            }

        }

    }
}
