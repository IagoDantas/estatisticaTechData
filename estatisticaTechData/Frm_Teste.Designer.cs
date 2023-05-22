
namespace estatisticaTechData
{
    partial class Frm_Teste
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
            this.SuspendLayout();
            // 
            // grafico
            // 
            this.grafico.Location = new System.Drawing.Point(57, 12);
            this.grafico.Name = "grafico";
            this.grafico.ScrollGrace = 0D;
            this.grafico.ScrollMaxX = 0D;
            this.grafico.ScrollMaxY = 0D;
            this.grafico.ScrollMaxY2 = 0D;
            this.grafico.ScrollMinX = 0D;
            this.grafico.ScrollMinY = 0D;
            this.grafico.ScrollMinY2 = 0D;
            this.grafico.Size = new System.Drawing.Size(657, 404);
            this.grafico.TabIndex = 0;
            this.grafico.UseExtendedPrintDialog = true;
            // 
            // Frm_Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grafico);
            this.Name = "Frm_Teste";
            this.Text = "Frm_Teste";
            this.Load += new System.EventHandler(this.Frm_Teste_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl grafico;
    }
}