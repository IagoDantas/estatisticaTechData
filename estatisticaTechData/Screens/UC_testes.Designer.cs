namespace estatisticaTechData.Screens
{
    partial class UC_testes
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
            estatisticaTechData.techDataButton btnGraphMedia;
            estatisticaTechData.techDataButton btnGraphControl;
            estatisticaTechData.techDataButton btnCoeficienteAssimetria;
            estatisticaTechData.techDataButton btnVariancia;
            estatisticaTechData.techDataButton btnCoeficientePercentilicoCurtose;
            estatisticaTechData.techDataButton btnDispersao;
            estatisticaTechData.techDataButton btnDesvioPadrao;
            estatisticaTechData.techDataButton btnPercentis;
            estatisticaTechData.techDataButton btnQuartis;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            estatisticaTechData.techDataButton btnGraficoDistNormal;
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
            this.btnMedia = new estatisticaTechData.techDataButton();
            this.btnModa = new estatisticaTechData.techDataButton();
            this.btnMediana = new estatisticaTechData.techDataButton();
            btnGraphMedia = new estatisticaTechData.techDataButton();
            btnGraphControl = new estatisticaTechData.techDataButton();
            btnCoeficienteAssimetria = new estatisticaTechData.techDataButton();
            btnVariancia = new estatisticaTechData.techDataButton();
            btnCoeficientePercentilicoCurtose = new estatisticaTechData.techDataButton();
            btnDispersao = new estatisticaTechData.techDataButton();
            btnDesvioPadrao = new estatisticaTechData.techDataButton();
            btnPercentis = new estatisticaTechData.techDataButton();
            btnQuartis = new estatisticaTechData.techDataButton();
            btnGraficoDistNormal = new estatisticaTechData.techDataButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGraphMedia
            // 
            btnGraphMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnGraphMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnGraphMedia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnGraphMedia.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnGraphMedia.BorderRadius = 50;
            btnGraphMedia.BorderSize = 0;
            btnGraphMedia.FlatAppearance.BorderSize = 0;
            btnGraphMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGraphMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnGraphMedia.ForeColor = System.Drawing.Color.White;
            btnGraphMedia.Location = new System.Drawing.Point(1101, 417);
            btnGraphMedia.Name = "btnGraphMedia";
            btnGraphMedia.Size = new System.Drawing.Size(126, 47);
            btnGraphMedia.TabIndex = 32;
            btnGraphMedia.Text = "Gráfico de Média";
            btnGraphMedia.TextColor = System.Drawing.Color.White;
            btnGraphMedia.UseVisualStyleBackColor = false;
            btnGraphMedia.Click += new System.EventHandler(this.btnGraphMedia_Click);
            // 
            // btnGraphControl
            // 
            btnGraphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnGraphControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnGraphControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnGraphControl.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnGraphControl.BorderRadius = 50;
            btnGraphControl.BorderSize = 0;
            btnGraphControl.FlatAppearance.BorderSize = 0;
            btnGraphControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGraphControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnGraphControl.ForeColor = System.Drawing.Color.White;
            btnGraphControl.Location = new System.Drawing.Point(1101, 479);
            btnGraphControl.Name = "btnGraphControl";
            btnGraphControl.Size = new System.Drawing.Size(126, 47);
            btnGraphControl.TabIndex = 31;
            btnGraphControl.Text = "Gráfico de Controle";
            btnGraphControl.TextColor = System.Drawing.Color.White;
            btnGraphControl.UseVisualStyleBackColor = false;
            btnGraphControl.Click += new System.EventHandler(this.graphControl_Click);
            // 
            // btnCoeficienteAssimetria
            // 
            btnCoeficienteAssimetria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnCoeficienteAssimetria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnCoeficienteAssimetria.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnCoeficienteAssimetria.BorderRadius = 50;
            btnCoeficienteAssimetria.BorderSize = 0;
            btnCoeficienteAssimetria.FlatAppearance.BorderSize = 0;
            btnCoeficienteAssimetria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCoeficienteAssimetria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCoeficienteAssimetria.ForeColor = System.Drawing.Color.White;
            btnCoeficienteAssimetria.Location = new System.Drawing.Point(926, 111);
            btnCoeficienteAssimetria.Name = "btnCoeficienteAssimetria";
            btnCoeficienteAssimetria.Size = new System.Drawing.Size(126, 47);
            btnCoeficienteAssimetria.TabIndex = 29;
            btnCoeficienteAssimetria.Text = "Coeficiente de Assimetria";
            btnCoeficienteAssimetria.TextColor = System.Drawing.Color.White;
            btnCoeficienteAssimetria.UseVisualStyleBackColor = false;
            btnCoeficienteAssimetria.Click += new System.EventHandler(this.btnCoeficienteAssimetria_Click);
            // 
            // btnVariancia
            // 
            btnVariancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnVariancia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnVariancia.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnVariancia.BorderRadius = 50;
            btnVariancia.BorderSize = 0;
            btnVariancia.FlatAppearance.BorderSize = 0;
            btnVariancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVariancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnVariancia.ForeColor = System.Drawing.Color.White;
            btnVariancia.Location = new System.Drawing.Point(514, 533);
            btnVariancia.Name = "btnVariancia";
            btnVariancia.Size = new System.Drawing.Size(126, 47);
            btnVariancia.TabIndex = 27;
            btnVariancia.Text = "Variância";
            btnVariancia.TextColor = System.Drawing.Color.White;
            btnVariancia.UseVisualStyleBackColor = false;
            btnVariancia.Click += new System.EventHandler(this.btnVariancia_Click);
            // 
            // btnCoeficientePercentilicoCurtose
            // 
            btnCoeficientePercentilicoCurtose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnCoeficientePercentilicoCurtose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnCoeficientePercentilicoCurtose.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnCoeficientePercentilicoCurtose.BorderRadius = 50;
            btnCoeficientePercentilicoCurtose.BorderSize = 0;
            btnCoeficientePercentilicoCurtose.FlatAppearance.BorderSize = 0;
            btnCoeficientePercentilicoCurtose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCoeficientePercentilicoCurtose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCoeficientePercentilicoCurtose.ForeColor = System.Drawing.Color.White;
            btnCoeficientePercentilicoCurtose.Location = new System.Drawing.Point(917, 27);
            btnCoeficientePercentilicoCurtose.Name = "btnCoeficientePercentilicoCurtose";
            btnCoeficientePercentilicoCurtose.Size = new System.Drawing.Size(126, 47);
            btnCoeficientePercentilicoCurtose.TabIndex = 25;
            btnCoeficientePercentilicoCurtose.Text = "Coeficiente % curtose";
            btnCoeficientePercentilicoCurtose.TextColor = System.Drawing.Color.White;
            btnCoeficientePercentilicoCurtose.UseVisualStyleBackColor = false;
            btnCoeficientePercentilicoCurtose.Click += new System.EventHandler(this.btnCoeficientePercenCurtose_Click);
            // 
            // btnDispersao
            // 
            btnDispersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnDispersao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnDispersao.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnDispersao.BorderRadius = 50;
            btnDispersao.BorderSize = 0;
            btnDispersao.FlatAppearance.BorderSize = 0;
            btnDispersao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDispersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDispersao.ForeColor = System.Drawing.Color.White;
            btnDispersao.Location = new System.Drawing.Point(514, 595);
            btnDispersao.Name = "btnDispersao";
            btnDispersao.Size = new System.Drawing.Size(126, 47);
            btnDispersao.TabIndex = 21;
            btnDispersao.Text = "Dispersão";
            btnDispersao.TextColor = System.Drawing.Color.White;
            btnDispersao.UseVisualStyleBackColor = false;
            btnDispersao.Click += new System.EventHandler(this.btnDispersao_Click);
            // 
            // btnDesvioPadrao
            // 
            btnDesvioPadrao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnDesvioPadrao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnDesvioPadrao.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnDesvioPadrao.BorderRadius = 50;
            btnDesvioPadrao.BorderSize = 0;
            btnDesvioPadrao.FlatAppearance.BorderSize = 0;
            btnDesvioPadrao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDesvioPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDesvioPadrao.ForeColor = System.Drawing.Color.White;
            btnDesvioPadrao.Location = new System.Drawing.Point(514, 470);
            btnDesvioPadrao.Name = "btnDesvioPadrao";
            btnDesvioPadrao.Size = new System.Drawing.Size(126, 47);
            btnDesvioPadrao.TabIndex = 19;
            btnDesvioPadrao.Text = "Desvio Padrão";
            btnDesvioPadrao.TextColor = System.Drawing.Color.White;
            btnDesvioPadrao.UseVisualStyleBackColor = false;
            btnDesvioPadrao.Click += new System.EventHandler(this.btnDesvioPadrao_Click);
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
            btnPercentis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPercentis.ForeColor = System.Drawing.Color.White;
            btnPercentis.Location = new System.Drawing.Point(514, 417);
            btnPercentis.Name = "btnPercentis";
            btnPercentis.Size = new System.Drawing.Size(126, 47);
            btnPercentis.TabIndex = 14;
            btnPercentis.Text = "Percentis";
            btnPercentis.TextColor = System.Drawing.Color.White;
            btnPercentis.UseVisualStyleBackColor = false;
            btnPercentis.Click += new System.EventHandler(this.btnPercentis_Click);
            // 
            // btnQuartis
            // 
            btnQuartis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnQuartis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnQuartis.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnQuartis.BorderRadius = 50;
            btnQuartis.BorderSize = 0;
            btnQuartis.FlatAppearance.BorderSize = 0;
            btnQuartis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuartis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnQuartis.ForeColor = System.Drawing.Color.White;
            btnQuartis.Location = new System.Drawing.Point(514, 253);
            btnQuartis.Name = "btnQuartis";
            btnQuartis.Size = new System.Drawing.Size(126, 47);
            btnQuartis.TabIndex = 12;
            btnQuartis.Text = "Quartis";
            btnQuartis.TextColor = System.Drawing.Color.White;
            btnQuartis.UseVisualStyleBackColor = false;
            btnQuartis.Click += new System.EventHandler(this.btnQuartis_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.Color.Black;
            this.lblMedia.Location = new System.Drawing.Point(676, 36);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(51, 20);
            this.lblMedia.TabIndex = 1;
            this.lblMedia.Text = "label1";
            this.lblMedia.Visible = false;
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModa.ForeColor = System.Drawing.Color.Black;
            this.lblModa.Location = new System.Drawing.Point(676, 187);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(51, 20);
            this.lblModa.TabIndex = 2;
            this.lblModa.Text = "label2";
            this.lblModa.Visible = false;
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediana.ForeColor = System.Drawing.Color.Black;
            this.lblMediana.Location = new System.Drawing.Point(676, 111);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(51, 20);
            this.lblMediana.TabIndex = 3;
            this.lblMediana.Text = "label3";
            this.lblMediana.Visible = false;
            // 
            // dgvTeste
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTeste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTeste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.dgvTeste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeste.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeste.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeste.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.dgvTeste.Location = new System.Drawing.Point(22, 27);
            this.dgvTeste.Name = "dgvTeste";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeste.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTeste.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTeste.Size = new System.Drawing.Size(486, 620);
            this.dgvTeste.TabIndex = 5;
            this.dgvTeste.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTeste_CellFormatting);
            // 
            // lblQuartis
            // 
            this.lblQuartis.AutoSize = true;
            this.lblQuartis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuartis.ForeColor = System.Drawing.Color.Black;
            this.lblQuartis.Location = new System.Drawing.Point(676, 262);
            this.lblQuartis.Name = "lblQuartis";
            this.lblQuartis.Size = new System.Drawing.Size(51, 20);
            this.lblQuartis.TabIndex = 11;
            this.lblQuartis.Text = "label3";
            this.lblQuartis.Visible = false;
            // 
            // lblPercentis
            // 
            this.lblPercentis.AutoSize = true;
            this.lblPercentis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentis.ForeColor = System.Drawing.Color.Black;
            this.lblPercentis.Location = new System.Drawing.Point(780, 391);
            this.lblPercentis.Name = "lblPercentis";
            this.lblPercentis.Size = new System.Drawing.Size(51, 20);
            this.lblPercentis.TabIndex = 13;
            this.lblPercentis.Text = "label3";
            this.lblPercentis.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(510, 353);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 20);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Digite o percentil que você deseja saber:";
            // 
            // txtPercentil
            // 
            this.txtPercentil.Location = new System.Drawing.Point(514, 391);
            this.txtPercentil.Mask = "000";
            this.txtPercentil.Name = "txtPercentil";
            this.txtPercentil.Size = new System.Drawing.Size(260, 20);
            this.txtPercentil.TabIndex = 18;
            // 
            // lblDesvioPadrao
            // 
            this.lblDesvioPadrao.AutoSize = true;
            this.lblDesvioPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesvioPadrao.ForeColor = System.Drawing.Color.Black;
            this.lblDesvioPadrao.Location = new System.Drawing.Point(676, 483);
            this.lblDesvioPadrao.Name = "lblDesvioPadrao";
            this.lblDesvioPadrao.Size = new System.Drawing.Size(42, 20);
            this.lblDesvioPadrao.TabIndex = 20;
            this.lblDesvioPadrao.Text = "label";
            this.lblDesvioPadrao.Visible = false;
            // 
            // lblDipersao
            // 
            this.lblDipersao.AutoSize = true;
            this.lblDipersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDipersao.ForeColor = System.Drawing.Color.Black;
            this.lblDipersao.Location = new System.Drawing.Point(676, 608);
            this.lblDipersao.Name = "lblDipersao";
            this.lblDipersao.Size = new System.Drawing.Size(42, 20);
            this.lblDipersao.TabIndex = 22;
            this.lblDipersao.Text = "label";
            this.lblDipersao.Visible = false;
            // 
            // lblCoeficientePercentilicoCurtose
            // 
            this.lblCoeficientePercentilicoCurtose.AutoSize = true;
            this.lblCoeficientePercentilicoCurtose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoeficientePercentilicoCurtose.ForeColor = System.Drawing.Color.Black;
            this.lblCoeficientePercentilicoCurtose.Location = new System.Drawing.Point(1049, 40);
            this.lblCoeficientePercentilicoCurtose.Name = "lblCoeficientePercentilicoCurtose";
            this.lblCoeficientePercentilicoCurtose.Size = new System.Drawing.Size(42, 20);
            this.lblCoeficientePercentilicoCurtose.TabIndex = 26;
            this.lblCoeficientePercentilicoCurtose.Text = "label";
            this.lblCoeficientePercentilicoCurtose.Visible = false;
            // 
            // lblVariancia
            // 
            this.lblVariancia.AutoSize = true;
            this.lblVariancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariancia.ForeColor = System.Drawing.Color.Black;
            this.lblVariancia.Location = new System.Drawing.Point(676, 546);
            this.lblVariancia.Name = "lblVariancia";
            this.lblVariancia.Size = new System.Drawing.Size(42, 20);
            this.lblVariancia.TabIndex = 28;
            this.lblVariancia.Text = "label";
            this.lblVariancia.Visible = false;
            // 
            // lblCoeficienteAssimetria
            // 
            this.lblCoeficienteAssimetria.AutoSize = true;
            this.lblCoeficienteAssimetria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoeficienteAssimetria.ForeColor = System.Drawing.Color.Black;
            this.lblCoeficienteAssimetria.Location = new System.Drawing.Point(1058, 124);
            this.lblCoeficienteAssimetria.Name = "lblCoeficienteAssimetria";
            this.lblCoeficienteAssimetria.Size = new System.Drawing.Size(42, 20);
            this.lblCoeficienteAssimetria.TabIndex = 30;
            this.lblCoeficienteAssimetria.Text = "label";
            this.lblCoeficienteAssimetria.Visible = false;
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnMedia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnMedia.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMedia.BorderRadius = 50;
            this.btnMedia.BorderSize = 0;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.ForeColor = System.Drawing.Color.White;
            this.btnMedia.Location = new System.Drawing.Point(514, 27);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(126, 47);
            this.btnMedia.TabIndex = 10;
            this.btnMedia.Text = "Média";
            this.btnMedia.TextColor = System.Drawing.Color.White;
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnModa
            // 
            this.btnModa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnModa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnModa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModa.BorderRadius = 50;
            this.btnModa.BorderSize = 0;
            this.btnModa.FlatAppearance.BorderSize = 0;
            this.btnModa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModa.ForeColor = System.Drawing.Color.White;
            this.btnModa.Location = new System.Drawing.Point(514, 178);
            this.btnModa.Name = "btnModa";
            this.btnModa.Size = new System.Drawing.Size(126, 47);
            this.btnModa.TabIndex = 9;
            this.btnModa.Text = "Moda";
            this.btnModa.TextColor = System.Drawing.Color.White;
            this.btnModa.UseVisualStyleBackColor = false;
            this.btnModa.Click += new System.EventHandler(this.btnModa_Click);
            // 
            // btnMediana
            // 
            this.btnMediana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnMediana.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnMediana.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMediana.BorderRadius = 50;
            this.btnMediana.BorderSize = 0;
            this.btnMediana.FlatAppearance.BorderSize = 0;
            this.btnMediana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediana.ForeColor = System.Drawing.Color.White;
            this.btnMediana.Location = new System.Drawing.Point(514, 102);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(126, 47);
            this.btnMediana.TabIndex = 8;
            this.btnMediana.Text = "Mediana";
            this.btnMediana.TextColor = System.Drawing.Color.White;
            this.btnMediana.UseVisualStyleBackColor = false;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
            // 
            // btnGraficoDistNormal
            // 
            btnGraficoDistNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnGraficoDistNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnGraficoDistNormal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            btnGraficoDistNormal.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnGraficoDistNormal.BorderRadius = 50;
            btnGraficoDistNormal.BorderSize = 0;
            btnGraficoDistNormal.FlatAppearance.BorderSize = 0;
            btnGraficoDistNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGraficoDistNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnGraficoDistNormal.ForeColor = System.Drawing.Color.White;
            btnGraficoDistNormal.Location = new System.Drawing.Point(1071, 532);
            btnGraficoDistNormal.Name = "btnGraficoDistNormal";
            btnGraficoDistNormal.Size = new System.Drawing.Size(174, 47);
            btnGraficoDistNormal.TabIndex = 33;
            btnGraficoDistNormal.Text = "Gráfico de Distribuição Normal";
            btnGraficoDistNormal.TextColor = System.Drawing.Color.White;
            btnGraficoDistNormal.UseVisualStyleBackColor = false;
            btnGraficoDistNormal.Click += new System.EventHandler(this.btnGraficoDistNormal_Click);
            // 
            // UC_testes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(btnGraficoDistNormal);
            this.Controls.Add(btnGraphMedia);
            this.Controls.Add(btnGraphControl);
            this.Controls.Add(this.lblCoeficienteAssimetria);
            this.Controls.Add(btnCoeficienteAssimetria);
            this.Controls.Add(this.lblVariancia);
            this.Controls.Add(btnVariancia);
            this.Controls.Add(this.lblCoeficientePercentilicoCurtose);
            this.Controls.Add(btnCoeficientePercentilicoCurtose);
            this.Controls.Add(this.lblDipersao);
            this.Controls.Add(btnDispersao);
            this.Controls.Add(this.lblDesvioPadrao);
            this.Controls.Add(btnDesvioPadrao);
            this.Controls.Add(this.txtPercentil);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(btnPercentis);
            this.Controls.Add(this.lblPercentis);
            this.Controls.Add(btnQuartis);
            this.Controls.Add(this.lblQuartis);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnModa);
            this.Controls.Add(this.btnMediana);
            this.Controls.Add(this.dgvTeste);
            this.Controls.Add(this.lblMediana);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.lblMedia);
            this.Name = "UC_testes";
            this.Size = new System.Drawing.Size(1264, 681);
            this.Load += new System.EventHandler(this.testes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.DataGridView dgvTeste;
        private techDataButton btnMediana;
        private techDataButton btnModa;
        private techDataButton btnMedia;
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