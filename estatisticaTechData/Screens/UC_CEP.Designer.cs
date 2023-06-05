
namespace estatisticaTechData.Screens
{
    partial class UC_CEP
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbVariaveis = new estatisticaTechData.Resources.techDataRadioButton();
            this.btnVIsualize = new estatisticaTechData.techDataButton();
            this.rdbAtributos = new estatisticaTechData.Resources.techDataRadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.lblTitulo.Location = new System.Drawing.Point(270, 74);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(499, 51);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Controle Estatístico de Processo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.lblTittle.Location = new System.Drawing.Point(125, 51);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(391, 42);
            this.lblTittle.TabIndex = 33;
            this.lblTittle.Text = "Qual gráficos você deseja ver?";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.rdbVariaveis);
            this.panel1.Controls.Add(this.lblTittle);
            this.panel1.Controls.Add(this.btnVIsualize);
            this.panel1.Controls.Add(this.rdbAtributos);
            this.panel1.Location = new System.Drawing.Point(198, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 429);
            this.panel1.TabIndex = 63;
            // 
            // rdbVariaveis
            // 
            this.rdbVariaveis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbVariaveis.AutoSize = true;
            this.rdbVariaveis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbVariaveis.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbVariaveis.CheckedColor = System.Drawing.Color.White;
            this.rdbVariaveis.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVariaveis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbVariaveis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbVariaveis.Location = new System.Drawing.Point(147, 215);
            this.rdbVariaveis.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbVariaveis.Name = "rdbVariaveis";
            this.rdbVariaveis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbVariaveis.Size = new System.Drawing.Size(354, 38);
            this.rdbVariaveis.TabIndex = 63;
            this.rdbVariaveis.Text = "Gráfico de Controle de Variáveis";
            this.rdbVariaveis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdbVariaveis.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbVariaveis.UseVisualStyleBackColor = false;
            // 
            // btnVIsualize
            // 
            this.btnVIsualize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVIsualize.AutoSize = true;
            this.btnVIsualize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVIsualize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVIsualize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVIsualize.BorderRadius = 50;
            this.btnVIsualize.BorderSize = 0;
            this.btnVIsualize.FlatAppearance.BorderSize = 0;
            this.btnVIsualize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVIsualize.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIsualize.ForeColor = System.Drawing.Color.White;
            this.btnVIsualize.Location = new System.Drawing.Point(235, 313);
            this.btnVIsualize.Name = "btnVIsualize";
            this.btnVIsualize.Size = new System.Drawing.Size(174, 46);
            this.btnVIsualize.TabIndex = 32;
            this.btnVIsualize.Text = "Vizualizar";
            this.btnVIsualize.TextColor = System.Drawing.Color.White;
            this.btnVIsualize.UseVisualStyleBackColor = false;
            this.btnVIsualize.Click += new System.EventHandler(this.btnVIsualize_Click);
            // 
            // rdbAtributos
            // 
            this.rdbAtributos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbAtributos.AutoSize = true;
            this.rdbAtributos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbAtributos.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbAtributos.CheckedColor = System.Drawing.Color.White;
            this.rdbAtributos.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAtributos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbAtributos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbAtributos.Location = new System.Drawing.Point(146, 142);
            this.rdbAtributos.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbAtributos.Name = "rdbAtributos";
            this.rdbAtributos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbAtributos.Size = new System.Drawing.Size(351, 38);
            this.rdbAtributos.TabIndex = 62;
            this.rdbAtributos.Text = "Gráfico de Controle de Atributos";
            this.rdbAtributos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdbAtributos.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbAtributos.UseVisualStyleBackColor = false;
            // 
            // UC_CEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_CEP";
            this.Size = new System.Drawing.Size(1040, 720);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private techDataButton btnNovaBase;
        private System.Windows.Forms.Label lblTitulo;
        private techDataButton btnAcessoHistorico;
        private techDataButton btnVIsualize;
        private System.Windows.Forms.Label lblTittle;
        private Resources.techDataRadioButton rdbAtributos;
        private System.Windows.Forms.Panel panel1;
        private Resources.techDataRadioButton rdbVariaveis;
    }
}
