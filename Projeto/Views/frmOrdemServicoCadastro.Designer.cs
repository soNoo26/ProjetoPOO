namespace ProjetoExemploCerto.Views
{
    partial class frmOrdemServicoCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.dtpAbertura = new System.Windows.Forms.DateTimePicker();
            this.dtpPrevisao = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtProblema = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtMaoDeObra = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.cmbTipoItem = new System.Windows.Forms.ComboBox();
            this.txtDescricaoItem = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(17, 55);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(206, 29);
            this.cmbCliente.TabIndex = 0;
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Location = new System.Drawing.Point(249, 55);
            this.cmbVeiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(210, 29);
            this.cmbVeiculo.TabIndex = 1;
            // 
            // dtpAbertura
            // 
            this.dtpAbertura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAbertura.Location = new System.Drawing.Point(486, 57);
            this.dtpAbertura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpAbertura.Name = "dtpAbertura";
            this.dtpAbertura.Size = new System.Drawing.Size(151, 29);
            this.dtpAbertura.TabIndex = 2;
            // 
            // dtpPrevisao
            // 
            this.dtpPrevisao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrevisao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPrevisao.Location = new System.Drawing.Point(668, 57);
            this.dtpPrevisao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpPrevisao.Name = "dtpPrevisao";
            this.dtpPrevisao.Size = new System.Drawing.Size(151, 29);
            this.dtpPrevisao.TabIndex = 3;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Aberta",
            "",
            "",
            "",
            "",
            "Em andamento",
            "",
            "",
            "",
            "",
            "Aguardando peças",
            "",
            "",
            "",
            "",
            "Aguardando aprovação",
            "",
            "",
            "",
            "",
            "Concluída",
            "",
            "",
            "",
            "",
            "Entregue",
            "",
            "",
            "",
            "",
            "Cancelada"});
            this.cmbStatus.Location = new System.Drawing.Point(17, 112);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(140, 29);
            this.cmbStatus.TabIndex = 4;
            // 
            // txtProblema
            // 
            this.txtProblema.AcceptsReturn = true;
            this.txtProblema.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProblema.Location = new System.Drawing.Point(17, 46);
            this.txtProblema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProblema.Multiline = true;
            this.txtProblema.Name = "txtProblema";
            this.txtProblema.Size = new System.Drawing.Size(266, 98);
            this.txtProblema.TabIndex = 5;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.AcceptsReturn = true;
            this.txtObservacoes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(584, 45);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(234, 100);
            this.txtObservacoes.TabIndex = 6;
            // 
            // txtMaoDeObra
            // 
            this.txtMaoDeObra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaoDeObra.Location = new System.Drawing.Point(17, 40);
            this.txtMaoDeObra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaoDeObra.Name = "txtMaoDeObra";
            this.txtMaoDeObra.Size = new System.Drawing.Size(192, 29);
            this.txtMaoDeObra.TabIndex = 7;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.AcceptsReturn = true;
            this.txtDiagnostico.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(296, 46);
            this.txtDiagnostico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(260, 98);
            this.txtDiagnostico.TabIndex = 8;
            // 
            // cmbTipoItem
            // 
            this.cmbTipoItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoItem.FormattingEnabled = true;
            this.cmbTipoItem.Items.AddRange(new object[] {
            "Peça",
            "Serviço"});
            this.cmbTipoItem.Location = new System.Drawing.Point(17, 48);
            this.cmbTipoItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoItem.Name = "cmbTipoItem";
            this.cmbTipoItem.Size = new System.Drawing.Size(111, 29);
            this.cmbTipoItem.TabIndex = 9;
            // 
            // txtDescricaoItem
            // 
            this.txtDescricaoItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoItem.Location = new System.Drawing.Point(132, 50);
            this.txtDescricaoItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescricaoItem.Name = "txtDescricaoItem";
            this.txtDescricaoItem.Size = new System.Drawing.Size(432, 29);
            this.txtDescricaoItem.TabIndex = 10;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(568, 50);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(108, 29);
            this.txtQuantidade.TabIndex = 11;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitario.Location = new System.Drawing.Point(679, 50);
            this.txtValorUnitario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(79, 29);
            this.txtValorUnitario.TabIndex = 12;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdicionarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItem.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarItem.Location = new System.Drawing.Point(761, 50);
            this.btnAdicionarItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(56, 28);
            this.btnAdicionarItem.TabIndex = 13;
            this.btnAdicionarItem.Text = "+";
            this.btnAdicionarItem.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Location = new System.Drawing.Point(723, 654);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 35);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(614, 654);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 35);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(2, 32);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(154, 21);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Valor Total: R$ 0,00";
            // 
            // dgvItens
            // 
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(17, 82);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.RowTemplate.Height = 24;
            this.dgvItens.Size = new System.Drawing.Size(802, 90);
            this.dgvItens.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnRemoverItem);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(868, 712);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoverItem.Location = new System.Drawing.Point(505, 652);
            this.btnRemoverItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(105, 35);
            this.btnRemoverItem.TabIndex = 23;
            this.btnRemoverItem.Text = "Remover";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpPrevisao);
            this.groupBox2.Controls.Add(this.cmbStatus);
            this.groupBox2.Controls.Add(this.dtpAbertura);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbVeiculo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(846, 158);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1. Dados do Cliente e Veículo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status da OS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data/Hora Abertura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Previsão Conclusão";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtObservacoes);
            this.groupBox3.Controls.Add(this.txtProblema);
            this.groupBox3.Controls.Add(this.txtDiagnostico);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(11, 180);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(846, 171);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Detalhes Técnicos e Relatório";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(580, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Observações Gerais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Diagnostico Tecnico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Problemas Relatados";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnAdicionarItem);
            this.groupBox4.Controls.Add(this.txtValorUnitario);
            this.groupBox4.Controls.Add(this.dgvItens);
            this.groupBox4.Controls.Add(this.txtQuantidade);
            this.groupBox4.Controls.Add(this.cmbTipoItem);
            this.groupBox4.Controls.Add(this.txtDescricaoItem);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 365);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(846, 190);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3. Peças e Serviços Aplicados";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(676, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Valor Unit.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(565, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Quantidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(129, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Descrição";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tipo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.txtMaoDeObra);
            this.groupBox5.Location = new System.Drawing.Point(11, 561);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(846, 87);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(18, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(275, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "Valor Adicional / Mão de Obra (R$)";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox6.Controls.Add(this.lblTotal);
            this.groupBox6.Location = new System.Drawing.Point(658, 8);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(160, 74);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // frmOrdemServicoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(888, 733);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(904, 617);
            this.Name = "frmOrdemServicoCadastro";
            this.Text = "frmOrdemServicoCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.DateTimePicker dtpAbertura;
        private System.Windows.Forms.DateTimePicker dtpPrevisao;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtProblema;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtMaoDeObra;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.ComboBox cmbTipoItem;
        private System.Windows.Forms.TextBox txtDescricaoItem;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRemoverItem;
    }
}