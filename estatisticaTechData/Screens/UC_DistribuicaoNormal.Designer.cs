﻿namespace estatisticaTechData.Screens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DistribuicaoNormal));
            this.lklNovaCarga = new System.Windows.Forms.LinkLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGráfico = new System.Windows.Forms.Label();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.pnlHistorico = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.pnlLegenda = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGrafico = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGraficoPorcentagem = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGraficoPorcentagem = new System.Windows.Forms.Label();
            this.btnNovaBase = new estatisticaTechData.techDataButton();
            this.btnAcessoHistorico = new estatisticaTechData.techDataButton();
            this.pnlHistorico.SuspendLayout();
            this.pnlLegenda.SuspendLayout();
            this.pnlGrafico.SuspendLayout();
            this.pnlGraficoPorcentagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lklNovaCarga
            // 
            this.lklNovaCarga.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lklNovaCarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lklNovaCarga.AutoSize = true;
            this.lklNovaCarga.Cursor = System.Windows.Forms.Cursors.Default;
            this.lklNovaCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklNovaCarga.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklNovaCarga.LinkColor = System.Drawing.Color.Black;
            this.lklNovaCarga.Location = new System.Drawing.Point(834, 145);
            this.lklNovaCarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lklNovaCarga.Name = "lklNovaCarga";
            this.lklNovaCarga.Size = new System.Drawing.Size(139, 17);
            this.lklNovaCarga.TabIndex = 15;
            this.lklNovaCarga.TabStop = true;
            this.lklNovaCarga.Text = "Nova base de dados";
            this.lklNovaCarga.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(333, 80);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 36);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Distribuição Normal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGráfico
            // 
            this.lblGráfico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGráfico.AutoSize = true;
            this.lblGráfico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblGráfico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGráfico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGráfico.Location = new System.Drawing.Point(103, 180);
            this.lblGráfico.Name = "lblGráfico";
            this.lblGráfico.Size = new System.Drawing.Size(391, 20);
            this.lblGráfico.TabIndex = 12;
            this.lblGráfico.Text = "Os gráficos de distribuição normal serão gerados aqui.";
            // 
            // lblLegenda
            // 
            this.lblLegenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblLegenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLegenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.Location = new System.Drawing.Point(83, 50);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(429, 25);
            this.lblLegenda.TabIndex = 7;
            this.lblLegenda.Text = "As legendas do gráfico serão geradas aqui.";
            // 
            // pnlHistorico
            // 
            this.pnlHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlHistorico.Controls.Add(this.lblHistorico);
            this.pnlHistorico.Controls.Add(this.btnAcessoHistorico);
            this.pnlHistorico.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlHistorico.Location = new System.Drawing.Point(21, 579);
            this.pnlHistorico.Name = "pnlHistorico";
            this.pnlHistorico.Padding = new System.Windows.Forms.Padding(20, 15, 0, 0);
            this.pnlHistorico.Size = new System.Drawing.Size(315, 122);
            this.pnlHistorico.TabIndex = 9;
            // 
            // lblHistorico
            // 
            this.lblHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.Location = new System.Drawing.Point(23, 15);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHistorico.Size = new System.Drawing.Size(269, 40);
            this.lblHistorico.TabIndex = 0;
            this.lblHistorico.Text = "Histórico dos gráficos de distribuição normal anteriores:";
            this.lblHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLegenda
            // 
            this.pnlLegenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLegenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlLegenda.Controls.Add(this.lblLegenda);
            this.pnlLegenda.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlLegenda.Location = new System.Drawing.Point(366, 579);
            this.pnlLegenda.Name = "pnlLegenda";
            this.pnlLegenda.Padding = new System.Windows.Forms.Padding(80, 50, 0, 0);
            this.pnlLegenda.Size = new System.Drawing.Size(607, 122);
            this.pnlLegenda.TabIndex = 10;
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlGrafico.Controls.Add(this.lblGráfico);
            this.pnlGrafico.Location = new System.Drawing.Point(366, 199);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Padding = new System.Windows.Forms.Padding(100, 180, 0, 0);
            this.pnlGrafico.Size = new System.Drawing.Size(607, 350);
            this.pnlGrafico.TabIndex = 11;
            // 
            // pnlGraficoPorcentagem
            // 
            this.pnlGraficoPorcentagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlGraficoPorcentagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlGraficoPorcentagem.Controls.Add(this.lblGraficoPorcentagem);
            this.pnlGraficoPorcentagem.Location = new System.Drawing.Point(21, 199);
            this.pnlGraficoPorcentagem.Name = "pnlGraficoPorcentagem";
            this.pnlGraficoPorcentagem.Padding = new System.Windows.Forms.Padding(30, 150, 0, 0);
            this.pnlGraficoPorcentagem.Size = new System.Drawing.Size(315, 350);
            this.pnlGraficoPorcentagem.TabIndex = 8;
            // 
            // lblGraficoPorcentagem
            // 
            this.lblGraficoPorcentagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGraficoPorcentagem.AutoSize = true;
            this.lblGraficoPorcentagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblGraficoPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGraficoPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficoPorcentagem.Location = new System.Drawing.Point(33, 150);
            this.lblGraficoPorcentagem.Name = "lblGraficoPorcentagem";
            this.lblGraficoPorcentagem.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblGraficoPorcentagem.Size = new System.Drawing.Size(265, 60);
            this.lblGraficoPorcentagem.TabIndex = 5;
            this.lblGraficoPorcentagem.Text = "Os gráficos com porcentagem serão gerados aqui.";
            this.lblGraficoPorcentagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNovaBase
            // 
            this.btnNovaBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnNovaBase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnNovaBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovaBase.BackgroundImage")));
            this.btnNovaBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovaBase.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNovaBase.BorderRadius = 80;
            this.btnNovaBase.BorderSize = 0;
            this.btnNovaBase.FlatAppearance.BorderSize = 0;
            this.btnNovaBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaBase.ForeColor = System.Drawing.Color.White;
            this.btnNovaBase.Location = new System.Drawing.Point(861, 65);
            this.btnNovaBase.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovaBase.Name = "btnNovaBase";
            this.btnNovaBase.Size = new System.Drawing.Size(75, 78);
            this.btnNovaBase.TabIndex = 14;
            this.btnNovaBase.TextColor = System.Drawing.Color.White;
            this.btnNovaBase.UseVisualStyleBackColor = false;
            this.btnNovaBase.Click += new System.EventHandler(this.btnNovaBase_Click);
            // 
            // btnAcessoHistorico
            // 
            this.btnAcessoHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcessoHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAcessoHistorico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAcessoHistorico.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAcessoHistorico.BorderRadius = 50;
            this.btnAcessoHistorico.BorderSize = 0;
            this.btnAcessoHistorico.FlatAppearance.BorderSize = 0;
            this.btnAcessoHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessoHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessoHistorico.ForeColor = System.Drawing.Color.White;
            this.btnAcessoHistorico.Location = new System.Drawing.Point(23, 58);
            this.btnAcessoHistorico.Name = "btnAcessoHistorico";
            this.btnAcessoHistorico.Size = new System.Drawing.Size(269, 47);
            this.btnAcessoHistorico.TabIndex = 5;
            this.btnAcessoHistorico.Text = "Acessar";
            this.btnAcessoHistorico.TextColor = System.Drawing.Color.White;
            this.btnAcessoHistorico.UseVisualStyleBackColor = false;
            this.btnAcessoHistorico.Click += new System.EventHandler(this.btnAcessoHistorico_Click);
            // 
            // UC_DistribuicaoNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.lklNovaCarga);
            this.Controls.Add(this.btnNovaBase);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlHistorico);
            this.Controls.Add(this.pnlLegenda);
            this.Controls.Add(this.pnlGrafico);
            this.Controls.Add(this.pnlGraficoPorcentagem);
            this.Name = "UC_DistribuicaoNormal";
            this.Size = new System.Drawing.Size(1000, 720);
            this.pnlHistorico.ResumeLayout(false);
            this.pnlHistorico.PerformLayout();
            this.pnlLegenda.ResumeLayout(false);
            this.pnlLegenda.PerformLayout();
            this.pnlGrafico.ResumeLayout(false);
            this.pnlGrafico.PerformLayout();
            this.pnlGraficoPorcentagem.ResumeLayout(false);
            this.pnlGraficoPorcentagem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lklNovaCarga;
        private techDataButton btnNovaBase;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGráfico;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.FlowLayoutPanel pnlHistorico;
        private System.Windows.Forms.Label lblHistorico;
        private techDataButton btnAcessoHistorico;
        private System.Windows.Forms.FlowLayoutPanel pnlLegenda;
        private System.Windows.Forms.FlowLayoutPanel pnlGrafico;
        private System.Windows.Forms.FlowLayoutPanel pnlGraficoPorcentagem;
        private System.Windows.Forms.Label lblGraficoPorcentagem;
    }
}
