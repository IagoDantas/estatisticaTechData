namespace estatisticaTechData.Screens
{
    partial class UC_controlAtributos
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
            this.zedGraphP = new ZedGraph.ZedGraphControl();
            this.zedGraphC = new ZedGraph.ZedGraphControl();
            this.pnlEscolhas = new System.Windows.Forms.Panel();
            this.rdbGraphP = new estatisticaTechData.Resources.techDataRadioButton();
            this.rdbGraphC = new estatisticaTechData.Resources.techDataRadioButton();
            this.lblMediaTitle = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblDesvioTitle = new System.Windows.Forms.Label();
            this.lblCPKTitle = new System.Windows.Forms.Label();
            this.pnlInfos = new System.Windows.Forms.Panel();
            this.lblCpk = new System.Windows.Forms.Label();
            this.lblDesvio = new System.Windows.Forms.Label();
            this.lblInfos = new System.Windows.Forms.Label();
            this.btnVermais = new estatisticaTechData.techDataButton();
            this.pnlGraficos.SuspendLayout();
            this.pnlEscolhas.SuspendLayout();
            this.pnlInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(245, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 51);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Gráfico de Controle de Atributos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraficos
            // 
            this.pnlGraficos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlGraficos.Controls.Add(this.zedGraphP);
            this.pnlGraficos.Controls.Add(this.zedGraphC);
            this.pnlGraficos.Location = new System.Drawing.Point(271, 116);
            this.pnlGraficos.Name = "pnlGraficos";
            this.pnlGraficos.Size = new System.Drawing.Size(742, 368);
            this.pnlGraficos.TabIndex = 14;
            // 
            // zedGraphP
            // 
            this.zedGraphP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphP.Enabled = false;
            this.zedGraphP.Location = new System.Drawing.Point(0, 0);
            this.zedGraphP.Name = "zedGraphP";
            this.zedGraphP.ScrollGrace = 0D;
            this.zedGraphP.ScrollMaxX = 0D;
            this.zedGraphP.ScrollMaxY = 0D;
            this.zedGraphP.ScrollMaxY2 = 0D;
            this.zedGraphP.ScrollMinX = 0D;
            this.zedGraphP.ScrollMinY = 0D;
            this.zedGraphP.ScrollMinY2 = 0D;
            this.zedGraphP.Size = new System.Drawing.Size(742, 368);
            this.zedGraphP.TabIndex = 1;
            this.zedGraphP.UseExtendedPrintDialog = true;
            this.zedGraphP.Visible = false;
            // 
            // zedGraphC
            // 
            this.zedGraphC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphC.Enabled = false;
            this.zedGraphC.Location = new System.Drawing.Point(0, 0);
            this.zedGraphC.Name = "zedGraphC";
            this.zedGraphC.ScrollGrace = 0D;
            this.zedGraphC.ScrollMaxX = 0D;
            this.zedGraphC.ScrollMaxY = 0D;
            this.zedGraphC.ScrollMaxY2 = 0D;
            this.zedGraphC.ScrollMinX = 0D;
            this.zedGraphC.ScrollMinY = 0D;
            this.zedGraphC.ScrollMinY2 = 0D;
            this.zedGraphC.Size = new System.Drawing.Size(742, 368);
            this.zedGraphC.TabIndex = 0;
            this.zedGraphC.UseExtendedPrintDialog = true;
            this.zedGraphC.Visible = false;
            // 
            // pnlEscolhas
            // 
            this.pnlEscolhas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEscolhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlEscolhas.Controls.Add(this.rdbGraphP);
            this.pnlEscolhas.Controls.Add(this.rdbGraphC);
            this.pnlEscolhas.Location = new System.Drawing.Point(271, 504);
            this.pnlEscolhas.Name = "pnlEscolhas";
            this.pnlEscolhas.Size = new System.Drawing.Size(742, 113);
            this.pnlEscolhas.TabIndex = 64;
            // 
            // rdbGraphP
            // 
            this.rdbGraphP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbGraphP.AutoSize = true;
            this.rdbGraphP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbGraphP.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbGraphP.CheckedColor = System.Drawing.Color.White;
            this.rdbGraphP.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGraphP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbGraphP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbGraphP.Location = new System.Drawing.Point(383, 37);
            this.rdbGraphP.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbGraphP.Name = "rdbGraphP";
            this.rdbGraphP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbGraphP.Size = new System.Drawing.Size(129, 38);
            this.rdbGraphP.TabIndex = 65;
            this.rdbGraphP.Text = "Gráfico P";
            this.rdbGraphP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdbGraphP.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbGraphP.UseVisualStyleBackColor = false;
            this.rdbGraphP.CheckedChanged += new System.EventHandler(this.rdbGraphP_CheckedChanged);
            // 
            // rdbGraphC
            // 
            this.rdbGraphC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbGraphC.AutoSize = true;
            this.rdbGraphC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbGraphC.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbGraphC.CheckedColor = System.Drawing.Color.White;
            this.rdbGraphC.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGraphC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbGraphC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbGraphC.Location = new System.Drawing.Point(203, 37);
            this.rdbGraphC.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbGraphC.Name = "rdbGraphC";
            this.rdbGraphC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbGraphC.Size = new System.Drawing.Size(133, 38);
            this.rdbGraphC.TabIndex = 64;
            this.rdbGraphC.Text = "Gráfico C";
            this.rdbGraphC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdbGraphC.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbGraphC.UseVisualStyleBackColor = false;
            this.rdbGraphC.CheckedChanged += new System.EventHandler(this.rdbGraphC_CheckedChanged);
            // 
            // lblMediaTitle
            // 
            this.lblMediaTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMediaTitle.AutoSize = true;
            this.lblMediaTitle.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaTitle.Location = new System.Drawing.Point(90, 90);
            this.lblMediaTitle.Name = "lblMediaTitle";
            this.lblMediaTitle.Size = new System.Drawing.Size(59, 23);
            this.lblMediaTitle.TabIndex = 0;
            this.lblMediaTitle.Text = "Média:";
            // 
            // lblMedia
            // 
            this.lblMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMedia.Location = new System.Drawing.Point(86, 113);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(70, 14);
            this.lblMedia.TabIndex = 1;
            this.lblMedia.Text = "000.0000";
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDesvioTitle
            // 
            this.lblDesvioTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesvioTitle.AutoSize = true;
            this.lblDesvioTitle.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesvioTitle.Location = new System.Drawing.Point(63, 192);
            this.lblDesvioTitle.Name = "lblDesvioTitle";
            this.lblDesvioTitle.Size = new System.Drawing.Size(116, 23);
            this.lblDesvioTitle.TabIndex = 2;
            this.lblDesvioTitle.Text = "Desvio Padrão";
            // 
            // lblCPKTitle
            // 
            this.lblCPKTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCPKTitle.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPKTitle.Location = new System.Drawing.Point(39, 291);
            this.lblCPKTitle.Name = "lblCPKTitle";
            this.lblCPKTitle.Size = new System.Drawing.Size(178, 51);
            this.lblCPKTitle.TabIndex = 4;
            this.lblCPKTitle.Text = "Índice de Capacidade de Processo(Cpk):";
            this.lblCPKTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlInfos
            // 
            this.pnlInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlInfos.Controls.Add(this.lblCpk);
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
            // lblCpk
            // 
            this.lblCpk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCpk.Location = new System.Drawing.Point(87, 342);
            this.lblCpk.Name = "lblCpk";
            this.lblCpk.Size = new System.Drawing.Size(70, 14);
            this.lblCpk.TabIndex = 9;
            this.lblCpk.Text = "000.0000";
            this.lblCpk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDesvio
            // 
            this.lblDesvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesvio.Location = new System.Drawing.Point(86, 215);
            this.lblDesvio.Name = "lblDesvio";
            this.lblDesvio.Size = new System.Drawing.Size(70, 14);
            this.lblDesvio.TabIndex = 8;
            this.lblDesvio.Text = "000.0000";
            this.lblDesvio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfos
            // 
            this.lblInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfos.AutoSize = true;
            this.lblInfos.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfos.Location = new System.Drawing.Point(56, 29);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(130, 28);
            this.lblInfos.TabIndex = 7;
            this.lblInfos.Text = "Informações:";
            // 
            // btnVermais
            // 
            this.btnVermais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVermais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVermais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVermais.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVermais.BorderRadius = 40;
            this.btnVermais.BorderSize = 0;
            this.btnVermais.FlatAppearance.BorderSize = 0;
            this.btnVermais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVermais.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVermais.ForeColor = System.Drawing.Color.White;
            this.btnVermais.Location = new System.Drawing.Point(46, 412);
            this.btnVermais.Name = "btnVermais";
            this.btnVermais.Size = new System.Drawing.Size(150, 40);
            this.btnVermais.TabIndex = 6;
            this.btnVermais.Text = "Ver Mais";
            this.btnVermais.TextColor = System.Drawing.Color.White;
            this.btnVermais.UseVisualStyleBackColor = false;
            // 
            // UC_controlAtributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.pnlInfos);
            this.Controls.Add(this.pnlEscolhas);
            this.Controls.Add(this.pnlGraficos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_controlAtributos";
            this.Size = new System.Drawing.Size(1040, 658);
            this.Load += new System.EventHandler(this.UC_controlVariaveis_Load);
            this.pnlGraficos.ResumeLayout(false);
            this.pnlEscolhas.ResumeLayout(false);
            this.pnlEscolhas.PerformLayout();
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
        private ZedGraph.ZedGraphControl zedGraphC;
        private ZedGraph.ZedGraphControl zedGraphP;
        private Resources.techDataRadioButton rdbGraphC;
        private Resources.techDataRadioButton rdbGraphP;
        private System.Windows.Forms.Panel pnlEscolhas;
        private System.Windows.Forms.Label lblMediaTitle;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblDesvioTitle;
        private System.Windows.Forms.Label lblCPKTitle;
        private System.Windows.Forms.Panel pnlInfos;
        private System.Windows.Forms.Label lblInfos;
        private techDataButton btnVermais;
        private System.Windows.Forms.Label lblCpk;
        private System.Windows.Forms.Label lblDesvio;
    }
}
