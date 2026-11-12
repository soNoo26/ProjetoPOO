namespace ProjetoExemploCerto.Views
{
    partial class frmOrdemServicoDetalhes
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
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblAbertura = new System.Windows.Forms.Label();
            this.lblPrevisao = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProblema = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblMaoDeObra = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(9, 62);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.RowTemplate.Height = 24;
            this.dgvItens.Size = new System.Drawing.Size(677, 122);
            this.dgvItens.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(590, 328);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 27);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.LightGray;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(9, 43);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 17);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numero";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.LightGray;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(71, 43);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.BackColor = System.Drawing.Color.LightGray;
            this.lblVeiculo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(126, 43);
            this.lblVeiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(53, 17);
            this.lblVeiculo.TabIndex = 4;
            this.lblVeiculo.Text = "Veiculo";
            // 
            // lblAbertura
            // 
            this.lblAbertura.AutoSize = true;
            this.lblAbertura.BackColor = System.Drawing.Color.LightGray;
            this.lblAbertura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbertura.Location = new System.Drawing.Point(183, 43);
            this.lblAbertura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbertura.Name = "lblAbertura";
            this.lblAbertura.Size = new System.Drawing.Size(62, 17);
            this.lblAbertura.TabIndex = 5;
            this.lblAbertura.Text = "Abertura";
            // 
            // lblPrevisao
            // 
            this.lblPrevisao.AutoSize = true;
            this.lblPrevisao.BackColor = System.Drawing.Color.LightGray;
            this.lblPrevisao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevisao.Location = new System.Drawing.Point(249, 43);
            this.lblPrevisao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrevisao.Name = "lblPrevisao";
            this.lblPrevisao.Size = new System.Drawing.Size(60, 17);
            this.lblPrevisao.TabIndex = 6;
            this.lblPrevisao.Text = "Previsão";
            this.lblPrevisao.Click += new System.EventHandler(this.lblPrevisao_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.LightGray;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(309, 43);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.BackColor = System.Drawing.Color.LightGray;
            this.lblProblema.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblema.Location = new System.Drawing.Point(356, 43);
            this.lblProblema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(73, 17);
            this.lblProblema.TabIndex = 8;
            this.lblProblema.Text = "Problemas";
            this.lblProblema.Click += new System.EventHandler(this.lblProblema_Click);
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.BackColor = System.Drawing.Color.LightGray;
            this.lblDiagnostico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.Location = new System.Drawing.Point(433, 43);
            this.lblDiagnostico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(82, 17);
            this.lblDiagnostico.TabIndex = 9;
            this.lblDiagnostico.Text = "Diagnostico";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.BackColor = System.Drawing.Color.LightGray;
            this.lblObservacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.Location = new System.Drawing.Point(519, 43);
            this.lblObservacoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(90, 17);
            this.lblObservacoes.TabIndex = 10;
            this.lblObservacoes.Text = "Observações ";
            // 
            // lblMaoDeObra
            // 
            this.lblMaoDeObra.AutoSize = true;
            this.lblMaoDeObra.BackColor = System.Drawing.Color.LightGray;
            this.lblMaoDeObra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaoDeObra.Location = new System.Drawing.Point(613, 43);
            this.lblMaoDeObra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaoDeObra.Name = "lblMaoDeObra";
            this.lblMaoDeObra.Size = new System.Drawing.Size(30, 17);
            this.lblMaoDeObra.TabIndex = 11;
            this.lblMaoDeObra.Text = "MO";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.LightGray;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(647, 43);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 17);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(9, 236);
            this.dgvHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.RowHeadersWidth = 51;
            this.dgvHistorico.RowTemplate.Height = 24;
            this.dgvHistorico.Size = new System.Drawing.Size(677, 88);
            this.dgvHistorico.TabIndex = 13;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHistorico.Location = new System.Drawing.Point(11, 217);
            this.lblHistorico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(64, 17);
            this.lblHistorico.TabIndex = 14;
            this.lblHistorico.Text = "Historico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Detalhes da Ordem de Seviço";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(9, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 147);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmOrdemServicoDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.dgvHistorico);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMaoDeObra);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.lblProblema);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPrevisao);
            this.Controls.Add(this.lblAbertura);
            this.Controls.Add(this.lblVeiculo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOrdemServicoDetalhes";
            this.Text = "frmOrdemServicoDetalhes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblAbertura;
        private System.Windows.Forms.Label lblPrevisao;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Label lblMaoDeObra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}