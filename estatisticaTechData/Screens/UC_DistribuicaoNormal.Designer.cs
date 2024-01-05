namespace estatisticaTechData.Screens
{
    partial class UC_DistribuicaoNormal
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlGraficos = new System.Windows.Forms.Panel();
            this.zedDistribuicao = new ZedGraph.ZedGraphControl();
            this.lblMediaTitle = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblDesvioTitle = new System.Windows.Forms.Label();
            this.lblCPKTitle = new System.Windows.Forms.Label();
            this.pnlInfos = new System.Windows.Forms.Panel();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitleLim = new System.Windows.Forms.Label();
            this.lblVariancia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnalise = new System.Windows.Forms.Label();
            this.lblAnaliseTitle = new System.Windows.Forms.Label();
            this.lblIQR = new System.Windows.Forms.Label();
            this.lblDesvio = new System.Windows.Forms.Label();
            this.lblInfos = new System.Windows.Forms.Label();
            this.btnLim = new estatisticaTechData.techDataButton();
            this.btnVermais = new estatisticaTechData.techDataButton();
            this.pnlGraficos.SuspendLayout();
            this.pnlInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(297, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(483, 51);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Gráfico de Distribuição Normal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraficos
            // 
            this.pnlGraficos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlGraficos.Controls.Add(this.zedDistribuicao);
            this.pnlGraficos.Location = new System.Drawing.Point(271, 116);
            this.pnlGraficos.Name = "pnlGraficos";
            this.pnlGraficos.Size = new System.Drawing.Size(742, 501);
            this.pnlGraficos.TabIndex = 14;
            // 
            // zedDistribuicao
            // 
            this.zedDistribuicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedDistribuicao.Enabled = false;
            this.zedDistribuicao.Location = new System.Drawing.Point(0, 0);
            this.zedDistribuicao.Name = "zedDistribuicao";
            this.zedDistribuicao.ScrollGrace = 0D;
            this.zedDistribuicao.ScrollMaxX = 0D;
            this.zedDistribuicao.ScrollMaxY = 0D;
            this.zedDistribuicao.ScrollMaxY2 = 0D;
            this.zedDistribuicao.ScrollMinX = 0D;
            this.zedDistribuicao.ScrollMinY = 0D;
            this.zedDistribuicao.ScrollMinY2 = 0D;
            this.zedDistribuicao.Size = new System.Drawing.Size(742, 501);
            this.zedDistribuicao.TabIndex = 1;
            this.zedDistribuicao.UseExtendedPrintDialog = true;
            // 
            // lblMediaTitle
            // 
            this.lblMediaTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMediaTitle.AutoSize = true;
            this.lblMediaTitle.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaTitle.Location = new System.Drawing.Point(91, 62);
            this.lblMediaTitle.Name = "lblMediaTitle";
            this.lblMediaTitle.Size = new System.Drawing.Size(59, 23);
            this.lblMediaTitle.TabIndex = 0;
            this.lblMediaTitle.Text = "Média:";
            this.lblMediaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedia
            // 
            this.lblMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMedia.Location = new System.Drawing.Point(86, 87);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(70, 14);
            this.lblMedia.TabIndex = 1;
            this.lblMedia.Text = "000.0000";
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesvioTitle
            // 
            this.lblDesvioTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesvioTitle.AutoSize = true;
            this.lblDesvioTitle.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesvioTitle.Location = new System.Drawing.Point(63, 110);
            this.lblDesvioTitle.Name = "lblDesvioTitle";
            this.lblDesvioTitle.Size = new System.Drawing.Size(116, 23);
            this.lblDesvioTitle.TabIndex = 2;
            this.lblDesvioTitle.Text = "Desvio Padrão";
            this.lblDesvioTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPKTitle
            // 
            this.lblCPKTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCPKTitle.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPKTitle.Location = new System.Drawing.Point(32, 261);
            this.lblCPKTitle.Name = "lblCPKTitle";
            this.lblCPKTitle.Size = new System.Drawing.Size(178, 25);
            this.lblCPKTitle.TabIndex = 4;
            this.lblCPKTitle.Text = "Amplitude interquartil:";
            this.lblCPKTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInfos
            // 
            this.pnlInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlInfos.Controls.Add(this.btnLim);
            this.pnlInfos.Controls.Add(this.txtMax);
            this.pnlInfos.Controls.Add(this.txtMin);
            this.pnlInfos.Controls.Add(this.label3);
            this.pnlInfos.Controls.Add(this.label1);
            this.pnlInfos.Controls.Add(this.lblTitleLim);
            this.pnlInfos.Controls.Add(this.lblVariancia);
            this.pnlInfos.Controls.Add(this.label2);
            this.pnlInfos.Controls.Add(this.lblAnalise);
            this.pnlInfos.Controls.Add(this.lblAnaliseTitle);
            this.pnlInfos.Controls.Add(this.lblIQR);
            this.pnlInfos.Controls.Add(this.lblDesvio);
            this.pnlInfos.Controls.Add(this.lblInfos);
            this.pnlInfos.Controls.Add(this.btnVermais);
            this.pnlInfos.Controls.Add(this.lblMediaTitle);
            this.pnlInfos.Controls.Add(this.lblMedia);
            this.pnlInfos.Controls.Add(this.lblCPKTitle);
            this.pnlInfos.Controls.Add(this.lblDesvioTitle);
            this.pnlInfos.Location = new System.Drawing.Point(14, 116);
            this.pnlInfos.Name = "pnlInfos";
            this.pnlInfos.Size = new System.Drawing.Size(242, 501);
            this.pnlInfos.TabIndex = 66;
            // 
            // txtMax
            // 
            this.txtMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMax.Font = new System.Drawing.Font("Poppins Medium", 9.75F);
            this.txtMax.Location = new System.Drawing.Point(34, 423);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(65, 27);
            this.txtMax.TabIndex = 18;
            // 
            // txtMin
            // 
            this.txtMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMin.Font = new System.Drawing.Font("Poppins Medium", 9.75F);
            this.txtMin.Location = new System.Drawing.Point(146, 423);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(65, 27);
            this.txtMin.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Min";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Máx";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleLim
            // 
            this.lblTitleLim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleLim.AutoSize = true;
            this.lblTitleLim.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLim.Location = new System.Drawing.Point(81, 364);
            this.lblTitleLim.Name = "lblTitleLim";
            this.lblTitleLim.Size = new System.Drawing.Size(81, 28);
            this.lblTitleLim.TabIndex = 14;
            this.lblTitleLim.Text = "Limites:";
            this.lblTitleLim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVariancia
            // 
            this.lblVariancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVariancia.Location = new System.Drawing.Point(86, 184);
            this.lblVariancia.Name = "lblVariancia";
            this.lblVariancia.Size = new System.Drawing.Size(70, 14);
            this.lblVariancia.TabIndex = 13;
            this.lblVariancia.Text = "000.0000";
            this.lblVariancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Variãncia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnalise
            // 
            this.lblAnalise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnalise.Location = new System.Drawing.Point(26, 237);
            this.lblAnalise.Name = "lblAnalise";
            this.lblAnalise.Size = new System.Drawing.Size(190, 13);
            this.lblAnalise.TabIndex = 11;
            this.lblAnalise.Text = "Dispersão";
            this.lblAnalise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnaliseTitle
            // 
            this.lblAnaliseTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnaliseTitle.AutoSize = true;
            this.lblAnaliseTitle.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnaliseTitle.Location = new System.Drawing.Point(30, 212);
            this.lblAnaliseTitle.Name = "lblAnaliseTitle";
            this.lblAnaliseTitle.Size = new System.Drawing.Size(181, 23);
            this.lblAnaliseTitle.TabIndex = 10;
            this.lblAnaliseTitle.Text = "Analise da Distribuição";
            this.lblAnaliseTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIQR
            // 
            this.lblIQR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIQR.Location = new System.Drawing.Point(86, 286);
            this.lblIQR.Name = "lblIQR";
            this.lblIQR.Size = new System.Drawing.Size(70, 14);
            this.lblIQR.TabIndex = 9;
            this.lblIQR.Text = "000.0000";
            this.lblIQR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDesvio
            // 
            this.lblDesvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesvio.Location = new System.Drawing.Point(86, 135);
            this.lblDesvio.Name = "lblDesvio";
            this.lblDesvio.Size = new System.Drawing.Size(70, 14);
            this.lblDesvio.TabIndex = 8;
            this.lblDesvio.Text = "000.0000";
            this.lblDesvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfos
            // 
            this.lblInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfos.AutoSize = true;
            this.lblInfos.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfos.Location = new System.Drawing.Point(56, 21);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(130, 28);
            this.lblInfos.TabIndex = 7;
            this.lblInfos.Text = "Informações:";
            this.lblInfos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLim
            // 
            this.btnLim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnLim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnLim.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLim.BorderRadius = 40;
            this.btnLim.BorderSize = 0;
            this.btnLim.FlatAppearance.BorderSize = 0;
            this.btnLim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLim.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLim.ForeColor = System.Drawing.Color.White;
            this.btnLim.Location = new System.Drawing.Point(46, 456);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(150, 40);
            this.btnLim.TabIndex = 19;
            this.btnLim.Text = "Definir";
            this.btnLim.TextColor = System.Drawing.Color.White;
            this.btnLim.UseVisualStyleBackColor = false;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // btnVermais
            // 
            this.btnVermais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVermais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVermais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVermais.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVermais.BorderRadius = 40;
            this.btnVermais.BorderSize = 0;
            this.btnVermais.FlatAppearance.BorderSize = 0;
            this.btnVermais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVermais.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVermais.ForeColor = System.Drawing.Color.White;
            this.btnVermais.Location = new System.Drawing.Point(46, 310);
            this.btnVermais.Name = "btnVermais";
            this.btnVermais.Size = new System.Drawing.Size(150, 40);
            this.btnVermais.TabIndex = 6;
            this.btnVermais.Text = "Ver Mais";
            this.btnVermais.TextColor = System.Drawing.Color.White;
            this.btnVermais.UseVisualStyleBackColor = false;
            this.btnVermais.Click += new System.EventHandler(this.btnVermais_Click);
            // 
            // UC_DistribuicaoNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.pnlInfos);
            this.Controls.Add(this.pnlGraficos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_DistribuicaoNormal";
            this.Size = new System.Drawing.Size(1040, 658);
            this.Load += new System.EventHandler(this.UC_DistribuicaoNormal_Load);
            this.pnlGraficos.ResumeLayout(false);
            this.pnlInfos.ResumeLayout(false);
            this.pnlInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private techDataButton btnNovaBase;
        private System.Windows.Forms.Label lblTitulo;
        private techDataButton btnAcessoHistorico;
        private System.Windows.Forms.Panel pnlGraficos;
        private ZedGraph.ZedGraphControl zedDistribuicao;
        private System.Windows.Forms.Label lblMediaTitle;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblDesvioTitle;
        private System.Windows.Forms.Label lblCPKTitle;
        private System.Windows.Forms.Panel pnlInfos;
        private System.Windows.Forms.Label lblInfos;
        private techDataButton btnVermais;
        private System.Windows.Forms.Label lblIQR;
        private System.Windows.Forms.Label lblDesvio;
        private System.Windows.Forms.Label labelAnalise;
        private System.Windows.Forms.Label lblAnaliseTitle;
        private System.Windows.Forms.Label lblAnalise;
        private System.Windows.Forms.Label lblVariancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitleLim;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private techDataButton btnLim;
    }
}
