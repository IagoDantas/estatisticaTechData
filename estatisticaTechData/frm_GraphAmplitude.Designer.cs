namespace estatisticaTechData
{
    partial class frmGraphAmplitude
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
            this.grafico.Location = new System.Drawing.Point(12, 12);
            this.grafico.Name = "grafico";
            this.grafico.ScrollGrace = 0D;
            this.grafico.ScrollMaxX = 0D;
            this.grafico.ScrollMaxY = 0D;
            this.grafico.ScrollMaxY2 = 0D;
            this.grafico.ScrollMinX = 0D;
            this.grafico.ScrollMinY = 0D;
            this.grafico.ScrollMinY2 = 0D;
            this.grafico.Size = new System.Drawing.Size(776, 395);
            this.grafico.TabIndex = 0;
            this.grafico.UseExtendedPrintDialog = true;
            // 
            // frmGraphAmplitude
            // 
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.grafico);
            this.Name = "frmGraphAmplitude";
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl grafico;
    }
}