
namespace estatisticaTechData.Screens
{
    partial class frmTypeGraph
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnVerificar = new estatisticaTechData.techDataButton();
            this.btnSombraEntrar = new estatisticaTechData.techDataButton();
            this.rdbDist = new estatisticaTechData.Resources.techDataRadioButton();
            this.rdbAtributo = new estatisticaTechData.Resources.techDataRadioButton();
            this.rdbVariavel = new estatisticaTechData.Resources.techDataRadioButton();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblEmail.Location = new System.Drawing.Point(21, 23);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(483, 28);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Você deseja comparar com um gráfico de que tipo?";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnVerificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnVerificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVerificar.BorderRadius = 40;
            this.btnVerificar.BorderSize = 0;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVerificar.Location = new System.Drawing.Point(185, 252);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(151, 41);
            this.btnVerificar.TabIndex = 18;
            this.btnVerificar.Text = "continuar";
            this.btnVerificar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnSombraEntrar
            // 
            this.btnSombraEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSombraEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSombraEntrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSombraEntrar.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnSombraEntrar.BorderRadius = 40;
            this.btnSombraEntrar.BorderSize = 0;
            this.btnSombraEntrar.Enabled = false;
            this.btnSombraEntrar.FlatAppearance.BorderSize = 0;
            this.btnSombraEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSombraEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSombraEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraEntrar.Location = new System.Drawing.Point(185, 257);
            this.btnSombraEntrar.Name = "btnSombraEntrar";
            this.btnSombraEntrar.Size = new System.Drawing.Size(151, 41);
            this.btnSombraEntrar.TabIndex = 19;
            this.btnSombraEntrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraEntrar.UseVisualStyleBackColor = false;
            // 
            // rdbDist
            // 
            this.rdbDist.AutoSize = true;
            this.rdbDist.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbDist.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbDist.Location = new System.Drawing.Point(157, 82);
            this.rdbDist.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbDist.Name = "rdbDist";
            this.rdbDist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbDist.Size = new System.Drawing.Size(196, 32);
            this.rdbDist.TabIndex = 20;
            this.rdbDist.TabStop = true;
            this.rdbDist.Text = "Distribuição normal";
            this.rdbDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbDist.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbDist.UseVisualStyleBackColor = true;
            // 
            // rdbAtributo
            // 
            this.rdbAtributo.AutoSize = true;
            this.rdbAtributo.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbAtributo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAtributo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbAtributo.Location = new System.Drawing.Point(157, 134);
            this.rdbAtributo.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbAtributo.Name = "rdbAtributo";
            this.rdbAtributo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbAtributo.Size = new System.Drawing.Size(215, 32);
            this.rdbAtributo.TabIndex = 21;
            this.rdbAtributo.TabStop = true;
            this.rdbAtributo.Text = "Controle por atributos";
            this.rdbAtributo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAtributo.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbAtributo.UseVisualStyleBackColor = true;
            // 
            // rdbVariavel
            // 
            this.rdbVariavel.AutoSize = true;
            this.rdbVariavel.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbVariavel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVariavel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbVariavel.Location = new System.Drawing.Point(157, 189);
            this.rdbVariavel.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbVariavel.Name = "rdbVariavel";
            this.rdbVariavel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbVariavel.Size = new System.Drawing.Size(215, 32);
            this.rdbVariavel.TabIndex = 22;
            this.rdbVariavel.TabStop = true;
            this.rdbVariavel.Text = "Controle por variáveis";
            this.rdbVariavel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbVariavel.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbVariavel.UseVisualStyleBackColor = true;
            // 
            // frmTypeGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(527, 316);
            this.Controls.Add(this.rdbVariavel);
            this.Controls.Add(this.rdbAtributo);
            this.Controls.Add(this.rdbDist);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnSombraEntrar);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTypeGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verificar email";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private techDataButton btnVerificar;
        private techDataButton btnSombraEntrar;
        private Resources.techDataRadioButton rdbDist;
        private Resources.techDataRadioButton rdbAtributo;
        private Resources.techDataRadioButton rdbVariavel;
    }
}