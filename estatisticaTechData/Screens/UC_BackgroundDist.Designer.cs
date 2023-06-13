namespace estatisticaTechData.Screens
{
    partial class UC_BackgroundDist
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
            estatisticaTechData.techDataButton btnPercentis;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.dgvTeste = new System.Windows.Forms.DataGridView();
            this.lblQuartis = new System.Windows.Forms.Label();
            this.lblPercentis = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPercentil = new System.Windows.Forms.MaskedTextBox();
            this.lblDesvioPadrao = new System.Windows.Forms.Label();
            this.lblDipersao = new System.Windows.Forms.Label();
            this.lblCoeficientePercentilicoCurtose = new System.Windows.Forms.Label();
            this.lblVariancia = new System.Windows.Forms.Label();
            this.lblCoeficienteAssimetria = new System.Windows.Forms.Label();
            btnPercentis = new estatisticaTechData.techDataButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPercentis
            // 
            btnPercentis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnPercentis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnPercentis.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnPercentis.BorderRadius = 50;
            btnPercentis.BorderSize = 0;
            btnPercentis.FlatAppearance.BorderSize = 0;
            btnPercentis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPercentis.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPercentis.ForeColor = System.Drawing.Color.White;
            btnPercentis.Location = new System.Drawing.Point(719, 625);
            btnPercentis.Name = "btnPercentis";
            btnPercentis.Size = new System.Drawing.Size(126, 47);
            btnPercentis.TabIndex = 14;
            btnPercentis.Text = "Percentis";
            btnPercentis.TextColor = System.Drawing.Color.White;
            btnPercentis.UseVisualStyleBackColor = false;
            btnPercentis.Click += new System.EventHandler(this.btnPercentis_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.Color.Black;
            this.lblMedia.Location = new System.Drawing.Point(714, 53);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(57, 28);
            this.lblMedia.TabIndex = 1;
            this.lblMedia.Text = "label1";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModa.ForeColor = System.Drawing.Color.Black;
            this.lblModa.Location = new System.Drawing.Point(714, 125);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(61, 28);
            this.lblModa.TabIndex = 2;
            this.lblModa.Text = "label2";
            // 
            // lblMediana
            // 
            this.lblMediana.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMediana.AutoSize = true;
            this.lblMediana.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediana.ForeColor = System.Drawing.Color.Black;
            this.lblMediana.Location = new System.Drawing.Point(1007, 53);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(61, 28);
            this.lblMediana.TabIndex = 3;
            this.lblMediana.Text = "label3";
            // 
            // dgvTeste
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTeste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTeste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTeste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.dgvTeste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeste.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeste.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTeste.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.dgvTeste.Location = new System.Drawing.Point(22, 27);
            this.dgvTeste.Name = "dgvTeste";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeste.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTeste.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTeste.Size = new System.Drawing.Size(661, 620);
            this.dgvTeste.TabIndex = 5;
            this.dgvTeste.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTeste_CellFormatting);
            // 
            // lblQuartis
            // 
            this.lblQuartis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuartis.AutoSize = true;
            this.lblQuartis.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuartis.ForeColor = System.Drawing.Color.Black;
            this.lblQuartis.Location = new System.Drawing.Point(1007, 134);
            this.lblQuartis.Name = "lblQuartis";
            this.lblQuartis.Size = new System.Drawing.Size(61, 28);
            this.lblQuartis.TabIndex = 11;
            this.lblQuartis.Text = "label3";
            // 
            // lblPercentis
            // 
            this.lblPercentis.AutoSize = true;
            this.lblPercentis.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentis.ForeColor = System.Drawing.Color.Black;
            this.lblPercentis.Location = new System.Drawing.Point(714, 589);
            this.lblPercentis.Name = "lblPercentis";
            this.lblPercentis.Size = new System.Drawing.Size(61, 28);
            this.lblPercentis.TabIndex = 13;
            this.lblPercentis.Text = "label3";
            this.lblPercentis.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(714, 514);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(336, 28);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Digite o percentil que você deseja saber:";
            // 
            // txtPercentil
            // 
            this.txtPercentil.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentil.Location = new System.Drawing.Point(719, 559);
            this.txtPercentil.Mask = "000";
            this.txtPercentil.Name = "txtPercentil";
            this.txtPercentil.Size = new System.Drawing.Size(260, 24);
            this.txtPercentil.TabIndex = 18;
            // 
            // lblDesvioPadrao
            // 
            this.lblDesvioPadrao.AutoSize = true;
            this.lblDesvioPadrao.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesvioPadrao.ForeColor = System.Drawing.Color.Black;
            this.lblDesvioPadrao.Location = new System.Drawing.Point(714, 209);
            this.lblDesvioPadrao.Name = "lblDesvioPadrao";
            this.lblDesvioPadrao.Size = new System.Drawing.Size(52, 28);
            this.lblDesvioPadrao.TabIndex = 20;
            this.lblDesvioPadrao.Text = "label";
            // 
            // lblDipersao
            // 
            this.lblDipersao.AutoSize = true;
            this.lblDipersao.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDipersao.ForeColor = System.Drawing.Color.Black;
            this.lblDipersao.Location = new System.Drawing.Point(714, 370);
            this.lblDipersao.Name = "lblDipersao";
            this.lblDipersao.Size = new System.Drawing.Size(52, 28);
            this.lblDipersao.TabIndex = 22;
            this.lblDipersao.Text = "label";
            // 
            // lblCoeficientePercentilicoCurtose
            // 
            this.lblCoeficientePercentilicoCurtose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCoeficientePercentilicoCurtose.AutoSize = true;
            this.lblCoeficientePercentilicoCurtose.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoeficientePercentilicoCurtose.ForeColor = System.Drawing.Color.Black;
            this.lblCoeficientePercentilicoCurtose.Location = new System.Drawing.Point(1007, 272);
            this.lblCoeficientePercentilicoCurtose.Name = "lblCoeficientePercentilicoCurtose";
            this.lblCoeficientePercentilicoCurtose.Size = new System.Drawing.Size(52, 28);
            this.lblCoeficientePercentilicoCurtose.TabIndex = 26;
            this.lblCoeficientePercentilicoCurtose.Text = "label";
            // 
            // lblVariancia
            // 
            this.lblVariancia.AutoSize = true;
            this.lblVariancia.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariancia.ForeColor = System.Drawing.Color.Black;
            this.lblVariancia.Location = new System.Drawing.Point(714, 291);
            this.lblVariancia.Name = "lblVariancia";
            this.lblVariancia.Size = new System.Drawing.Size(52, 28);
            this.lblVariancia.TabIndex = 28;
            this.lblVariancia.Text = "label";
            // 
            // lblCoeficienteAssimetria
            // 
            this.lblCoeficienteAssimetria.AutoSize = true;
            this.lblCoeficienteAssimetria.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoeficienteAssimetria.ForeColor = System.Drawing.Color.Black;
            this.lblCoeficienteAssimetria.Location = new System.Drawing.Point(714, 446);
            this.lblCoeficienteAssimetria.Name = "lblCoeficienteAssimetria";
            this.lblCoeficienteAssimetria.Size = new System.Drawing.Size(52, 28);
            this.lblCoeficienteAssimetria.TabIndex = 30;
            this.lblCoeficienteAssimetria.Text = "label";
            // 
            // UC_BackgroundDist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.lblCoeficienteAssimetria);
            this.Controls.Add(this.lblVariancia);
            this.Controls.Add(this.lblCoeficientePercentilicoCurtose);
            this.Controls.Add(this.lblDipersao);
            this.Controls.Add(this.lblDesvioPadrao);
            this.Controls.Add(this.txtPercentil);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(btnPercentis);
            this.Controls.Add(this.lblPercentis);
            this.Controls.Add(this.lblQuartis);
            this.Controls.Add(this.dgvTeste);
            this.Controls.Add(this.lblMediana);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.lblMedia);
            this.Name = "UC_BackgroundDist";
            this.Size = new System.Drawing.Size(1264, 681);
            this.Load += new System.EventHandler(this.UC_BackgroundDist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.DataGridView dgvTeste;
        private System.Windows.Forms.Label lblQuartis;
        private System.Windows.Forms.Label lblPercentis;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox txtPercentil;
        private System.Windows.Forms.Label lblDesvioPadrao;
        private System.Windows.Forms.Label lblDipersao;
        private System.Windows.Forms.Label lblCoeficientePercentilicoCurtose;
        private System.Windows.Forms.Label lblVariancia;
        private System.Windows.Forms.Label lblCoeficienteAssimetria;
    }
}