namespace estatisticaTechData
{
    partial class UC_HistoricoDistribuicaoNormal
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblRecentes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNome = new System.Windows.Forms.Panel();
            this.techDataButton1 = new estatisticaTechData.techDataButton();
            this.txtExemplo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumeroPagina = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(11, 11);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 61);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "←";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // lblRecentes
            // 
            this.lblRecentes.AutoSize = true;
            this.lblRecentes.Font = new System.Drawing.Font("Poppins", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.lblRecentes.Location = new System.Drawing.Point(77, 127);
            this.lblRecentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentes.Name = "lblRecentes";
            this.lblRecentes.Size = new System.Drawing.Size(125, 40);
            this.lblRecentes.TabIndex = 15;
            this.lblRecentes.Text = "Recentes";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.pnlNome);
            this.panel1.Location = new System.Drawing.Point(84, 177);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 446);
            this.panel1.TabIndex = 14;
            // 
            // pnlNome
            // 
            this.pnlNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNome.Controls.Add(this.techDataButton1);
            this.pnlNome.Controls.Add(this.txtExemplo);
            this.pnlNome.Location = new System.Drawing.Point(0, 62);
            this.pnlNome.Name = "pnlNome";
            this.pnlNome.Size = new System.Drawing.Size(856, 50);
            this.pnlNome.TabIndex = 15;
            // 
            // techDataButton1
            // 
            this.techDataButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.techDataButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.techDataButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.techDataButton1.BorderColor = System.Drawing.Color.PapayaWhip;
            this.techDataButton1.BorderRadius = 40;
            this.techDataButton1.BorderSize = 0;
            this.techDataButton1.FlatAppearance.BorderSize = 0;
            this.techDataButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.techDataButton1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techDataButton1.ForeColor = System.Drawing.Color.White;
            this.techDataButton1.Location = new System.Drawing.Point(692, 5);
            this.techDataButton1.Name = "techDataButton1";
            this.techDataButton1.Size = new System.Drawing.Size(150, 40);
            this.techDataButton1.TabIndex = 2;
            this.techDataButton1.Text = "Comparar";
            this.techDataButton1.TextColor = System.Drawing.Color.White;
            this.techDataButton1.UseVisualStyleBackColor = false;
            this.techDataButton1.Click += new System.EventHandler(this.techDataButton1_Click);
            // 
            // txtExemplo
            // 
            this.txtExemplo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtExemplo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtExemplo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExemplo.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExemplo.Location = new System.Drawing.Point(8, 8);
            this.txtExemplo.Name = "txtExemplo";
            this.txtExemplo.Size = new System.Drawing.Size(409, 29);
            this.txtExemplo.TabIndex = 1;
            this.txtExemplo.Text = "Gráfico Professor Marcos 15/09/2022 22:30";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(206, 68);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(635, 48);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Histórico de gráficos de distribuição normal:";
            // 
            // lblNumeroPagina
            // 
            this.lblNumeroPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroPagina.AutoSize = true;
            this.lblNumeroPagina.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPagina.Location = new System.Drawing.Point(772, 653);
            this.lblNumeroPagina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroPagina.Name = "lblNumeroPagina";
            this.lblNumeroPagina.Size = new System.Drawing.Size(30, 28);
            this.lblNumeroPagina.TabIndex = 17;
            this.lblNumeroPagina.Text = "1/1";
            // 
            // UC_HistoricoDistribuicaoNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblRecentes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumeroPagina);
            this.Name = "UC_HistoricoDistribuicaoNormal";
            this.Size = new System.Drawing.Size(980, 705);
            this.panel1.ResumeLayout(false);
            this.pnlNome.ResumeLayout(false);
            this.pnlNome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblRecentes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNome;
        private techDataButton btnDropdown;
        private techDataButton btnVisualizar;
        private techDataButton btnEditar;
        private System.Windows.Forms.TextBox txtExemplo;
        private techDataButton btnDeletar;
        private techDataButton btnComparar;
        private System.Windows.Forms.Label lblTitulo;
        private techDataButton btnAnterior;
        private System.Windows.Forms.Label lblNumeroPagina;
        private techDataButton btnProximaPagina;
        private techDataButton techDataButton1;
    }
}
