using ProjetoExemploCerto.Models;
using ProjetoExemploCerto.Controllers;
using System;
using System.Windows.Forms;

namespace ProjetoExemploCerto.Views
{
    public partial class frmUsuarioCadastro : Form
    {
        UsuarioController usuarioController =
            new UsuarioController();

        private int acao;
        private int usuarioId;

        public frmUsuarioCadastro(int Acao = 1, Usuario usuario = null)
        {
            InitializeComponent();

            acao = Acao;

            btnSalvar.Click += btnSalvar_Click;
            btnCancelar.Click += btnCancelar_Click;

            if (usuario != null)
            {
                usuarioId = usuario.UsuarioId;

                txtNome.Text = usuario.Nome;
                txtCPF.Text = usuario.CPF;
                txtTelefone.Text = usuario.Telefone;
                txtEmail.Text = usuario.Email;
                txtSenha.Text = usuario.Senha;
                txtCargo.Text = usuario.Cargo;
            }

            if (acao == 2)
                btnSalvar.Text = "Atualizar";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" ||
                txtCPF.Text.Trim() == "" ||
                txtTelefone.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "" ||
                txtSenha.Text.Trim() == "" ||
                txtCargo.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Por favor, preencha todos os campos obrigatórios.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Usuario usuario = new Usuario();

            usuario.UsuarioId = usuarioId;
            usuario.Nome = txtNome.Text.Trim();
            usuario.CPF = txtCPF.Text.Trim();
            usuario.Telefone = txtTelefone.Text.Trim();
            usuario.Email = txtEmail.Text.Trim();
            usuario.Senha = txtSenha.Text;
            usuario.Cargo = txtCargo.Text.Trim();

            try
            {
                int resultado;

                if (acao == 2)
                    resultado = usuarioController.Alterar(usuario);
                else
                    resultado = usuarioController.Inserir(usuario);

                if (resultado > 0)
                {
                    MessageBox.Show(
                        acao == 2
                            ? "Usuário atualizado com sucesso!"
                            : "Usuário cadastrado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar usuário.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
