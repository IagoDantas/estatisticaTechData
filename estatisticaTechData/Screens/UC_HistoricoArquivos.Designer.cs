namespace estatisticaTechData
{
    partial class UC_HistoricoArquivos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumeroPagina = new System.Windows.Forms.Label();
            this.pnlArquivos = new System.Windows.Forms.Panel();
            this.lblDataArquivo = new System.Windows.Forms.Label();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.lblRecentes = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlArquivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroPagina
            // 
            this.lblNumeroPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroPagina.AutoSize = true;
            this.lblNumeroPagina.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPagina.Location = new System.Drawing.Point(815, 651);
            this.lblNumeroPagina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroPagina.Name = "lblNumeroPagina";
            this.lblNumeroPagina.Size = new System.Drawing.Size(30, 28);
            this.lblNumeroPagina.TabIndex = 18;
            this.lblNumeroPagina.Text = "1/1";
            // 
            // pnlArquivos
            // 
            this.pnlArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlArquivos.Controls.Add(this.lblDataArquivo);
            this.pnlArquivos.Controls.Add(this.lblNomeArquivo);
            this.pnlArquivos.Location = new System.Drawing.Point(99, 182);
            this.pnlArquivos.Margin = new System.Windows.Forms.Padding(2);
            this.pnlArquivos.Name = "pnlArquivos";
            this.pnlArquivos.Size = new System.Drawing.Size(804, 430);
            this.pnlArquivos.TabIndex = 15;
            // 
            // lblDataArquivo
            // 
            this.lblDataArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataArquivo.AutoSize = true;
            this.lblDataArquivo.Enabled = false;
            this.lblDataArquivo.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataArquivo.Location = new System.Drawing.Point(604, 6);
            this.lblDataArquivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataArquivo.Name = "lblDataArquivo";
            this.lblDataArquivo.Size = new System.Drawing.Size(68, 34);
            this.lblDataArquivo.TabIndex = 1;
            this.lblDataArquivo.Text = "Data:";
            this.lblDataArquivo.Visible = false;
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Enabled = false;
            this.lblNomeArquivo.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArquivo.Location = new System.Drawing.Point(32, 6);
            this.lblNomeArquivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(78, 34);
            this.lblNomeArquivo.TabIndex = 0;
            this.lblNomeArquivo.Text = "Nome:";
            this.lblNomeArquivo.Visible = false;
            // 
            // lblRecentes
            // 
            this.lblRecentes.AutoSize = true;
            this.lblRecentes.Font = new System.Drawing.Font("Poppins", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.lblRecentes.Location = new System.Drawing.Point(101, 124);
            this.lblRecentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentes.Name = "lblRecentes";
            this.lblRecentes.Size = new System.Drawing.Size(125, 40);
            this.lblRecentes.TabIndex = 16;
            this.lblRecentes.Text = "Recentes";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(378, 67);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(314, 48);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Histórico de arquivos";
            // 
            // UC_HistoricoArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumeroPagina);
            this.Controls.Add(this.pnlArquivos);
            this.Controls.Add(this.lblRecentes);
            this.Name = "UC_HistoricoArquivos";
            this.Size = new System.Drawing.Size(1000, 720);
            this.Load += new System.EventHandler(this.UC_HistoricoArquivos_Load);
            this.pnlArquivos.ResumeLayout(false);
            this.pnlArquivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private techDataButton btnAnterior;
        private System.Windows.Forms.Label lblNumeroPagina;
        private techDataButton btnProximaPagina;
        private System.Windows.Forms.Panel pnlArquivos;
        private System.Windows.Forms.Label lblDataArquivo;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.Label lblRecentes;
        private techDataButton btnNovaCarga;
        private System.Windows.Forms.Label lblTitulo;
    }
}
