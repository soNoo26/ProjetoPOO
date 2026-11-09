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
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(12, 76);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.RowTemplate.Height = 24;
            this.dgvItens.Size = new System.Drawing.Size(776, 150);
            this.dgvItens.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(655, 405);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(133, 33);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 57);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 16);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "label1";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(166, 57);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 16);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "label2";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(259, 57);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(44, 16);
            this.lblVeiculo.TabIndex = 4;
            this.lblVeiculo.Text = "label3";
            // 
            // lblAbertura
            // 
            this.lblAbertura.AutoSize = true;
            this.lblAbertura.Location = new System.Drawing.Point(380, 57);
            this.lblAbertura.Name = "lblAbertura";
            this.lblAbertura.Size = new System.Drawing.Size(44, 16);
            this.lblAbertura.TabIndex = 5;
            this.lblAbertura.Text = "label4";
            // 
            // lblPrevisao
            // 
            this.lblPrevisao.AutoSize = true;
            this.lblPrevisao.Location = new System.Drawing.Point(430, 57);
            this.lblPrevisao.Name = "lblPrevisao";
            this.lblPrevisao.Size = new System.Drawing.Size(44, 16);
            this.lblPrevisao.TabIndex = 6;
            this.lblPrevisao.Text = "label5";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(480, 57);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "label6";
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Location = new System.Drawing.Point(530, 57);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(44, 16);
            this.lblProblema.TabIndex = 8;
            this.lblProblema.Text = "label7";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(580, 57);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(44, 16);
            this.lblDiagnostico.TabIndex = 9;
            this.lblDiagnostico.Text = "label8";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(630, 57);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(44, 16);
            this.lblObservacoes.TabIndex = 10;
            this.lblObservacoes.Text = "label9";
            // 
            // lblMaoDeObra
            // 
            this.lblMaoDeObra.AutoSize = true;
            this.lblMaoDeObra.Location = new System.Drawing.Point(680, 57);
            this.lblMaoDeObra.Name = "lblMaoDeObra";
            this.lblMaoDeObra.Size = new System.Drawing.Size(51, 16);
            this.lblMaoDeObra.TabIndex = 11;
            this.lblMaoDeObra.Text = "label10";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(737, 57);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 16);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "label11";
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(12, 291);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.RowHeadersWidth = 51;
            this.dgvHistorico.RowTemplate.Height = 24;
            this.dgvHistorico.Size = new System.Drawing.Size(779, 108);
            this.dgvHistorico.TabIndex = 13;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(12, 272);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(60, 16);
            this.lblHistorico.TabIndex = 14;
            this.lblHistorico.Text = "Historico";
            // 
            // frmOrdemServicoDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}