
using ProjetoExemploCerto.Models;
using ProjetoExemploCerto.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoExemploCerto.Views
{
    public partial class frmUsuarioSelecao : Form
    {
        UsuarioController usuarioController = new UsuarioController();

        public frmUsuarioSelecao()
        {
            InitializeComponent();

            btnPesquisar.Click += btnPesquisar_Click;
            btnAtualizar.Click += btnAtualizar_Click;
            btnCadastro.Click += btnCadastro_Click;
            btnEditar.Click += btnEditar_Click;
            btnExcluir.Click += btnExcluir_Click;

            try
            {
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarGrid()
        {
            List<Usuario> usuarios = usuarioController.GetAll();

            string pesquisa = txtNome.Text.Trim().ToLower();

            if (pesquisa != "")
            {
                usuarios = usuarios.Where(u =>
                    (u.Nome ?? "").ToLower().Contains(pesquisa) ||
                    (u.CPF ?? "").ToLower().Contains(pesquisa) ||
                    (u.Email ?? "").ToLower().Contains(pesquisa) ||
                    (u.Telefone ?? "").ToLower().Contains(pesquisa) ||
                    (u.Cargo ?? "").ToLower().Contains(pesquisa)
                ).ToList();
            }

            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = usuarios;

            lblRegistros.Text =
                usuarios.Count + " registro(s) encontrado(s).";

            if (dgvRegistros.Columns["UsuarioId"] != null)
                dgvRegistros.Columns["UsuarioId"].HeaderText = "Código";

            if (dgvRegistros.Columns["Nome"] != null)
                dgvRegistros.Columns["Nome"].HeaderText = "Nome";

            if (dgvRegistros.Columns["CPF"] != null)
                dgvRegistros.Columns["CPF"].HeaderText = "CPF";

            if (dgvRegistros.Columns["Telefone"] != null)
                dgvRegistros.Columns["Telefone"].HeaderText = "Telefone";

            if (dgvRegistros.Columns["Email"] != null)
                dgvRegistros.Columns["Email"].HeaderText = "E-mail";

            if (dgvRegistros.Columns["Cargo"] != null)
                dgvRegistros.Columns["Cargo"].HeaderText = "Cargo";

            // Não exibir a senha na listagem
            if (dgvRegistros.Columns["Senha"] != null)
                dgvRegistros.Columns["Senha"].Visible = false;
        }

        private Usuario GetUsuarioSelecionado()
        {
            if (dgvRegistros.CurrentRow == null)
                return null;

            return dgvRegistros.CurrentRow.DataBoundItem as Usuario;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            AtualizarGrid();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmUsuarioCadastro tela = new frmUsuarioCadastro();

            if (tela.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuario = GetUsuarioSelecionado();

            if (usuario == null)
            {
                MessageBox.Show(
                    "Por favor, selecione um usuário para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            frmUsuarioCadastro tela =
                new frmUsuarioCadastro(2, usuario);

            if (tela.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Usuario usuario = GetUsuarioSelecionado();

            if (usuario == null)
            {
                MessageBox.Show(
                    "Por favor, selecione um usuário para excluir.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja excluir o usuário '" +
                usuario.Nome + "'?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    usuarioController.Excluir(usuario.UsuarioId);
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao excluir usuário: " + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
