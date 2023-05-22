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
            this.btnCEP = new System.Windows.Forms.Button();
            this.pcbConfig = new System.Windows.Forms.PictureBox();
            this.Tbc_Telas = new System.Windows.Forms.TabControl();
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
            this.btnConfig.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 625);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(266, 54);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnDistribuicao
            // 
            this.btnDistribuicao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDistribuicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnDistribuicao.FlatAppearance.BorderSize = 0;
            this.btnDistribuicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistribuicao.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribuicao.ForeColor = System.Drawing.Color.White;
            this.btnDistribuicao.Location = new System.Drawing.Point(0, 251);
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
            this.btnHistorico.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(0, 467);
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
            this.btnPrevisaoDemanda.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevisaoDemanda.ForeColor = System.Drawing.Color.White;
            this.btnPrevisaoDemanda.Location = new System.Drawing.Point(0, 321);
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
            this.btnInicio.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(0, 184);
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
            this.pbcPerfil.Location = new System.Drawing.Point(88, 25);
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
            this.pnlSideBar.Controls.Add(this.btnCEP);
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
            // btnCEP
            // 
            this.btnCEP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCEP.FlatAppearance.BorderSize = 0;
            this.btnCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCEP.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCEP.ForeColor = System.Drawing.Color.White;
            this.btnCEP.Location = new System.Drawing.Point(0, 400);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(266, 50);
            this.btnCEP.TabIndex = 9;
            this.btnCEP.Text = "Gráfico CEP";
            this.btnCEP.UseVisualStyleBackColor = true;
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
            // Tbc_Telas
            // 
            this.Tbc_Telas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbc_Telas.Location = new System.Drawing.Point(266, -1);
            this.Tbc_Telas.Name = "Tbc_Telas";
            this.Tbc_Telas.SelectedIndex = 0;
            this.Tbc_Telas.Size = new System.Drawing.Size(998, 682);
            this.Tbc_Telas.TabIndex = 8;
            this.Tbc_Telas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tbc_Telas_MouseDown);
            // 
            // frmHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Tbc_Telas);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHub";
            this.Text = "TechData";
            this.Load += new System.EventHandler(this.frmHub_Load);
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
        private System.Windows.Forms.TabControl Tbc_Telas;
        private System.Windows.Forms.Button btnCEP;
    }
}