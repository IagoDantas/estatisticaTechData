namespace estatisticaTechData.Resources
{
    partial class frmHistoricoArquivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoricoArquivos));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pcbConfig = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnDistribuicao = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnPrevisaoDemanda = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pbcPerfil = new System.Windows.Forms.PictureBox();
            this.lklNovaCarga = new System.Windows.Forms.LinkLabel();
            this.pnlArquivos = new System.Windows.Forms.Panel();
            this.lblHistoricoArquivos = new System.Windows.Forms.Label();
            this.lblDataArquivo = new System.Windows.Forms.Label();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.lblRecentes = new System.Windows.Forms.Label();
            this.lblNumeroPagina = new System.Windows.Forms.Label();
            this.btnProximaPagina = new estatisticaTechData.techDataButton();
            this.btnNovaCarga = new estatisticaTechData.techDataButton();
            this.btnAnterior = new estatisticaTechData.techDataButton();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).BeginInit();
            this.pnlArquivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.pnlSideBar.Controls.Add(this.pcbConfig);
            this.pnlSideBar.Controls.Add(this.btnConfig);
            this.pnlSideBar.Controls.Add(this.btnDistribuicao);
            this.pnlSideBar.Controls.Add(this.btnHistorico);
            this.pnlSideBar.Controls.Add(this.btnPrevisaoDemanda);
            this.pnlSideBar.Controls.Add(this.btnInicio);
            this.pnlSideBar.Controls.Add(this.pbcPerfil);
            this.pnlSideBar.Location = new System.Drawing.Point(-2, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(276, 683);
            this.pnlSideBar.TabIndex = 1;
            // 
            // pcbConfig
            // 
            this.pcbConfig.Image = ((System.Drawing.Image)(resources.GetObject("pcbConfig.Image")));
            this.pcbConfig.Location = new System.Drawing.Point(9, 630);
            this.pcbConfig.Name = "pcbConfig";
            this.pcbConfig.Size = new System.Drawing.Size(40, 40);
            this.pcbConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbConfig.TabIndex = 6;
            this.pcbConfig.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(1, 625);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(276, 54);
            this.btnConfig.TabIndex = 5;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            this.btnConfig.MouseEnter += new System.EventHandler(this.btnConfig_MouseEnter);
            this.btnConfig.MouseLeave += new System.EventHandler(this.btnConfig_MouseLeave);
            // 
            // btnDistribuicao
            // 
            this.btnDistribuicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDistribuicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnDistribuicao.FlatAppearance.BorderSize = 0;
            this.btnDistribuicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistribuicao.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribuicao.ForeColor = System.Drawing.Color.White;
            this.btnDistribuicao.Location = new System.Drawing.Point(0, 294);
            this.btnDistribuicao.Name = "btnDistribuicao";
            this.btnDistribuicao.Size = new System.Drawing.Size(276, 50);
            this.btnDistribuicao.TabIndex = 4;
            this.btnDistribuicao.Text = "Gráfico de distribuição normal";
            this.btnDistribuicao.UseVisualStyleBackColor = false;
            this.btnDistribuicao.Click += new System.EventHandler(this.btnDistribuicao_Click);
            this.btnDistribuicao.MouseEnter += new System.EventHandler(this.btnDistribuicao_MouseEnter);
            this.btnDistribuicao.MouseLeave += new System.EventHandler(this.btnDistribuicao_MouseLeave);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHistorico.Location = new System.Drawing.Point(-2, 434);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(279, 50);
            this.btnHistorico.TabIndex = 3;
            this.btnHistorico.Text = "Histórico de arquivos enviados";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.MouseEnter += new System.EventHandler(this.btnHistorico_MouseEnter);
            this.btnHistorico.MouseLeave += new System.EventHandler(this.btnHistorico_MouseLeave);
            // 
            // btnPrevisaoDemanda
            // 
            this.btnPrevisaoDemanda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevisaoDemanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnPrevisaoDemanda.Enabled = false;
            this.btnPrevisaoDemanda.FlatAppearance.BorderSize = 0;
            this.btnPrevisaoDemanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevisaoDemanda.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevisaoDemanda.ForeColor = System.Drawing.Color.White;
            this.btnPrevisaoDemanda.Location = new System.Drawing.Point(-2, 364);
            this.btnPrevisaoDemanda.Name = "btnPrevisaoDemanda";
            this.btnPrevisaoDemanda.Size = new System.Drawing.Size(276, 64);
            this.btnPrevisaoDemanda.TabIndex = 2;
            this.btnPrevisaoDemanda.Text = "Previsão de demanda \r\n(Em breve)";
            this.btnPrevisaoDemanda.UseVisualStyleBackColor = false;
            this.btnPrevisaoDemanda.MouseEnter += new System.EventHandler(this.btnPrevisaoDemanda_MouseEnter);
            this.btnPrevisaoDemanda.MouseLeave += new System.EventHandler(this.btnPrevisaoDemanda_MouseLeave);
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(-2, 224);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(276, 50);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnInicio_MouseEnter);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnInicio_MouseLeave);
            // 
            // pbcPerfil
            // 
            this.pbcPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbcPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbcPerfil.Image")));
            this.pbcPerfil.Location = new System.Drawing.Point(86, 41);
            this.pbcPerfil.Name = "pbcPerfil";
            this.pbcPerfil.Size = new System.Drawing.Size(100, 100);
            this.pbcPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcPerfil.TabIndex = 0;
            this.pbcPerfil.TabStop = false;
            // 
            // lklNovaCarga
            // 
            this.lklNovaCarga.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lklNovaCarga.AutoSize = true;
            this.lklNovaCarga.Cursor = System.Windows.Forms.Cursors.Default;
            this.lklNovaCarga.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklNovaCarga.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklNovaCarga.LinkColor = System.Drawing.Color.Black;
            this.lklNovaCarga.Location = new System.Drawing.Point(743, 113);
            this.lklNovaCarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lklNovaCarga.Name = "lklNovaCarga";
            this.lklNovaCarga.Size = new System.Drawing.Size(108, 28);
            this.lklNovaCarga.TabIndex = 3;
            this.lklNovaCarga.TabStop = true;
            this.lklNovaCarga.Text = "Nova Carga";
            this.lklNovaCarga.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // pnlArquivos
            // 
            this.pnlArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlArquivos.Controls.Add(this.lblHistoricoArquivos);
            this.pnlArquivos.Controls.Add(this.lblDataArquivo);
            this.pnlArquivos.Controls.Add(this.lblNomeArquivo);
            this.pnlArquivos.Location = new System.Drawing.Point(382, 182);
            this.pnlArquivos.Margin = new System.Windows.Forms.Padding(2);
            this.pnlArquivos.Name = "pnlArquivos";
            this.pnlArquivos.Size = new System.Drawing.Size(804, 430);
            this.pnlArquivos.TabIndex = 4;
            // 
            // lblHistoricoArquivos
            // 
            this.lblHistoricoArquivos.AutoSize = true;
            this.lblHistoricoArquivos.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoricoArquivos.Location = new System.Drawing.Point(67, 203);
            this.lblHistoricoArquivos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistoricoArquivos.Name = "lblHistoricoArquivos";
            this.lblHistoricoArquivos.Size = new System.Drawing.Size(663, 48);
            this.lblHistoricoArquivos.TabIndex = 2;
            this.lblHistoricoArquivos.Text = "Os arquivos que ja foram utilizados ficam aqui";
            // 
            // lblDataArquivo
            // 
            this.lblDataArquivo.AutoSize = true;
            this.lblDataArquivo.Font = new System.Drawing.Font("Poppins Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataArquivo.Location = new System.Drawing.Point(604, 6);
            this.lblDataArquivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataArquivo.Name = "lblDataArquivo";
            this.lblDataArquivo.Size = new System.Drawing.Size(71, 34);
            this.lblDataArquivo.TabIndex = 1;
            this.lblDataArquivo.Text = "Data:";
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Font = new System.Drawing.Font("Poppins Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArquivo.Location = new System.Drawing.Point(32, 6);
            this.lblNomeArquivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(83, 34);
            this.lblNomeArquivo.TabIndex = 0;
            this.lblNomeArquivo.Text = "Nome:";
            // 
            // lblRecentes
            // 
            this.lblRecentes.AutoSize = true;
            this.lblRecentes.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.lblRecentes.Location = new System.Drawing.Point(375, 141);
            this.lblRecentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentes.Name = "lblRecentes";
            this.lblRecentes.Size = new System.Drawing.Size(128, 39);
            this.lblRecentes.TabIndex = 5;
            this.lblRecentes.Text = "Recentes";
            // 
            // lblNumeroPagina
            // 
            this.lblNumeroPagina.AutoSize = true;
            this.lblNumeroPagina.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPagina.Location = new System.Drawing.Point(946, 642);
            this.lblNumeroPagina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroPagina.Name = "lblNumeroPagina";
            this.lblNumeroPagina.Size = new System.Drawing.Size(30, 28);
            this.lblNumeroPagina.TabIndex = 7;
            this.lblNumeroPagina.Text = "1/1";
            // 
            // btnProximaPagina
            // 
            this.btnProximaPagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnProximaPagina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnProximaPagina.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnProximaPagina.BorderRadius = 45;
            this.btnProximaPagina.BorderSize = 0;
            this.btnProximaPagina.Enabled = false;
            this.btnProximaPagina.FlatAppearance.BorderSize = 0;
            this.btnProximaPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximaPagina.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaPagina.ForeColor = System.Drawing.Color.White;
            this.btnProximaPagina.Location = new System.Drawing.Point(980, 631);
            this.btnProximaPagina.Margin = new System.Windows.Forms.Padding(2);
            this.btnProximaPagina.Name = "btnProximaPagina";
            this.btnProximaPagina.Size = new System.Drawing.Size(115, 44);
            this.btnProximaPagina.TabIndex = 6;
            this.btnProximaPagina.Text = "Próxima";
            this.btnProximaPagina.TextColor = System.Drawing.Color.White;
            this.btnProximaPagina.UseVisualStyleBackColor = false;
            // 
            // btnNovaCarga
            // 
            this.btnNovaCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnNovaCarga.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnNovaCarga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovaCarga.BackgroundImage")));
            this.btnNovaCarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovaCarga.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNovaCarga.BorderRadius = 80;
            this.btnNovaCarga.BorderSize = 0;
            this.btnNovaCarga.FlatAppearance.BorderSize = 0;
            this.btnNovaCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaCarga.ForeColor = System.Drawing.Color.White;
            this.btnNovaCarga.Location = new System.Drawing.Point(753, 29);
            this.btnNovaCarga.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovaCarga.Name = "btnNovaCarga";
            this.btnNovaCarga.Size = new System.Drawing.Size(81, 88);
            this.btnNovaCarga.TabIndex = 2;
            this.btnNovaCarga.TextColor = System.Drawing.Color.White;
            this.btnNovaCarga.UseVisualStyleBackColor = false;
            this.btnNovaCarga.Click += new System.EventHandler(this.btnNovaCarga_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAnterior.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAnterior.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnterior.BorderRadius = 45;
            this.btnAnterior.BorderSize = 0;
            this.btnAnterior.Enabled = false;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(827, 631);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(115, 44);
            this.btnAnterior.TabIndex = 12;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextColor = System.Drawing.Color.White;
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // frmHistoricoArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblNumeroPagina);
            this.Controls.Add(this.btnProximaPagina);
            this.Controls.Add(this.lblRecentes);
            this.Controls.Add(this.pnlArquivos);
            this.Controls.Add(this.lklNovaCarga);
            this.Controls.Add(this.btnNovaCarga);
            this.Controls.Add(this.pnlSideBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistoricoArquivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechData";
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).EndInit();
            this.pnlArquivos.ResumeLayout(false);
            this.pnlArquivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.PictureBox pcbConfig;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnDistribuicao;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnPrevisaoDemanda;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.PictureBox pbcPerfil;
        private techDataButton btnNovaCarga;
        private System.Windows.Forms.LinkLabel lklNovaCarga;
        private System.Windows.Forms.Panel pnlArquivos;
        private System.Windows.Forms.Label lblRecentes;
        private System.Windows.Forms.Label lblDataArquivo;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.Label lblHistoricoArquivos;
        private techDataButton btnProximaPagina;
        private System.Windows.Forms.Label lblNumeroPagina;
        private techDataButton btnAnterior;
    }
}