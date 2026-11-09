using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using ProjetoExemploCerto.Models;
using ProjetoExemploCerto.Controllers;

namespace ProjetoExemploCerto.Views
{
    public partial class frmOrdemServicoCadastro : Form
    {
        ClienteController clienteController = new ClienteController();
        VeiculoController veiculoController = new VeiculoController();
        OrdemServicoController osController = new OrdemServicoController();

        List<OrdemServicoItem> itens = new List<OrdemServicoItem>();

        private int ordemServicoId = 0;
        private bool carregandoDados = false;

        public frmOrdemServicoCadastro()
        {
            InitializeComponent();

            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            btnRemoverItem.Click += btnRemoverItem_Click;
            btnSalvar.Click += btnSalvar_Click;
            btnCancelar.Click += btnCancelar_Click;

            ConfigurarTela();
            CarregarClientes();
        }

        public frmOrdemServicoCadastro(OrdemServiço os)
    : this()
        {
            ordemServicoId = os.OrdemServicoId;

            Text = "Editar Ordem de Serviço";

            CarregarDados(os);
        }

        // CONFIGURAÇÕES INICIAIS
        private void ConfigurarTela()
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Aberta");
            cmbStatus.Items.Add("Em andamento");
            cmbStatus.Items.Add("Aguardando peças");
            cmbStatus.Items.Add("Aguardando aprovação");
            cmbStatus.Items.Add("Concluída");
            cmbStatus.Items.Add("Entregue");
            cmbStatus.Items.Add("Cancelada");

            cmbStatus.SelectedIndex = 0;

            cmbTipoItem.Items.Clear();
            cmbTipoItem.Items.Add("Peça");
            cmbTipoItem.Items.Add("Serviço");
            cmbTipoItem.SelectedIndex = 0;

            dtpAbertura.Value = DateTime.Now;
            dtpPrevisao.Value = DateTime.Now.AddDays(3);

            dgvItens.AutoGenerateColumns = true;
            dgvItens.ReadOnly = true;
            dgvItens.AllowUserToAddRows = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.MultiSelect = false;
        }

        // CARREGAR CLIENTES
        private void CarregarClientes()
        {
            try
            {
                List<Cliente> clientes = clienteController.GetAll();

                cmbCliente.DataSource = null;
                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "Nome";
                cmbCliente.ValueMember = "ClienteId";
                cmbCliente.SelectedIndex = -1;

                cmbVeiculo.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        // CARREGAR VEÍCULOS DO CLIENTE SELECIONADO
        private void cmbCliente_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (carregandoDados)
                return;

            if (cmbCliente.SelectedValue == null ||
                !(cmbCliente.SelectedValue is int))
                return;

            try
            {
                int clienteId =
                    Convert.ToInt32(cmbCliente.SelectedValue);

                List<Veiculo> veiculos =
                    veiculoController.GetByClienteId(clienteId);

                cmbVeiculo.DataSource = null;
                cmbVeiculo.DataSource = veiculos;
                cmbVeiculo.DisplayMember = "Modelo";
                cmbVeiculo.ValueMember = "VeiculoId";
                cmbVeiculo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar veículos: " + ex.Message
                );
            }
        }

