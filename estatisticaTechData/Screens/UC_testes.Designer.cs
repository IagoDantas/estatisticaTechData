﻿namespace estatisticaTechData.Screens
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
            estatisticaTechData.techDataButton btnQuartis;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            estatisticaTechData.techDataButton btnPercentis;
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.dgvTeste = new System.Windows.Forms.DataGridView();
            this.btnMediana = new estatisticaTechData.techDataButton();
            this.btnModa = new estatisticaTechData.techDataButton();
            this.btnMedia = new estatisticaTechData.techDataButton();
            this.lblQuartis = new System.Windows.Forms.Label();
            this.lblPercentis = new System.Windows.Forms.Label();
            btnQuartis = new estatisticaTechData.techDataButton();
            btnPercentis = new estatisticaTechData.techDataButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeste)).BeginInit();
            this.SuspendLayout();
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
            btnQuartis.Location = new System.Drawing.Point(556, 364);
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
            this.lblMedia.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.Color.Black;
            this.lblMedia.Location = new System.Drawing.Point(718, 147);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(57, 28);
            this.lblMedia.TabIndex = 1;
            this.lblMedia.Text = "label1";
            this.lblMedia.Visible = false;
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModa.ForeColor = System.Drawing.Color.Black;
            this.lblModa.Location = new System.Drawing.Point(718, 298);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(61, 28);
            this.lblModa.TabIndex = 2;
            this.lblModa.Text = "label2";
            this.lblModa.Visible = false;
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediana.ForeColor = System.Drawing.Color.Black;
            this.lblMediana.Location = new System.Drawing.Point(718, 222);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(61, 28);
            this.lblMediana.TabIndex = 3;
            this.lblMediana.Text = "label3";
            this.lblMediana.Visible = false;
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
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvTeste.Size = new System.Drawing.Size(486, 620);
            this.dgvTeste.TabIndex = 5;
            this.dgvTeste.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTeste_CellFormatting);
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
            this.btnMediana.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediana.ForeColor = System.Drawing.Color.White;
            this.btnMediana.Location = new System.Drawing.Point(556, 213);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(126, 47);
            this.btnMediana.TabIndex = 8;
            this.btnMediana.Text = "Mediana";
            this.btnMediana.TextColor = System.Drawing.Color.White;
            this.btnMediana.UseVisualStyleBackColor = false;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
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
            this.btnModa.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModa.ForeColor = System.Drawing.Color.White;
            this.btnModa.Location = new System.Drawing.Point(556, 289);
            this.btnModa.Name = "btnModa";
            this.btnModa.Size = new System.Drawing.Size(126, 47);
            this.btnModa.TabIndex = 9;
            this.btnModa.Text = "Moda";
            this.btnModa.TextColor = System.Drawing.Color.White;
            this.btnModa.UseVisualStyleBackColor = false;
            this.btnModa.Click += new System.EventHandler(this.btnModa_Click);
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
            this.btnMedia.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.ForeColor = System.Drawing.Color.White;
            this.btnMedia.Location = new System.Drawing.Point(556, 138);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(126, 47);
            this.btnMedia.TabIndex = 10;
            this.btnMedia.Text = "Média";
            this.btnMedia.TextColor = System.Drawing.Color.White;
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lblQuartis
            // 
            this.lblQuartis.AutoSize = true;
            this.lblQuartis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuartis.ForeColor = System.Drawing.Color.Black;
            this.lblQuartis.Location = new System.Drawing.Point(718, 373);
            this.lblQuartis.Name = "lblQuartis";
            this.lblQuartis.Size = new System.Drawing.Size(51, 20);
            this.lblQuartis.TabIndex = 11;
            this.lblQuartis.Text = "label3";
            this.lblQuartis.Visible = false;
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
            btnPercentis.Location = new System.Drawing.Point(556, 440);
            btnPercentis.Name = "btnPercentis";
            btnPercentis.Size = new System.Drawing.Size(126, 47);
            btnPercentis.TabIndex = 14;
            btnPercentis.Text = "Percentis";
            btnPercentis.TextColor = System.Drawing.Color.White;
            btnPercentis.UseVisualStyleBackColor = false;
            btnPercentis.Click += new System.EventHandler(this.btnPercentis_Click);
            // 
            // lblPercentis
            // 
            this.lblPercentis.AutoSize = true;
            this.lblPercentis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentis.ForeColor = System.Drawing.Color.Black;
            this.lblPercentis.Location = new System.Drawing.Point(718, 449);
            this.lblPercentis.Name = "lblPercentis";
            this.lblPercentis.Size = new System.Drawing.Size(51, 20);
            this.lblPercentis.TabIndex = 13;
            this.lblPercentis.Text = "label3";
            this.lblPercentis.Visible = false;
            // 
            // UC_testes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
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
    }
}