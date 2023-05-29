namespace estatisticaTechData
{
    partial class frm_GraphPC
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
            this.zed_graphC = new ZedGraph.ZedGraphControl();
            this.btn_novaBaseC = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_NovaBaseP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zed_graphC
            // 
            this.zed_graphC.Dock = System.Windows.Forms.DockStyle.Left;
            this.zed_graphC.Location = new System.Drawing.Point(0, 0);
            this.zed_graphC.Name = "zed_graphC";
            this.zed_graphC.ScrollGrace = 0D;
            this.zed_graphC.ScrollMaxX = 0D;
            this.zed_graphC.ScrollMaxY = 0D;
            this.zed_graphC.ScrollMaxY2 = 0D;
            this.zed_graphC.ScrollMinX = 0D;
            this.zed_graphC.ScrollMinY = 0D;
            this.zed_graphC.ScrollMinY2 = 0D;
            this.zed_graphC.Size = new System.Drawing.Size(800, 561);
            this.zed_graphC.TabIndex = 0;
            this.zed_graphC.UseExtendedPrintDialog = true;
            // 
            // btn_novaBaseC
            // 
            this.btn_novaBaseC.Location = new System.Drawing.Point(806, 12);
            this.btn_novaBaseC.Name = "btn_novaBaseC";
            this.btn_novaBaseC.Size = new System.Drawing.Size(172, 31);
            this.btn_novaBaseC.TabIndex = 1;
            this.btn_novaBaseC.Text = "Nova base de dados C";
            this.btn_novaBaseC.UseVisualStyleBackColor = true;
            this.btn_novaBaseC.Click += new System.EventHandler(this.btn_novaBaseC_Click);
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(806, 519);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(172, 30);
            this.btn_random.TabIndex = 2;
            this.btn_random.Text = "Aleatórizar";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_NovaBaseP
            // 
            this.btn_NovaBaseP.Location = new System.Drawing.Point(806, 49);
            this.btn_NovaBaseP.Name = "btn_NovaBaseP";
            this.btn_NovaBaseP.Size = new System.Drawing.Size(172, 31);
            this.btn_NovaBaseP.TabIndex = 3;
            this.btn_NovaBaseP.Text = "Nova base de dados P";
            this.btn_NovaBaseP.UseVisualStyleBackColor = true;
            this.btn_NovaBaseP.Click += new System.EventHandler(this.btn_NovaBaseP_Click);
            // 
            // frm_GraphControlC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btn_NovaBaseP);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.btn_novaBaseC);
            this.Controls.Add(this.zed_graphC);
            this.Name = "frm_GraphControlC";
            this.Text = "frm_GraphControlC";
            this.Load += new System.EventHandler(this.frm_GraphControlC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zed_graphC;
        private System.Windows.Forms.Button btn_novaBaseC;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_NovaBaseP;
    }
}