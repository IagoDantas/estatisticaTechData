
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
            this.pnlCompara = new System.Windows.Forms.Panel();
            this.zedCompara6 = new ZedGraph.ZedGraphControl();
            this.zedCompara5 = new ZedGraph.ZedGraphControl();
            this.zedCompara4 = new ZedGraph.ZedGraphControl();
            this.zedCompara3 = new ZedGraph.ZedGraphControl();
            this.zedCompara2 = new ZedGraph.ZedGraphControl();
            this.zedCompara1 = new ZedGraph.ZedGraphControl();
            this.pnlEscolhas2 = new System.Windows.Forms.Panel();
            this.zedInicial2 = new ZedGraph.ZedGraphControl();
            this.zedInicial3 = new ZedGraph.ZedGraphControl();
            this.zedInicial4 = new ZedGraph.ZedGraphControl();
            this.zedInicial5 = new ZedGraph.ZedGraphControl();
            this.zedInicial6 = new ZedGraph.ZedGraphControl();
            this.pnlGraficos.SuspendLayout();
            this.pnlCompara.SuspendLayout();
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
            this.pnlGraficos.Controls.Add(this.zedInicial6);
            this.pnlGraficos.Controls.Add(this.zedInicial5);
            this.pnlGraficos.Controls.Add(this.zedInicial4);
            this.pnlGraficos.Controls.Add(this.zedInicial3);
            this.pnlGraficos.Controls.Add(this.zedInicial2);
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
            this.zedInicial1.Visible = false;
            // 
            // pnlEscolhas
            // 
            this.pnlEscolhas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEscolhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlEscolhas.Location = new System.Drawing.Point(15, 639);
            this.pnlEscolhas.Name = "pnlEscolhas";
            this.pnlEscolhas.Size = new System.Drawing.Size(630, 101);
            this.pnlEscolhas.TabIndex = 64;
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
            this.zedCompara6.Visible = false;
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
            this.zedCompara5.Visible = false;
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
            this.zedCompara4.Visible = false;
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
            this.zedCompara3.Visible = false;
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
            this.zedCompara2.Visible = false;
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
            this.zedCompara1.Visible = false;
            // 
            // pnlEscolhas2
            // 
            this.pnlEscolhas2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEscolhas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.pnlEscolhas2.Location = new System.Drawing.Point(655, 639);
            this.pnlEscolhas2.Name = "pnlEscolhas2";
            this.pnlEscolhas2.Size = new System.Drawing.Size(630, 101);
            this.pnlEscolhas2.TabIndex = 66;
            // 
            // zedInicial2
            // 
            this.zedInicial2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedInicial2.Enabled = false;
            this.zedInicial2.Location = new System.Drawing.Point(0, 0);
            this.zedInicial2.Name = "zedInicial2";
            this.zedInicial2.ScrollGrace = 0D;
            this.zedInicial2.ScrollMaxX = 0D;
            this.zedInicial2.ScrollMaxY = 0D;
            this.zedInicial2.ScrollMaxY2 = 0D;
            this.zedInicial2.ScrollMinX = 0D;
            this.zedInicial2.ScrollMinY = 0D;
            this.zedInicial2.ScrollMinY2 = 0D;
            this.zedInicial2.Size = new System.Drawing.Size(630, 481);
            this.zedInicial2.TabIndex = 1;
            this.zedInicial2.UseExtendedPrintDialog = true;
            this.zedInicial2.Visible = false;
            // 
            // zedInicial3
            // 
            this.zedInicial3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedInicial3.Enabled = false;
            this.zedInicial3.Location = new System.Drawing.Point(0, 0);
            this.zedInicial3.Name = "zedInicial3";
            this.zedInicial3.ScrollGrace = 0D;
            this.zedInicial3.ScrollMaxX = 0D;
            this.zedInicial3.ScrollMaxY = 0D;
            this.zedInicial3.ScrollMaxY2 = 0D;
            this.zedInicial3.ScrollMinX = 0D;
            this.zedInicial3.ScrollMinY = 0D;
            this.zedInicial3.ScrollMinY2 = 0D;
            this.zedInicial3.Size = new System.Drawing.Size(630, 481);
            this.zedInicial3.TabIndex = 2;
            this.zedInicial3.UseExtendedPrintDialog = true;
            this.zedInicial3.Visible = false;
            // 
            // zedInicial4
            // 
            this.zedInicial4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedInicial4.Enabled = false;
            this.zedInicial4.Location = new System.Drawing.Point(0, 0);
            this.zedInicial4.Name = "zedInicial4";
            this.zedInicial4.ScrollGrace = 0D;
            this.zedInicial4.ScrollMaxX = 0D;
            this.zedInicial4.ScrollMaxY = 0D;
            this.zedInicial4.ScrollMaxY2 = 0D;
            this.zedInicial4.ScrollMinX = 0D;
            this.zedInicial4.ScrollMinY = 0D;
            this.zedInicial4.ScrollMinY2 = 0D;
            this.zedInicial4.Size = new System.Drawing.Size(630, 481);
            this.zedInicial4.TabIndex = 3;
            this.zedInicial4.UseExtendedPrintDialog = true;
            this.zedInicial4.Visible = false;
            // 
            // zedInicial5
            // 
            this.zedInicial5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedInicial5.Enabled = false;
            this.zedInicial5.Location = new System.Drawing.Point(0, 0);
            this.zedInicial5.Name = "zedInicial5";
            this.zedInicial5.ScrollGrace = 0D;
            this.zedInicial5.ScrollMaxX = 0D;
            this.zedInicial5.ScrollMaxY = 0D;
            this.zedInicial5.ScrollMaxY2 = 0D;
            this.zedInicial5.ScrollMinX = 0D;
            this.zedInicial5.ScrollMinY = 0D;
            this.zedInicial5.ScrollMinY2 = 0D;
            this.zedInicial5.Size = new System.Drawing.Size(630, 481);
            this.zedInicial5.TabIndex = 4;
            this.zedInicial5.UseExtendedPrintDialog = true;
            this.zedInicial5.Visible = false;
            // 
            // zedInicial6
            // 
            this.zedInicial6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedInicial6.Enabled = false;
            this.zedInicial6.Location = new System.Drawing.Point(0, 0);
            this.zedInicial6.Name = "zedInicial6";
            this.zedInicial6.ScrollGrace = 0D;
            this.zedInicial6.ScrollMaxX = 0D;
            this.zedInicial6.ScrollMaxY = 0D;
            this.zedInicial6.ScrollMaxY2 = 0D;
            this.zedInicial6.ScrollMinX = 0D;
            this.zedInicial6.ScrollMinY = 0D;
            this.zedInicial6.ScrollMinY2 = 0D;
            this.zedInicial6.Size = new System.Drawing.Size(630, 481);
            this.zedInicial6.TabIndex = 5;
            this.zedInicial6.UseExtendedPrintDialog = true;
            this.zedInicial6.Visible = false;
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
            this.pnlCompara.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private techDataButton btnNovaBase;
        private System.Windows.Forms.Label lblTitulo;
        private techDataButton btnAcessoHistorico;
        private System.Windows.Forms.Panel pnlGraficos;
        private ZedGraph.ZedGraphControl zedInicial1;
        private System.Windows.Forms.Panel pnlEscolhas;
        private System.Windows.Forms.Panel pnlCompara;
        private ZedGraph.ZedGraphControl zedCompara1;
        private System.Windows.Forms.Panel pnlEscolhas2;
        private ZedGraph.ZedGraphControl zedCompara5;
        private ZedGraph.ZedGraphControl zedCompara4;
        private ZedGraph.ZedGraphControl zedCompara3;
        private ZedGraph.ZedGraphControl zedCompara2;
        private ZedGraph.ZedGraphControl zedCompara6;
        private ZedGraph.ZedGraphControl zedInicial6;
        private ZedGraph.ZedGraphControl zedInicial5;
        private ZedGraph.ZedGraphControl zedInicial4;
        private ZedGraph.ZedGraphControl zedInicial3;
        private ZedGraph.ZedGraphControl zedInicial2;
    }
}
