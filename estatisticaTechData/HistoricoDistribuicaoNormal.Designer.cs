namespace estatisticaTechData
{
    partial class frmHistoricoDistNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoricoDistNormal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pcbConfig = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnDistribuicao = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnPrevisaoDemanda = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pbcPerfil = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecentes = new System.Windows.Forms.Label();
            this.lblNumeroPagina = new System.Windows.Forms.Label();
            this.btnProximaPagina = new estatisticaTechData.techDataButton();
            this.btnAnterior = new estatisticaTechData.techDataButton();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(485, 59);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(635, 48);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Histórico de graficos de distribuição normal:";
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
            this.pnlSideBar.Location = new System.Drawing.Point(1, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(276, 683);
            this.pnlSideBar.TabIndex = 5;
            // 
            // pcbConfig
            // 
            this.pcbConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
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
            this.btnConfig.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(1, 629);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(275, 54);
            this.btnConfig.TabIndex = 5;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // btnDistribuicao
            // 
            this.btnDistribuicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDistribuicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnDistribuicao.FlatAppearance.BorderSize = 0;
            this.btnDistribuicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistribuicao.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribuicao.ForeColor = System.Drawing.Color.White;
            this.btnDistribuicao.Location = new System.Drawing.Point(0, 298);
            this.btnDistribuicao.Name = "btnDistribuicao";
            this.btnDistribuicao.Size = new System.Drawing.Size(276, 50);
            this.btnDistribuicao.TabIndex = 4;
            this.btnDistribuicao.Text = "Gráfico de distribuição normal";
            this.btnDistribuicao.UseVisualStyleBackColor = false;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.Black;
            this.btnHistorico.Location = new System.Drawing.Point(-2, 438);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(278, 50);
            this.btnHistorico.TabIndex = 3;
            this.btnHistorico.Text = "Histórico de arquivos enviados";
            this.btnHistorico.UseVisualStyleBackColor = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.panel1.Location = new System.Drawing.Point(351, 166);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 446);
            this.panel1.TabIndex = 7;
            // 
            // lblRecentes
            // 
            this.lblRecentes.AutoSize = true;
            this.lblRecentes.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.lblRecentes.Location = new System.Drawing.Point(344, 116);
            this.lblRecentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentes.Name = "lblRecentes";
            this.lblRecentes.Size = new System.Drawing.Size(128, 39);
            this.lblRecentes.TabIndex = 8;
            this.lblRecentes.Text = "Recentes";
            // 
            // lblNumeroPagina
            // 
            this.lblNumeroPagina.AutoSize = true;
            this.lblNumeroPagina.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPagina.Location = new System.Drawing.Point(1039, 642);
            this.lblNumeroPagina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroPagina.Name = "lblNumeroPagina";
            this.lblNumeroPagina.Size = new System.Drawing.Size(30, 28);
            this.lblNumeroPagina.TabIndex = 10;
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
            this.btnProximaPagina.Location = new System.Drawing.Point(1073, 631);
            this.btnProximaPagina.Margin = new System.Windows.Forms.Padding(2);
            this.btnProximaPagina.Name = "btnProximaPagina";
            this.btnProximaPagina.Size = new System.Drawing.Size(115, 44);
            this.btnProximaPagina.TabIndex = 9;
            this.btnProximaPagina.Text = "Próxima";
            this.btnProximaPagina.TextColor = System.Drawing.Color.White;
            this.btnProximaPagina.UseVisualStyleBackColor = false;
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
            this.btnAnterior.Location = new System.Drawing.Point(920, 631);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(115, 44);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextColor = System.Drawing.Color.White;
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // frmHistoricoDistNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblNumeroPagina);
            this.Controls.Add(this.btnProximaPagina);
            this.Controls.Add(this.lblRecentes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlSideBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHistoricoDistNormal";
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.PictureBox pcbConfig;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnDistribuicao;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnPrevisaoDemanda;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.PictureBox pbcPerfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRecentes;
        private System.Windows.Forms.Label lblNumeroPagina;
        private techDataButton btnProximaPagina;
        private techDataButton btnAnterior;
    }
}