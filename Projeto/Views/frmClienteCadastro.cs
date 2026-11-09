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
    public partial class frmClienteCadastro : Form
    {

        ClienteController clienteController = new ClienteController();

        private int acao;
        private int clienteId;
        public frmClienteCadastro(int Acao = 1, Cliente cliente = null)
        {
            InitializeComponent();

            acao = Acao;

            if (cliente != null) 
            {
                clienteId = cliente.ClienteId;
                txtNome.Text = cliente.Nome;
                txtCPF.Text = cliente.CadastroNacional;
                txtTelefone.Text = cliente.Telefone;
                txtEmail.Text = cliente.Email;
                txtCidade.Text = cliente.Cidade;
            }
            if (acao == 2)
                btnSalvar.Text = "Atualizar";
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "" ||
                txtTelefone.Text.Trim() == "" ||
                txtEndereco.Text.Trim() == "" ||
                txtCidade.Text.Trim() == "" ||
                txtCPF.Text.Trim() == ""
                )
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = new Cliente();

            cliente.Nome = txtNome.Text.Trim();
            cliente.CadastroNacional = txtCPF.Text.Trim();
            cliente.Telefone = txtTelefone.Text.Trim();
            cliente.Email = txtEmail.Text.Trim();
            cliente.Cidade = txtCidade.Text.Trim();

            try
            {
                int resultado = clienteController.Inserir(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
