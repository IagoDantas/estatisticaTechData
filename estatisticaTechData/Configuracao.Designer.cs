﻿namespace estatisticaTechData
{
    partial class frmConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracao));
            this.pbcPerfil = new System.Windows.Forms.PictureBox();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pcbConfig = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnDistribuicao = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnPrevisaoDemanda = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfig)).BeginInit();
            this.SuspendLayout();
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
            this.pnlSideBar.TabIndex = 1;
            // 
            // pcbConfig
            // 
            this.pcbConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
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
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.Black;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(1, 629);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(276, 54);
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
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "frmConfiguracao";
            this.Text = "Configuracao";
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcPerfil;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.PictureBox pcbConfig;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnDistribuicao;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnPrevisaoDemanda;
        private System.Windows.Forms.Button btnInicio;
    }
}