        // ADICIONAR PEÇA OU SERVIÇO
        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricaoItem.Text))
            {
                MessageBox.Show("Informe a descrição do item.");
                return;
            }

            decimal quantidade;
            decimal valorUnitario;

            if (!decimal.TryParse(txtQuantidade.Text, out quantidade) ||
                quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida.");
                return;
            }

            if (!decimal.TryParse(
                txtValorUnitario.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out valorUnitario) || valorUnitario < 0)
            {
                MessageBox.Show("Informe um valor unitário válido.");
                return;
            }

            OrdemServicoItem item = new OrdemServicoItem();

            item.Tipo = cmbTipoItem.Text;
            item.Descricao = txtDescricaoItem.Text.Trim();
            item.Quantidade = quantidade;
            item.ValorUnitario = valorUnitario;
            item.Subtotal = quantidade * valorUnitario;

            itens.Add(item);

            AtualizarGridItens();
            CalcularTotal();

            txtDescricaoItem.Clear();
            txtQuantidade.Clear();
            txtValorUnitario.Clear();

            txtDescricaoItem.Focus();
        }

        // ATUALIZAR TABELA DE ITENS
        private void AtualizarGridItens()
        {
            dgvItens.DataSource = null;
            dgvItens.DataSource = itens;

            if (dgvItens.Columns["ItemId"] != null)
                dgvItens.Columns["ItemId"].Visible = false;

            if (dgvItens.Columns["OrdemServicoId"] != null)
                dgvItens.Columns["OrdemServicoId"].Visible = false;

            if (dgvItens.Columns["Tipo"] != null)
                dgvItens.Columns["Tipo"].HeaderText = "Tipo";

            if (dgvItens.Columns["Descricao"] != null)
                dgvItens.Columns["Descricao"].HeaderText = "Descrição";

            if (dgvItens.Columns["Quantidade"] != null)
                dgvItens.Columns["Quantidade"].HeaderText = "Quantidade";

            if (dgvItens.Columns["ValorUnitario"] != null)
                dgvItens.Columns["ValorUnitario"].HeaderText = "Valor unitário";

            if (dgvItens.Columns["Subtotal"] != null)
                dgvItens.Columns["Subtotal"].HeaderText = "Subtotal";

            if (dgvItens.Columns["ValorUnitario"] != null)
                dgvItens.Columns["ValorUnitario"].DefaultCellStyle.Format = "C2";

            if (dgvItens.Columns["Subtotal"] != null)
                dgvItens.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
        }

        // REMOVER ITEM
        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (dgvItens.CurrentRow == null)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }

            OrdemServicoItem item =
                dgvItens.CurrentRow.DataBoundItem as OrdemServicoItem;

            if (item != null)
            {
                itens.Remove(item);

                AtualizarGridItens();
                CalcularTotal();
            }
        }

        // CALCULAR VALOR TOTAL
        private decimal CalcularTotal()
        {
            decimal totalItens = 0;
            decimal maoDeObra = 0;

            foreach (OrdemServicoItem item in itens)
            {
                totalItens += item.Subtotal;
            }

            decimal.TryParse(
                txtMaoDeObra.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out maoDeObra
            );

            decimal total = totalItens + maoDeObra;

            lblTotal.Text = "Total: " + total.ToString("C2");

            return total;
        }

        // SALVAR ORDEM DE SERVIÇO
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null ||
                cmbVeiculo.SelectedValue == null)
            {
                MessageBox.Show("Selecione o cliente e o veículo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProblema.Text))
            {
                MessageBox.Show("Informe o problema relatado pelo cliente.");
                return;
            }

            decimal maoDeObra;

            if (!decimal.TryParse(
                txtMaoDeObra.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out maoDeObra) || maoDeObra < 0)
            {
                MessageBox.Show("Informe um valor válido para a mão de obra.");
                return;
            }

            if (dtpPrevisao.Value.Date < dtpAbertura.Value.Date)
            {
                MessageBox.Show("A previsão não pode ser anterior à abertura.");
                return;
            }

            OrdemServiço os = new OrdemServiço();

            os.ClienteId = Convert.ToInt32(cmbCliente.SelectedValue);
            os.VeiculoId = Convert.ToInt32(cmbVeiculo.SelectedValue);

            os.DataAbertura = dtpAbertura.Value.ToString("yyyy-MM-dd HH:mm:ss");
            os.DataPrevisao = dtpPrevisao.Value.ToString("yyyy-MM-dd HH:mm:ss");

            os.Status = cmbStatus.Text;
            os.DescricaoProblema = txtProblema.Text.Trim();
            os.Diagnostico = txtDiagnostico.Text.Trim();
            os.Observacoes = txtObservacoes.Text.Trim();

            os.ValorMaoDeObra = maoDeObra;
            os.ValorTotal = CalcularTotal();

            try
            {
                int osId;

                if (ordemServicoId > 0)
                {
                    // MODO EDIÇÃO
                    os.OrdemServicoId = Convert.ToInt32(ordemServicoId);

                    int resultado = osController.Alterar(os);

                    if (resultado <= 0)
                    {
                        MessageBox.Show("Não foi possível atualizar a OS.");
                        return;
                    }

                    osId = ordemServicoId;

                    // Remover itens antigos
                    osController.ExcluirItens(osId);
                }
                else
                {
                    // MODO CADASTRO
                    osId = osController.Inserir(os);

                    if (osId <= 0)
                    {
                        MessageBox.Show("Não foi possível cadastrar a OS.");
                        return;
                    }
                }

                // Salvar todos os itens atuais
                foreach (OrdemServicoItem item in itens)
                {
                    item.OrdemServicoId = osId;
                    osController.InserirItem(item);
                }

                MessageBox.Show(
                    ordemServicoId > 0
                    ? "Ordem de Serviço atualizada com sucesso!"
                    : "Ordem de Serviço cadastrada com sucesso!\nNúmero: " + osId
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao salvar a OS: " + ex.Message
                );
            }
        }

        // CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;        
            this.Close();
        }

        private void CarregarDados(OrdemServiço os)
        {
            try
            {
                carregandoDados = true;

                cmbCliente.SelectedValue = os.ClienteId;

                carregandoDados = false;

                // Carregar veículos do cliente
                List<Veiculo> veiculos =
                    veiculoController.GetByClienteId(os.ClienteId);

                cmbVeiculo.DataSource = null;
                cmbVeiculo.DataSource = veiculos;
                cmbVeiculo.DisplayMember = "Modelo";
                cmbVeiculo.ValueMember = "VeiculoId";

                cmbVeiculo.SelectedValue = os.VeiculoId;

                // Datas
                DateTime data;

                if (DateTime.TryParse(os.DataAbertura, out data))
                    dtpAbertura.Value = data;

                if (DateTime.TryParse(os.DataPrevisao, out data))
                    dtpPrevisao.Value = data;

                // Demais campos
                cmbStatus.Text = os.Status;
                txtProblema.Text = os.DescricaoProblema;
                txtDiagnostico.Text = os.Diagnostico;
                txtObservacoes.Text = os.Observacoes;

                txtMaoDeObra.Text =
                    os.ValorMaoDeObra.ToString("0.00");

                // Carregar peças e serviços
                itens = osController.GetItens(os.OrdemServicoId);

                AtualizarGridItens();
                CalcularTotal();

                btnSalvar.Text = "Atualizar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar os dados da OS: " + ex.Message
                );
            }
        }
    }
}
