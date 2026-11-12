using System;
using System.Windows.Forms;
using ProjetoExemploCerto.Views;

namespace ProjetoExemploCerto.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            frmVeiculoSelecao frmVeiculoSelecao = new frmVeiculoSelecao();
            frmVeiculoSelecao.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClienteSelecao frmClienteSelecao = new frmClienteSelecao();
            frmClienteSelecao.ShowDialog();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            frmOrdemServicoSelecao tela =
                new frmOrdemServicoSelecao();

            tela.ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmUsuarioSelecao frmUsuarioSelecao = new frmUsuarioSelecao();

            frmUsuarioSelecao.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
