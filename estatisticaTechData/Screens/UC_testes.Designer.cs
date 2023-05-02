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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.dgvTeste = new System.Windows.Forms.DataGridView();
            this.btnMediana = new estatisticaTechData.techDataButton();
            this.btnModa = new estatisticaTechData.techDataButton();
            this.btnMedia = new estatisticaTechData.techDataButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeste)).BeginInit();
            this.SuspendLayout();
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
            this.lblMediana.Location = new System.Drawing.Point(718, 460);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(61, 28);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnMediana.Location = new System.Drawing.Point(556, 451);
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
            // UC_testes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
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
    }
}