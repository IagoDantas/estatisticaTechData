namespace estatisticaTechData
{
    partial class frmGraphMedia
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
            this.components = new System.ComponentModel.Container();
            this.grafico = new ZedGraph.ZedGraphControl();
            this.lblCPK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grafico
            // 
            this.grafico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grafico.Location = new System.Drawing.Point(0, 0);
            this.grafico.Name = "grafico";
            this.grafico.ScrollGrace = 0D;
            this.grafico.ScrollMaxX = 0D;
            this.grafico.ScrollMaxY = 0D;
            this.grafico.ScrollMaxY2 = 0D;
            this.grafico.ScrollMinX = 0D;
            this.grafico.ScrollMinY = 0D;
            this.grafico.ScrollMinY2 = 0D;
            this.grafico.Size = new System.Drawing.Size(800, 404);
            this.grafico.TabIndex = 0;
            this.grafico.UseExtendedPrintDialog = true;
            // 
            // lblCPK
            // 
            this.lblCPK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCPK.AutoSize = true;
            this.lblCPK.Location = new System.Drawing.Point(362, 428);
            this.lblCPK.Name = "lblCPK";
            this.lblCPK.Size = new System.Drawing.Size(35, 13);
            this.lblCPK.TabIndex = 1;
            this.lblCPK.Text = "label1";
            // 
            // frmGraphMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCPK);
            this.Controls.Add(this.grafico);
            this.Name = "frmGraphMedia";
            this.Text = "Graph Media";
            this.Load += new System.EventHandler(this.frmGraphMedia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl grafico;
        private System.Windows.Forms.Label lblCPK;
    }
}