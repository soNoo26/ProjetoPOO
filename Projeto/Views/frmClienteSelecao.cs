using ProjetoExemploCerto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoExemploCerto.Views
{
    public partial class frmClienteSelecao : Form
    {

        ClienteController clienteController = new ClienteController();

        public frmClienteSelecao()
        {
            InitializeComponent();

            try
            {
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os clientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarGrid()
        {
            List<Cliente> clientes;

            if (txtNome.Text.Trim() == "")
                clientes = clienteController.GetAll();
            else
                clientes = clienteController.GetByName(txtNome.Text.Trim());

            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = clientes;

            lblRegistros.Text = $"{clientes.Count} registro(s) encontrado(s).";

            if (dgvRegistros.Columns["ClienteId"] != null)
                dgvRegistros.Columns["ClienteId"].HeaderText = "Código";

            if (dgvRegistros.Columns["Nome"] != null)
                dgvRegistros.Columns["Nome"].HeaderText = "Nome";

            if (dgvRegistros.Columns["CadastroNacional"] != null)
                dgvRegistros.Columns["CadastroNacional"].HeaderText = "Cadastro Nacional";

            if (dgvRegistros.Columns["QtVeiculos"] != null)
                dgvRegistros.Columns["QtVeiculos"].HeaderText = "Qt. Veículos";

            if (dgvRegistros.Columns["Email"] != null)
                dgvRegistros.Columns["Email"].HeaderText = "E-mail";

            if (dgvRegistros.Columns["Telefone"] != null)
                dgvRegistros.Columns["Telefone"].HeaderText = "Telefone";

            if (dgvRegistros.Columns["CEP"] != null)
                dgvRegistros.Columns["CEP"].HeaderText = "CEP";

            if (dgvRegistros.Columns["Endereco"] != null)
                dgvRegistros.Columns["Endereco"].HeaderText = "Endereço";

            if (dgvRegistros.Columns["Cidade"] != null)
                dgvRegistros.Columns["Cidade"].HeaderText = "Cidade";
        }
        private Cliente GetClienteSelecionado()
        {
            if (dgvRegistros.CurrentRow == null)
                return null;

            return dgvRegistros.CurrentRow.DataBoundItem as Cliente;
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            txtNome.Clear();
            AtualizarGrid();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmClienteCadastro frm = new frmClienteCadastro();
            frm.ShowDialog();

            AtualizarGrid();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = GetClienteSelecionado();
            if (cliente == null)
            {
                MessageBox.Show("Por favor, selecione um cliente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmClienteCadastro tela = new frmClienteCadastro(2, cliente);
            tela.ShowDialog();

            AtualizarGrid();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = GetClienteSelecionado();
            if (cliente == null)
            {
                MessageBox.Show("Por favor, selecione um cliente para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resposta = MessageBox.Show($"Tem certeza que deseja excluir o cliente '{cliente.Nome}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                try
                {
                    clienteController.Excluir(cliente.ClienteId);
                    AtualizarGrid();
                }
                catch (System.Data.SqlClient.SqlException ex) when (ex.Number == 547)
                {
                    MessageBox.Show("Não é possível excluir: este cliente possui veículos ou ordens de serviço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
