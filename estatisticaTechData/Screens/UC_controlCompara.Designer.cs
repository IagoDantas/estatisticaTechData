
namespace estatisticaTechData.Screens
{
    partial class UC_controlCompara
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlGraficos = new System.Windows.Forms.Panel();
            this.zedInicial1 = new ZedGraph.ZedGraphControl();
            this.pnlEscolhas = new System.Windows.Forms.Panel();
            this.rdbGraphC = new estatisticaTechData.Resources.techDataRadioButton();
            this.pnlCompara = new System.Windows.Forms.Panel();
            this.zedCompara1 = new ZedGraph.ZedGraphControl();
            this.pnlEscolhas2 = new System.Windows.Forms.Panel();
            this.techDataRadioButton2 = new estatisticaTechData.Resources.techDataRadioButton();
            this.zedCompara2 = new ZedGraph.ZedGraphControl();
            this.zedCompara3 = new ZedGraph.ZedGraphControl();
            this.zedCompara4 = new ZedGraph.ZedGraphControl();
            this.zedCompara5 = new ZedGraph.ZedGraphControl();
            this.zedCompara6 = new ZedGraph.ZedGraphControl();
            this.pnlGraficos.SuspendLayout();
            this.pnlEscolhas.SuspendLayout();
            this.pnlCompara.SuspendLayout();
            this.pnlEscolhas2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(453, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(394, 51);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Comparação de gráficos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraficos
            // 
            this.pnlGraficos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlGraficos.Controls.Add(this.zedInicial1);
            this.pnlGraficos.Location = new System.Drawing.Point(15, 130);
            this.pnlGraficos.Name = "pnlGraficos";
            this.pnlGraficos.Size = new System.Drawing.Size(630, 481);
            this.pnlGraficos.TabIndex = 14;
            // 
            // zedInicial1
            // 
            this.zedInicial1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedInicial1.Enabled = false;
            this.zedInicial1.Location = new System.Drawing.Point(0, 0);
            this.zedInicial1.Name = "zedInicial1";
            this.zedInicial1.ScrollGrace = 0D;
            this.zedInicial1.ScrollMaxX = 0D;
            this.zedInicial1.ScrollMaxY = 0D;
            this.zedInicial1.ScrollMaxY2 = 0D;
            this.zedInicial1.ScrollMinX = 0D;
            this.zedInicial1.ScrollMinY = 0D;
            this.zedInicial1.ScrollMinY2 = 0D;
            this.zedInicial1.Size = new System.Drawing.Size(630, 481);
            this.zedInicial1.TabIndex = 0;
            this.zedInicial1.UseExtendedPrintDialog = true;
            // 
            // pnlEscolhas
            // 
            this.pnlEscolhas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEscolhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlEscolhas.Controls.Add(this.rdbGraphC);
            this.pnlEscolhas.Location = new System.Drawing.Point(15, 639);
            this.pnlEscolhas.Name = "pnlEscolhas";
            this.pnlEscolhas.Size = new System.Drawing.Size(630, 101);
            this.pnlEscolhas.TabIndex = 64;
            // 
            // rdbGraphC
            // 
            this.rdbGraphC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbGraphC.AutoSize = true;
            this.rdbGraphC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbGraphC.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbGraphC.CheckedColor = System.Drawing.Color.White;
            this.rdbGraphC.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGraphC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbGraphC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbGraphC.Location = new System.Drawing.Point(233, 30);
            this.rdbGraphC.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbGraphC.Name = "rdbGraphC";
            this.rdbGraphC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbGraphC.Size = new System.Drawing.Size(133, 38);
            this.rdbGraphC.TabIndex = 64;
            this.rdbGraphC.Text = "Gráfico C";
            this.rdbGraphC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdbGraphC.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.rdbGraphC.UseVisualStyleBackColor = false;
            // 
            // pnlCompara
            // 
            this.pnlCompara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCompara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlCompara.Controls.Add(this.zedCompara6);
            this.pnlCompara.Controls.Add(this.zedCompara5);
            this.pnlCompara.Controls.Add(this.zedCompara4);
            this.pnlCompara.Controls.Add(this.zedCompara3);
            this.pnlCompara.Controls.Add(this.zedCompara2);
            this.pnlCompara.Controls.Add(this.zedCompara1);
            this.pnlCompara.Location = new System.Drawing.Point(655, 130);
            this.pnlCompara.Name = "pnlCompara";
            this.pnlCompara.Size = new System.Drawing.Size(630, 481);
            this.pnlCompara.TabIndex = 15;
            // 
            // zedCompara1
            // 
            this.zedCompara1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedCompara1.Enabled = false;
            this.zedCompara1.Location = new System.Drawing.Point(0, 0);
            this.zedCompara1.Name = "zedCompara1";
            this.zedCompara1.ScrollGrace = 0D;
            this.zedCompara1.ScrollMaxX = 0D;
            this.zedCompara1.ScrollMaxY = 0D;
            this.zedCompara1.ScrollMaxY2 = 0D;
            this.zedCompara1.ScrollMinX = 0D;
            this.zedCompara1.ScrollMinY = 0D;
            this.zedCompara1.ScrollMinY2 = 0D;
            this.zedCompara1.Size = new System.Drawing.Size(630, 481);
            this.zedCompara1.TabIndex = 0;
            this.zedCompara1.UseExtendedPrintDialog = true;
            // 
            // pnlEscolhas2
            // 
            this.pnlEscolhas2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEscolhas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlEscolhas2.Controls.Add(this.techDataRadioButton2);
            this.pnlEscolhas2.Location = new System.Drawing.Point(655, 639);
            this.pnlEscolhas2.Name = "pnlEscolhas2";
            this.pnlEscolhas2.Size = new System.Drawing.Size(630, 101);
            this.pnlEscolhas2.TabIndex = 66;
            // 
            // techDataRadioButton2
            // 
            this.techDataRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.techDataRadioButton2.AutoSize = true;
            this.techDataRadioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.techDataRadioButton2.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.techDataRadioButton2.CheckedColor = System.Drawing.Color.White;
            this.techDataRadioButton2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techDataRadioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.techDataRadioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.techDataRadioButton2.Location = new System.Drawing.Point(293, 30);
            this.techDataRadioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.techDataRadioButton2.Name = "techDataRadioButton2";
            this.techDataRadioButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.techDataRadioButton2.Size = new System.Drawing.Size(133, 38);
            this.techDataRadioButton2.TabIndex = 64;
            this.techDataRadioButton2.Text = "Gráfico C";
            this.techDataRadioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.techDataRadioButton2.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.techDataRadioButton2.UseVisualStyleBackColor = false;
            // 
            // zedCompara2
            // 
            this.zedCompara2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedCompara2.Enabled = false;
            this.zedCompara2.Location = new System.Drawing.Point(0, 0);
            this.zedCompara2.Name = "zedCompara2";
            this.zedCompara2.ScrollGrace = 0D;
            this.zedCompara2.ScrollMaxX = 0D;
            this.zedCompara2.ScrollMaxY = 0D;
            this.zedCompara2.ScrollMaxY2 = 0D;
            this.zedCompara2.ScrollMinX = 0D;
            this.zedCompara2.ScrollMinY = 0D;
            this.zedCompara2.ScrollMinY2 = 0D;
            this.zedCompara2.Size = new System.Drawing.Size(630, 481);
            this.zedCompara2.TabIndex = 1;
            this.zedCompara2.UseExtendedPrintDialog = true;
            // 
            // zedCompara3
            // 
            this.zedCompara3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedCompara3.Enabled = false;
            this.zedCompara3.Location = new System.Drawing.Point(0, 0);
            this.zedCompara3.Name = "zedCompara3";
            this.zedCompara3.ScrollGrace = 0D;
            this.zedCompara3.ScrollMaxX = 0D;
            this.zedCompara3.ScrollMaxY = 0D;
            this.zedCompara3.ScrollMaxY2 = 0D;
            this.zedCompara3.ScrollMinX = 0D;
            this.zedCompara3.ScrollMinY = 0D;
            this.zedCompara3.ScrollMinY2 = 0D;
            this.zedCompara3.Size = new System.Drawing.Size(630, 481);
            this.zedCompara3.TabIndex = 2;
            this.zedCompara3.UseExtendedPrintDialog = true;
            // 
            // zedCompara4
            // 
            this.zedCompara4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedCompara4.Enabled = false;
            this.zedCompara4.Location = new System.Drawing.Point(0, 0);
            this.zedCompara4.Name = "zedCompara4";
            this.zedCompara4.ScrollGrace = 0D;
            this.zedCompara4.ScrollMaxX = 0D;
            this.zedCompara4.ScrollMaxY = 0D;
            this.zedCompara4.ScrollMaxY2 = 0D;
            this.zedCompara4.ScrollMinX = 0D;
            this.zedCompara4.ScrollMinY = 0D;
            this.zedCompara4.ScrollMinY2 = 0D;
            this.zedCompara4.Size = new System.Drawing.Size(630, 481);
            this.zedCompara4.TabIndex = 3;
            this.zedCompara4.UseExtendedPrintDialog = true;
            // 
            // zedCompara5
            // 
            this.zedCompara5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedCompara5.Enabled = false;
            this.zedCompara5.Location = new System.Drawing.Point(0, 0);
            this.zedCompara5.Name = "zedCompara5";
            this.zedCompara5.ScrollGrace = 0D;
            this.zedCompara5.ScrollMaxX = 0D;
            this.zedCompara5.ScrollMaxY = 0D;
            this.zedCompara5.ScrollMaxY2 = 0D;
            this.zedCompara5.ScrollMinX = 0D;
            this.zedCompara5.ScrollMinY = 0D;
            this.zedCompara5.ScrollMinY2 = 0D;
            this.zedCompara5.Size = new System.Drawing.Size(630, 481);
            this.zedCompara5.TabIndex = 4;
            this.zedCompara5.UseExtendedPrintDialog = true;
            // 
            // zedCompara6
            // 
            this.zedCompara6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedCompara6.Enabled = false;
            this.zedCompara6.Location = new System.Drawing.Point(0, 0);
            this.zedCompara6.Name = "zedCompara6";
            this.zedCompara6.ScrollGrace = 0D;
            this.zedCompara6.ScrollMaxX = 0D;
            this.zedCompara6.ScrollMaxY = 0D;
            this.zedCompara6.ScrollMaxY2 = 0D;
            this.zedCompara6.ScrollMinX = 0D;
            this.zedCompara6.ScrollMinY = 0D;
            this.zedCompara6.ScrollMinY2 = 0D;
            this.zedCompara6.Size = new System.Drawing.Size(630, 481);
            this.zedCompara6.TabIndex = 5;
            this.zedCompara6.UseExtendedPrintDialog = true;
            // 
            // UC_controlCompara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.pnlEscolhas2);
            this.Controls.Add(this.pnlCompara);
            this.Controls.Add(this.pnlEscolhas);
            this.Controls.Add(this.pnlGraficos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_controlCompara";
            this.Size = new System.Drawing.Size(1300, 818);
            this.Load += new System.EventHandler(this.UC_controlCompara_Load);
            this.pnlGraficos.ResumeLayout(false);
            this.pnlEscolhas.ResumeLayout(false);
            this.pnlEscolhas.PerformLayout();
            this.pnlCompara.ResumeLayout(false);
            this.pnlEscolhas2.ResumeLayout(false);
            this.pnlEscolhas2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private techDataButton btnNovaBase;
        private System.Windows.Forms.Label lblTitulo;
        private techDataButton btnAcessoHistorico;
        private System.Windows.Forms.Panel pnlGraficos;
        private ZedGraph.ZedGraphControl zedInicial1;
        private Resources.techDataRadioButton rdbGraphC;
        private System.Windows.Forms.Panel pnlEscolhas;
        private System.Windows.Forms.Panel pnlCompara;
        private ZedGraph.ZedGraphControl zedCompara1;
        private System.Windows.Forms.Panel pnlEscolhas2;
        private Resources.techDataRadioButton techDataRadioButton2;
        private ZedGraph.ZedGraphControl zedCompara5;
        private ZedGraph.ZedGraphControl zedCompara4;
        private ZedGraph.ZedGraphControl zedCompara3;
        private ZedGraph.ZedGraphControl zedCompara2;
        private ZedGraph.ZedGraphControl zedCompara6;
    }
}
