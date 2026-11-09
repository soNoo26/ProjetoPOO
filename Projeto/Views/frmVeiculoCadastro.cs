using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoExemploCerto.Models;
using ProjetoExemploCerto.Controllers;

namespace ProjetoExemploCerto.Views
{
    public partial class frmVeiculoCadastro : Form
    {
        VeiculoController veiculoController = new VeiculoController();
        ClienteController clienteController = new ClienteController();

        private int acao;
        private int veiculoId;

        public frmVeiculoCadastro(int Acao = 1, Veiculo veiculo = null)
        {
            InitializeComponent();

            acao = Acao;

            CarregarClientes();

            if (veiculo != null)
            {
                veiculoId = veiculo.IdVeiculo;

                txtPlaca.Text = veiculo.Placa;
                txtMarca.Text = veiculo.Marca;
                txtModelo.Text = veiculo.Modelo;
                txtAno.Text = veiculo.Ano.ToString();
                txtMotor.Text = veiculo.Motor;
                cmbCombustivel.Text = veiculo.Combustivel;

                cmbCliente.SelectedValue = veiculo.IdCliente;
            }
            if (acao == 2)
                btnSalvar.Text = "Atualizar";
        }
        private void CarregarClientes()
        {
            try
            {
                List<Cliente> clientes = clienteController.GetAll();

                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "Nome";
                cmbCliente.ValueMember = "ClienteId";
                cmbCliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("não foi possivel carregar os clientes: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtAno.Text) ||
                string.IsNullOrWhiteSpace(txtMotor.Text) ||
                string.IsNullOrWhiteSpace(cmbCombustivel.Text)
                )
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ano;

            if (!int.TryParse(txtAno.Text, out ano))
            {
                MessageBox.Show("Digite um ano válido.");

                return;
            }
            Veiculo veiculo = new Veiculo();

            veiculo.IdVeiculo = veiculoId;
            veiculo.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue);
            veiculo.Placa = txtPlaca.Text.Trim();
            veiculo.Marca = txtMarca.Text.Trim();
            veiculo.Modelo = txtModelo.Text.Trim();
            veiculo.Ano = ano;
            veiculo.Motor = txtMotor.Text.Trim();
            veiculo.Combustivel = cmbCombustivel.Text.Trim();

            try
            {
                int resultado;

                if (acao == 2)
                    resultado = veiculoController.Alterar(veiculo);
                else
                    resultado = veiculoController.Inserir(veiculo);

                if (resultado > 0)
                {
                    MessageBox.Show("Veículo salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Não foi possivel salvar o veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o veículo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
