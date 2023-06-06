namespace estatisticaTechData.Screens
{
    partial class UC_controlVariaveis
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
            this.zedAmplitude = new ZedGraph.ZedGraphControl();
            this.zedMedias = new ZedGraph.ZedGraphControl();
            this.zedControle = new ZedGraph.ZedGraphControl();
            this.pnlEscolhas = new System.Windows.Forms.Panel();
            this.rdbAmplitudes = new estatisticaTechData.Resources.techDataRadioButton();
            this.rdbMedia = new estatisticaTechData.Resources.techDataRadioButton();
            this.rdbControle = new estatisticaTechData.Resources.techDataRadioButton();
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
            this.lblTitulo.Location = new System.Drawing.Point(293, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(503, 51);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Gráfico de Controle de Variáveis";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraficos
            // 
            this.pnlGraficos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlGraficos.Controls.Add(this.zedAmplitude);
            this.pnlGraficos.Controls.Add(this.zedMedias);
            this.pnlGraficos.Controls.Add(this.zedControle);
            this.pnlGraficos.Location = new System.Drawing.Point(271, 116);
            this.pnlGraficos.Name = "pnlGraficos";
            this.pnlGraficos.Size = new System.Drawing.Size(742, 368);
            this.pnlGraficos.TabIndex = 14;
            // 
            // zedAmplitude
            // 
            this.zedAmplitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedAmplitude.Enabled = false;
            this.zedAmplitude.Location = new System.Drawing.Point(0, 0);
            this.zedAmplitude.Name = "zedAmplitude";
            this.zedAmplitude.ScrollGrace = 0D;
            this.zedAmplitude.ScrollMaxX = 0D;
            this.zedAmplitude.ScrollMaxY = 0D;
            this.zedAmplitude.ScrollMaxY2 = 0D;
            this.zedAmplitude.ScrollMinX = 0D;
            this.zedAmplitude.ScrollMinY = 0D;
            this.zedAmplitude.ScrollMinY2 = 0D;
            this.zedAmplitude.Size = new System.Drawing.Size(742, 368);
            this.zedAmplitude.TabIndex = 2;
            this.zedAmplitude.UseExtendedPrintDialog = true;
            this.zedAmplitude.Visible = false;
            // 
            // zedMedias
            // 
            this.zedMedias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedMedias.Enabled = false;
            this.zedMedias.Location = new System.Drawing.Point(0, 0);
            this.zedMedias.Name = "zedMedias";
            this.zedMedias.ScrollGrace = 0D;
            this.zedMedias.ScrollMaxX = 0D;
            this.zedMedias.ScrollMaxY = 0D;
            this.zedMedias.ScrollMaxY2 = 0D;
            this.zedMedias.ScrollMinX = 0D;
            this.zedMedias.ScrollMinY = 0D;
            this.zedMedias.ScrollMinY2 = 0D;
            this.zedMedias.Size = new System.Drawing.Size(742, 368);
            this.zedMedias.TabIndex = 1;
            this.zedMedias.UseExtendedPrintDialog = true;
            this.zedMedias.Visible = false;
            // 
            // zedControle
            // 
            this.zedControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedControle.Enabled = false;
            this.zedControle.Location = new System.Drawing.Point(0, 0);
            this.zedControle.Name = "zedControle";
            this.zedControle.ScrollGrace = 0D;
            this.zedControle.ScrollMaxX = 0D;
            this.zedControle.ScrollMaxY = 0D;
            this.zedControle.ScrollMaxY2 = 0D;
            this.zedControle.ScrollMinX = 0D;
            this.zedControle.ScrollMinY = 0D;
            this.zedControle.ScrollMinY2 = 0D;
            this.zedControle.Size = new System.Drawing.Size(742, 368);
            this.zedControle.TabIndex = 0;
            this.zedControle.UseExtendedPrintDialog = true;
            this.zedControle.Visible = false;
            // 
            // pnlEscolhas
            // 
            this.pnlEscolhas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEscolhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlEscolhas.Controls.Add(this.rdbAmplitudes);
            this.pnlEscolhas.Controls.Add(this.rdbMedia);
            this.pnlEscolhas.Controls.Add(this.rdbControle);
            this.pnlEscolhas.Location = new System.Drawing.Point(271, 504);
            this.pnlEscolhas.Name = "pnlEscolhas";
            this.pnlEscolhas.Size = new System.Drawing.Size(742, 113);
            this.pnlEscolhas.TabIndex = 64;
            // 
            // rdbAmplitudes
            // 
            this.rdbAmplitudes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbAmplitudes.AutoSize = true;
            this.rdbAmplitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbAmplitudes.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbAmplitudes.CheckedColor = System.Drawing.Color.White;
            this.rdbAmplitudes.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAmplitudes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbAmplitudes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbAmplitudes.Location = new System.Drawing.Point(473, 37);
            this.rdbAmplitudes.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbAmplitudes.Name = "rdbAmplitudes";
            this.rdbAmplitudes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbAmplitudes.Size = new System.Drawing.Size(258, 38);
            this.rdbAmplitudes.TabIndex = 65;
            this.rdbAmplitudes.Text = "Gráfico de Amplitudes";
            this.rdbAmplitudes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdbAmplitudes.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbAmplitudes.UseVisualStyleBackColor = false;
            this.rdbAmplitudes.CheckedChanged += new System.EventHandler(this.rdbAmplitudes_CheckedChanged);
            // 
            // rdbMedia
            // 
            this.rdbMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbMedia.AutoSize = true;
            this.rdbMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbMedia.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbMedia.CheckedColor = System.Drawing.Color.White;
            this.rdbMedia.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbMedia.Location = new System.Drawing.Point(250, 37);
            this.rdbMedia.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbMedia.Name = "rdbMedia";
            this.rdbMedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbMedia.Size = new System.Drawing.Size(217, 38);
            this.rdbMedia.TabIndex = 63;
            this.rdbMedia.Text = "Gráfico de Médias";
            this.rdbMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdbMedia.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbMedia.UseVisualStyleBackColor = false;
            this.rdbMedia.CheckedChanged += new System.EventHandler(this.rdbMedia_CheckedChanged);
            // 
            // rdbControle
            // 
            this.rdbControle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbControle.AutoSize = true;
            this.rdbControle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbControle.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbControle.CheckedColor = System.Drawing.Color.White;
            this.rdbControle.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbControle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbControle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbControle.Location = new System.Drawing.Point(14, 37);
            this.rdbControle.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbControle.Name = "rdbControle";
            this.rdbControle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbControle.Size = new System.Drawing.Size(230, 38);
            this.rdbControle.TabIndex = 64;
            this.rdbControle.Text = "Gráfico de Controle";
            this.rdbControle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdbControle.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbControle.UseVisualStyleBackColor = false;
            this.rdbControle.CheckedChanged += new System.EventHandler(this.rdbControle_CheckedChanged);
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
            // UC_controlVariaveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.pnlInfos);
            this.Controls.Add(this.pnlEscolhas);
            this.Controls.Add(this.pnlGraficos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_controlVariaveis";
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
        private ZedGraph.ZedGraphControl zedControle;
        private ZedGraph.ZedGraphControl zedAmplitude;
        private ZedGraph.ZedGraphControl zedMedias;
        private Resources.techDataRadioButton rdbMedia;
        private Resources.techDataRadioButton rdbControle;
        private Resources.techDataRadioButton rdbAmplitudes;
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
