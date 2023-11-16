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
            this.lblRecentes = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNextPage = new estatisticaTechData.techDataButton();
            this.btnPrevPage = new estatisticaTechData.techDataButton();
            this.SuspendLayout();
            // 
            // lblNumeroPagina
            // 
            this.lblNumeroPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroPagina.AutoSize = true;
            this.lblNumeroPagina.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPagina.Location = new System.Drawing.Point(756, 633);
            this.lblNumeroPagina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroPagina.Name = "lblNumeroPagina";
            this.lblNumeroPagina.Size = new System.Drawing.Size(30, 28);
            this.lblNumeroPagina.TabIndex = 18;
            this.lblNumeroPagina.Text = "1/1";
            // 
            // pnlArquivos
            // 
            this.pnlArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlArquivos.Location = new System.Drawing.Point(108, 166);
            this.pnlArquivos.Margin = new System.Windows.Forms.Padding(2);
            this.pnlArquivos.Name = "pnlArquivos";
            this.pnlArquivos.Size = new System.Drawing.Size(804, 430);
            this.pnlArquivos.TabIndex = 15;
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
            this.lblTitulo.Location = new System.Drawing.Point(437, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(314, 48);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Histórico de arquivos";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.AutoSize = true;
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnNextPage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnNextPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNextPage.BorderRadius = 50;
            this.btnNextPage.BorderSize = 0;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(787, 624);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(125, 46);
            this.btnNextPage.TabIndex = 33;
            this.btnNextPage.Text = "Próximo";
            this.btnNextPage.TextColor = System.Drawing.Color.White;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevPage.AutoSize = true;
            this.btnPrevPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnPrevPage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnPrevPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrevPage.BorderRadius = 50;
            this.btnPrevPage.BorderSize = 0;
            this.btnPrevPage.FlatAppearance.BorderSize = 0;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnPrevPage.Location = new System.Drawing.Point(626, 624);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(125, 46);
            this.btnPrevPage.TabIndex = 34;
            this.btnPrevPage.Text = "Anterior";
            this.btnPrevPage.TextColor = System.Drawing.Color.White;
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // UC_HistoricoArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumeroPagina);
            this.Controls.Add(this.pnlArquivos);
            this.Controls.Add(this.lblRecentes);
            this.Name = "UC_HistoricoArquivos";
            this.Size = new System.Drawing.Size(1000, 720);
            this.Load += new System.EventHandler(this.UC_HistoricoArquivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private techDataButton btnAnterior;
        private System.Windows.Forms.Label lblNumeroPagina;
        private techDataButton btnProximaPagina;
        private System.Windows.Forms.Panel pnlArquivos;
        private System.Windows.Forms.Label lblRecentes;
        private techDataButton btnNovaCarga;
        private System.Windows.Forms.Label lblTitulo;
        private techDataButton btnNextPage;
        private techDataButton btnPrevPage;
    }
}
