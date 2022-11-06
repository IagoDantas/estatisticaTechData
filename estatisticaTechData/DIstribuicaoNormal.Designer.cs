namespace estatisticaTechData
{
    partial class frmDistribuicaoNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistribuicaoNormal));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pcbConfig = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnDistribuicao = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnPrevisaoDemanda = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pbcPerfil = new System.Windows.Forms.PictureBox();
            this.pnlGraficoPorcentagem = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGraficoPorcentagem = new System.Windows.Forms.Label();
            this.pnlHistorico = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.pnlLegenda = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGrafico = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.lblGráfico = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAcessoHistorico = new estatisticaTechData.techDataButton();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).BeginInit();
            this.pnlGraficoPorcentagem.SuspendLayout();
            this.pnlHistorico.SuspendLayout();
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
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(276, 683);
            this.pnlSideBar.TabIndex = 0;
            // 
            // pcbConfig
            // 
            this.pcbConfig.Image = ((System.Drawing.Image)(resources.GetObject("pcbConfig.Image")));
            this.pcbConfig.Location = new System.Drawing.Point(10, 635);
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
            this.btnConfig.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(1, 629);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(276, 54);
            this.btnConfig.TabIndex = 5;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.MouseEnter += new System.EventHandler(this.btnConfig_MouseEnter);
            this.btnConfig.MouseLeave += new System.EventHandler(this.btnConfig_MouseLeave);
            this.btnConfig.MouseHover += new System.EventHandler(this.btnConfig_MouseHover);
            // 
            // btnDistribuicao
            // 
            this.btnDistribuicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDistribuicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnDistribuicao.FlatAppearance.BorderSize = 0;
            this.btnDistribuicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistribuicao.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribuicao.Location = new System.Drawing.Point(0, 298);
            this.btnDistribuicao.Name = "btnDistribuicao";
            this.btnDistribuicao.Size = new System.Drawing.Size(276, 50);
            this.btnDistribuicao.TabIndex = 4;
            this.btnDistribuicao.Text = "Gráfico de distribuição normal";
            this.btnDistribuicao.UseVisualStyleBackColor = false;
            this.btnDistribuicao.MouseEnter += new System.EventHandler(this.btnDistribuicao_MouseEnter);
            this.btnDistribuicao.MouseLeave += new System.EventHandler(this.btnDistribuicao_MouseLeave);
            this.btnDistribuicao.MouseHover += new System.EventHandler(this.btnDistribuicao_MouseHover);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(-2, 438);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(276, 50);
            this.btnHistorico.TabIndex = 3;
            this.btnHistorico.Text = "Histórico de arquivos enviados";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.MouseEnter += new System.EventHandler(this.btnHistorico_MouseEnter);
            this.btnHistorico.MouseLeave += new System.EventHandler(this.btnHistorico_MouseLeave);
            this.btnHistorico.MouseHover += new System.EventHandler(this.btnHistorico_MouseHover);
            // 
            // btnPrevisaoDemanda
            // 
            this.btnPrevisaoDemanda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevisaoDemanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnPrevisaoDemanda.FlatAppearance.BorderSize = 0;
            this.btnPrevisaoDemanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevisaoDemanda.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevisaoDemanda.ForeColor = System.Drawing.Color.White;
            this.btnPrevisaoDemanda.Location = new System.Drawing.Point(-2, 368);
            this.btnPrevisaoDemanda.Name = "btnPrevisaoDemanda";
            this.btnPrevisaoDemanda.Size = new System.Drawing.Size(276, 50);
            this.btnPrevisaoDemanda.TabIndex = 2;
            this.btnPrevisaoDemanda.Text = "Previsão de demanda";
            this.btnPrevisaoDemanda.UseVisualStyleBackColor = false;
            this.btnPrevisaoDemanda.MouseEnter += new System.EventHandler(this.btnPrevisaoDemanda_MouseEnter);
            this.btnPrevisaoDemanda.MouseLeave += new System.EventHandler(this.btnPrevisaoDemanda_MouseLeave);
            this.btnPrevisaoDemanda.MouseHover += new System.EventHandler(this.btnPrevisaoDemanda_MouseHover);
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(-2, 228);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(276, 50);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnInicio_MouseEnter);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnInicio_MouseLeave);
            this.btnInicio.MouseHover += new System.EventHandler(this.btnInicio_MouseHover);
            // 
            // pbcPerfil
            // 
            this.pbcPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbcPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbcPerfil.Image")));
            this.pbcPerfil.Location = new System.Drawing.Point(86, 45);
            this.pbcPerfil.Name = "pbcPerfil";
            this.pbcPerfil.Size = new System.Drawing.Size(100, 100);
            this.pbcPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcPerfil.TabIndex = 0;
            this.pbcPerfil.TabStop = false;
            // 
            // pnlGraficoPorcentagem
            // 
            this.pnlGraficoPorcentagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlGraficoPorcentagem.Controls.Add(this.lblGraficoPorcentagem);
            this.pnlGraficoPorcentagem.Location = new System.Drawing.Point(323, 175);
            this.pnlGraficoPorcentagem.Name = "pnlGraficoPorcentagem";
            this.pnlGraficoPorcentagem.Padding = new System.Windows.Forms.Padding(30, 100, 0, 0);
            this.pnlGraficoPorcentagem.Size = new System.Drawing.Size(315, 293);
            this.pnlGraficoPorcentagem.TabIndex = 1;
            // 
            // lblGraficoPorcentagem
            // 
            this.lblGraficoPorcentagem.AutoSize = true;
            this.lblGraficoPorcentagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblGraficoPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGraficoPorcentagem.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficoPorcentagem.Location = new System.Drawing.Point(33, 100);
            this.lblGraficoPorcentagem.Name = "lblGraficoPorcentagem";
            this.lblGraficoPorcentagem.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblGraficoPorcentagem.Size = new System.Drawing.Size(261, 76);
            this.lblGraficoPorcentagem.TabIndex = 5;
            this.lblGraficoPorcentagem.Text = "Os gráficos com porcentagem seram gerados aqui.";
            // 
            // pnlHistorico
            // 
            this.pnlHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlHistorico.Controls.Add(this.lblHistorico);
            this.pnlHistorico.Controls.Add(this.btnAcessoHistorico);
            this.pnlHistorico.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlHistorico.Location = new System.Drawing.Point(323, 506);
            this.pnlHistorico.Name = "pnlHistorico";
            this.pnlHistorico.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlHistorico.Size = new System.Drawing.Size(315, 141);
            this.pnlHistorico.TabIndex = 2;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.Location = new System.Drawing.Point(3, 10);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHistorico.Size = new System.Drawing.Size(309, 56);
            this.lblHistorico.TabIndex = 0;
            this.lblHistorico.Text = "Histórico dos gráficos de distribuição normal anteriores:";
            this.lblHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLegenda
            // 
            this.pnlLegenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLegenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlLegenda.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlLegenda.Location = new System.Drawing.Point(683, 547);
            this.pnlLegenda.Name = "pnlLegenda";
            this.pnlLegenda.Size = new System.Drawing.Size(503, 100);
            this.pnlLegenda.TabIndex = 2;
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlGrafico.Location = new System.Drawing.Point(683, 175);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(503, 344);
            this.pnlGrafico.TabIndex = 2;
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblLegenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLegenda.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.Location = new System.Drawing.Point(694, 579);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(482, 37);
            this.lblLegenda.TabIndex = 0;
            this.lblLegenda.Text = "As legendas do gráfico seram geradas aqui.";
            // 
            // lblGráfico
            // 
            this.lblGráfico.AutoSize = true;
            this.lblGráfico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblGráfico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGráfico.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGráfico.Location = new System.Drawing.Point(707, 329);
            this.lblGráfico.Name = "lblGráfico";
            this.lblGráfico.Size = new System.Drawing.Size(456, 28);
            this.lblGráfico.TabIndex = 3;
            this.lblGráfico.Text = "Os gráficos de distribuição normal seram gerados aqui.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(600, 74);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(333, 53);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Distribuição Normal";
            // 
            // btnAcessoHistorico
            // 
            this.btnAcessoHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAcessoHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAcessoHistorico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAcessoHistorico.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAcessoHistorico.BorderRadius = 50;
            this.btnAcessoHistorico.BorderSize = 0;
            this.btnAcessoHistorico.FlatAppearance.BorderSize = 0;
            this.btnAcessoHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessoHistorico.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessoHistorico.ForeColor = System.Drawing.Color.White;
            this.btnAcessoHistorico.Location = new System.Drawing.Point(94, 69);
            this.btnAcessoHistorico.Name = "btnAcessoHistorico";
            this.btnAcessoHistorico.Size = new System.Drawing.Size(126, 47);
            this.btnAcessoHistorico.TabIndex = 5;
            this.btnAcessoHistorico.Text = "Acessar";
            this.btnAcessoHistorico.TextColor = System.Drawing.Color.White;
            this.btnAcessoHistorico.UseVisualStyleBackColor = false;
            // 
            // frmDistribuicaoNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblGráfico);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.pnlHistorico);
            this.Controls.Add(this.pnlLegenda);
            this.Controls.Add(this.pnlGrafico);
            this.Controls.Add(this.pnlGraficoPorcentagem);
            this.Controls.Add(this.pnlSideBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDistribuicaoNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuição Normal";
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).EndInit();
            this.pnlGraficoPorcentagem.ResumeLayout(false);
            this.pnlGraficoPorcentagem.PerformLayout();
            this.pnlHistorico.ResumeLayout(false);
            this.pnlHistorico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnDistribuicao;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnPrevisaoDemanda;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.PictureBox pbcPerfil;
        private System.Windows.Forms.FlowLayoutPanel pnlGraficoPorcentagem;
        private System.Windows.Forms.FlowLayoutPanel pnlHistorico;
        private System.Windows.Forms.FlowLayoutPanel pnlLegenda;
        private System.Windows.Forms.FlowLayoutPanel pnlGrafico;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.Label lblGráfico;
        private System.Windows.Forms.Label lblGraficoPorcentagem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.PictureBox pcbConfig;
        private System.Windows.Forms.Button btnConfig;
        private techDataButton btnAcessoHistorico;
    }
}