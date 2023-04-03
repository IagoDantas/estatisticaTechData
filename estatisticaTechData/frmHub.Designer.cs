namespace estatisticaTechData
{
    partial class frmHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHub));
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnDistribuicao = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnPrevisaoDemanda = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pbcPerfil = new System.Windows.Forms.PictureBox();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pcbConfig = new System.Windows.Forms.PictureBox();
            this.uC_HistóricoDistribuicaoNormal1 = new estatisticaTechData.UC_HistóricoDistribuicaoNormal();
            this.uC_DistribuicaoNormalComparacao1 = new estatisticaTechData.Screens.UC_DistribuicaoNormalComparacao();
            this.uC_DistribuicaoNormal1 = new estatisticaTechData.Screens.UC_DistribuicaoNormal();
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 625);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(266, 54);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // btnDistribuicao
            // 
            this.btnDistribuicao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDistribuicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnDistribuicao.FlatAppearance.BorderSize = 0;
            this.btnDistribuicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistribuicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribuicao.Location = new System.Drawing.Point(0, 249);
            this.btnDistribuicao.Name = "btnDistribuicao";
            this.btnDistribuicao.Size = new System.Drawing.Size(266, 50);
            this.btnDistribuicao.TabIndex = 4;
            this.btnDistribuicao.Text = "Gráfico de distribuição normal";
            this.btnDistribuicao.UseVisualStyleBackColor = false;
            this.btnDistribuicao.Click += new System.EventHandler(this.btnDistribuicao_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(0, 389);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(266, 50);
            this.btnHistorico.TabIndex = 3;
            this.btnHistorico.Text = "Histórico de arquivos enviados";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnPrevisaoDemanda
            // 
            this.btnPrevisaoDemanda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevisaoDemanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnPrevisaoDemanda.FlatAppearance.BorderSize = 0;
            this.btnPrevisaoDemanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevisaoDemanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevisaoDemanda.ForeColor = System.Drawing.Color.White;
            this.btnPrevisaoDemanda.Location = new System.Drawing.Point(0, 319);
            this.btnPrevisaoDemanda.Name = "btnPrevisaoDemanda";
            this.btnPrevisaoDemanda.Size = new System.Drawing.Size(266, 64);
            this.btnPrevisaoDemanda.TabIndex = 2;
            this.btnPrevisaoDemanda.Text = "Previsão de demanda\r\n(Em breve)";
            this.btnPrevisaoDemanda.UseVisualStyleBackColor = false;
            this.btnPrevisaoDemanda.Click += new System.EventHandler(this.btnPrevisaoDemanda_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(3, 184);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(266, 50);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // pbcPerfil
            // 
            this.pbcPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbcPerfil.Image")));
            this.pbcPerfil.Location = new System.Drawing.Point(88, 47);
            this.pbcPerfil.Name = "pbcPerfil";
            this.pbcPerfil.Size = new System.Drawing.Size(100, 100);
            this.pbcPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcPerfil.TabIndex = 0;
            this.pbcPerfil.TabStop = false;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.pnlSideBar.Controls.Add(this.pcbConfig);
            this.pnlSideBar.Controls.Add(this.btnConfig);
            this.pnlSideBar.Controls.Add(this.btnDistribuicao);
            this.pnlSideBar.Controls.Add(this.btnHistorico);
            this.pnlSideBar.Controls.Add(this.btnPrevisaoDemanda);
            this.pnlSideBar.Controls.Add(this.btnInicio);
            this.pnlSideBar.Controls.Add(this.pbcPerfil);
            this.pnlSideBar.Location = new System.Drawing.Point(-1, -1);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(266, 682);
            this.pnlSideBar.TabIndex = 6;
            // 
            // pcbConfig
            // 
            this.pcbConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbConfig.Image = ((System.Drawing.Image)(resources.GetObject("pcbConfig.Image")));
            this.pcbConfig.Location = new System.Drawing.Point(12, 632);
            this.pcbConfig.Name = "pcbConfig";
            this.pcbConfig.Size = new System.Drawing.Size(40, 40);
            this.pcbConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbConfig.TabIndex = 8;
            this.pcbConfig.TabStop = false;
            // 
            // uC_HistóricoDistribuicaoNormal1
            // 
            this.uC_HistóricoDistribuicaoNormal1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_HistóricoDistribuicaoNormal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.uC_HistóricoDistribuicaoNormal1.Enabled = false;
            this.uC_HistóricoDistribuicaoNormal1.Location = new System.Drawing.Point(260, -1);
            this.uC_HistóricoDistribuicaoNormal1.Name = "uC_HistóricoDistribuicaoNormal1";
            this.uC_HistóricoDistribuicaoNormal1.Size = new System.Drawing.Size(1005, 679);
            this.uC_HistóricoDistribuicaoNormal1.TabIndex = 7;
            this.uC_HistóricoDistribuicaoNormal1.Visible = false;
            // 
            // uC_DistribuicaoNormalComparacao1
            // 
            this.uC_DistribuicaoNormalComparacao1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_DistribuicaoNormalComparacao1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.uC_DistribuicaoNormalComparacao1.Enabled = false;
            this.uC_DistribuicaoNormalComparacao1.Location = new System.Drawing.Point(260, -1);
            this.uC_DistribuicaoNormalComparacao1.Name = "uC_DistribuicaoNormalComparacao1";
            this.uC_DistribuicaoNormalComparacao1.Size = new System.Drawing.Size(1005, 682);
            this.uC_DistribuicaoNormalComparacao1.TabIndex = 8;
            this.uC_DistribuicaoNormalComparacao1.Visible = false;
            // 
            // uC_DistribuicaoNormal1
            // 
            this.uC_DistribuicaoNormal1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_DistribuicaoNormal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.uC_DistribuicaoNormal1.Location = new System.Drawing.Point(260, -1);
            this.uC_DistribuicaoNormal1.Name = "uC_DistribuicaoNormal1";
            this.uC_DistribuicaoNormal1.Size = new System.Drawing.Size(1005, 682);
            this.uC_DistribuicaoNormal1.TabIndex = 9;
            // 
            // frmHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.uC_DistribuicaoNormal1);
            this.Controls.Add(this.uC_DistribuicaoNormalComparacao1);
            this.Controls.Add(this.uC_HistóricoDistribuicaoNormal1);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "frmHub";
            this.Text = "frmHub";
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnDistribuicao;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnPrevisaoDemanda;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.PictureBox pbcPerfil;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.PictureBox pcbConfig;
        private UC_HistóricoDistribuicaoNormal uC_HistóricoDistribuicaoNormal1;
        private Screens.UC_DistribuicaoNormalComparacao uC_DistribuicaoNormalComparacao1;
        private Screens.UC_DistribuicaoNormal uC_DistribuicaoNormal1;
    }
}