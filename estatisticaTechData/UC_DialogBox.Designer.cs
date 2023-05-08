namespace estatisticaTechData
{
    partial class UC_DialogBox
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
            this.techDataButton1 = new estatisticaTechData.techDataButton();
            this.SuspendLayout();
            // 
            // techDataButton1
            // 
            this.techDataButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.techDataButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.techDataButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.techDataButton1.BorderRadius = 40;
            this.techDataButton1.BorderSize = 0;
            this.techDataButton1.FlatAppearance.BorderSize = 0;
            this.techDataButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.techDataButton1.ForeColor = System.Drawing.Color.White;
            this.techDataButton1.Location = new System.Drawing.Point(71, 227);
            this.techDataButton1.Name = "techDataButton1";
            this.techDataButton1.Size = new System.Drawing.Size(104, 40);
            this.techDataButton1.TabIndex = 0;
            this.techDataButton1.Text = "techDataButton1";
            this.techDataButton1.TextColor = System.Drawing.Color.White;
            this.techDataButton1.UseVisualStyleBackColor = false;
            // 
            // UC_DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.techDataButton1);
            this.Name = "UC_DialogBox";
            this.Size = new System.Drawing.Size(394, 270);
            this.ResumeLayout(false);

        }

        #endregion

        private techDataButton techDataButton1;
    }
}
