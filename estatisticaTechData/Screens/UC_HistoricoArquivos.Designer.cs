namespace estatisticaTechData
{
    partial class UC_HistoricoArquivos
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
            this.lblNumeroPagina = new System.Windows.Forms.Label();
            this.pnlArquivos = new System.Windows.Forms.Panel();
            this.pnlNome = new System.Windows.Forms.Panel();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.lblDataArquivo = new System.Windows.Forms.Label();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.lblRecentes = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnShow = new estatisticaTechData.techDataButton();
            this.btnDelete = new estatisticaTechData.techDataButton();
            this.btnRead = new estatisticaTechData.techDataButton();
            this.pnlArquivos.SuspendLayout();
            this.pnlNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroPagina
            // 
            this.lblNumeroPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroPagina.AutoSize = true;
            this.lblNumeroPagina.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPagina.Location = new System.Drawing.Point(815, 651);
            this.lblNumeroPagina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroPagina.Name = "lblNumeroPagina";
            this.lblNumeroPagina.Size = new System.Drawing.Size(30, 28);
            this.lblNumeroPagina.TabIndex = 18;
            this.lblNumeroPagina.Text = "1/1";
            // 
            // pnlArquivos
            // 
            this.pnlArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlArquivos.Controls.Add(this.pnlNome);
            this.pnlArquivos.Controls.Add(this.lblDataArquivo);
            this.pnlArquivos.Controls.Add(this.lblNomeArquivo);
            this.pnlArquivos.Location = new System.Drawing.Point(99, 182);
            this.pnlArquivos.Margin = new System.Windows.Forms.Padding(2);
            this.pnlArquivos.Name = "pnlArquivos";
            this.pnlArquivos.Size = new System.Drawing.Size(804, 430);
            this.pnlArquivos.TabIndex = 15;
            // 
            // pnlNome
            // 
            this.pnlNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNome.Controls.Add(this.TxtData);
            this.pnlNome.Controls.Add(this.btnShow);
            this.pnlNome.Controls.Add(this.btnDelete);
            this.pnlNome.Controls.Add(this.btnRead);
            this.pnlNome.Controls.Add(this.TxtNome);
            this.pnlNome.Location = new System.Drawing.Point(0, 64);
            this.pnlNome.Name = "pnlNome";
            this.pnlNome.Size = new System.Drawing.Size(801, 50);
            this.pnlNome.TabIndex = 16;
            // 
            // TxtData
            // 
            this.TxtData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.TxtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtData.Enabled = false;
            this.TxtData.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtData.Location = new System.Drawing.Point(255, 8);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(193, 29);
            this.TxtData.TabIndex = 7;
            // 
            // TxtNome
            // 
            this.TxtNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNome.Enabled = false;
            this.TxtNome.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(8, 8);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(241, 29);
            this.TxtNome.TabIndex = 1;
            // 
            // lblDataArquivo
            // 
            this.lblDataArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataArquivo.AutoSize = true;
            this.lblDataArquivo.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataArquivo.Location = new System.Drawing.Point(604, 6);
            this.lblDataArquivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataArquivo.Name = "lblDataArquivo";
            this.lblDataArquivo.Size = new System.Drawing.Size(68, 34);
            this.lblDataArquivo.TabIndex = 1;
            this.lblDataArquivo.Text = "Data:";
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArquivo.Location = new System.Drawing.Point(32, 6);
            this.lblNomeArquivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(78, 34);
            this.lblNomeArquivo.TabIndex = 0;
            this.lblNomeArquivo.Text = "Nome:";
            // 
            // lblRecentes
            // 
            this.lblRecentes.AutoSize = true;
            this.lblRecentes.Font = new System.Drawing.Font("Poppins", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.lblRecentes.Location = new System.Drawing.Point(101, 124);
            this.lblRecentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentes.Name = "lblRecentes";
            this.lblRecentes.Size = new System.Drawing.Size(125, 40);
            this.lblRecentes.TabIndex = 16;
            this.lblRecentes.Text = "Recentes";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(378, 67);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(314, 48);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Histórico de arquivos";
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnShow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnShow.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnShow.BorderRadius = 40;
            this.btnShow.BorderSize = 0;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(581, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(105, 40);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "...";
            this.btnShow.TextColor = System.Drawing.Color.White;
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Red;
            this.btnDelete.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnDelete.BorderRadius = 40;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(692, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnRead.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnRead.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnRead.BorderRadius = 40;
            this.btnRead.BorderSize = 0;
            this.btnRead.Enabled = false;
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(470, 3);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(105, 40);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Visualizar";
            this.btnRead.TextColor = System.Drawing.Color.White;
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Visible = false;
            // 
            // UC_HistoricoArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumeroPagina);
            this.Controls.Add(this.pnlArquivos);
            this.Controls.Add(this.lblRecentes);
            this.Name = "UC_HistoricoArquivos";
            this.Size = new System.Drawing.Size(1000, 720);
            this.Load += new System.EventHandler(this.UC_HistoricoArquivos_Load);
            this.pnlArquivos.ResumeLayout(false);
            this.pnlArquivos.PerformLayout();
            this.pnlNome.ResumeLayout(false);
            this.pnlNome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private techDataButton btnAnterior;
        private System.Windows.Forms.Label lblNumeroPagina;
        private techDataButton btnProximaPagina;
        private System.Windows.Forms.Panel pnlArquivos;
        private System.Windows.Forms.Label lblDataArquivo;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.Label lblRecentes;
        private techDataButton btnNovaCarga;
        private System.Windows.Forms.Panel pnlNome;
        private techDataButton btnShow;
        private techDataButton btnDelete;
        private techDataButton btnRead;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox TxtData;
    }
}
