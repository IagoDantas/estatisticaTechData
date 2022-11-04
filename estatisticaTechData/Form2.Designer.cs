namespace estatisticaTechData
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaConfirma = new System.Windows.Forms.TextBox();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.rdbProfessor = new System.Windows.Forms.RadioButton();
            this.rdbAluno = new System.Windows.Forms.RadioButton();
            this.lblSenhaConfirma = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblRa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCadastrar = new estatisticaTechData.techDataButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pcbLogo.Location = new System.Drawing.Point(12, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(160, 156);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbLogo.TabIndex = 49;
            this.pcbLogo.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtEmail.Location = new System.Drawing.Point(760, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 29);
            this.txtEmail.TabIndex = 48;
            this.txtEmail.Text = "Digite seu email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtNome.Location = new System.Drawing.Point(191, 183);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(326, 29);
            this.txtNome.TabIndex = 35;
            this.txtNome.Text = "Digite seu nome";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSenha.Location = new System.Drawing.Point(760, 321);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(326, 29);
            this.txtSenha.TabIndex = 47;
            this.txtSenha.Text = "Digite sua senha";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenhaConfirma
            // 
            this.txtSenhaConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSenhaConfirma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaConfirma.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.txtSenhaConfirma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSenhaConfirma.Location = new System.Drawing.Point(760, 459);
            this.txtSenhaConfirma.Name = "txtSenhaConfirma";
            this.txtSenhaConfirma.Size = new System.Drawing.Size(326, 29);
            this.txtSenhaConfirma.TabIndex = 46;
            this.txtSenhaConfirma.Text = "Digite sua senha novamente";
            this.txtSenhaConfirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRa
            // 
            this.txtRa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtRa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRa.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.txtRa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtRa.Location = new System.Drawing.Point(191, 459);
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(326, 29);
            this.txtRa.TabIndex = 45;
            this.txtRa.Text = "Digite seu RA";
            this.txtRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdbProfessor
            // 
            this.rdbProfessor.AutoSize = true;
            this.rdbProfessor.Font = new System.Drawing.Font("Poppins", 15.75F);
            this.rdbProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbProfessor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbProfessor.Location = new System.Drawing.Point(209, 317);
            this.rdbProfessor.Name = "rdbProfessor";
            this.rdbProfessor.Size = new System.Drawing.Size(308, 41);
            this.rdbProfessor.TabIndex = 43;
            this.rdbProfessor.TabStop = true;
            this.rdbProfessor.Text = "Professor(a) / Instrutor(a)";
            this.rdbProfessor.UseVisualStyleBackColor = true;
            // 
            // rdbAluno
            // 
            this.rdbAluno.AutoSize = true;
            this.rdbAluno.Font = new System.Drawing.Font("Poppins", 15.75F);
            this.rdbAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbAluno.Location = new System.Drawing.Point(209, 260);
            this.rdbAluno.Name = "rdbAluno";
            this.rdbAluno.Size = new System.Drawing.Size(127, 41);
            this.rdbAluno.TabIndex = 42;
            this.rdbAluno.TabStop = true;
            this.rdbAluno.Text = "Aluno(a)";
            this.rdbAluno.UseVisualStyleBackColor = true;
            // 
            // lblSenhaConfirma
            // 
            this.lblSenhaConfirma.AutoSize = true;
            this.lblSenhaConfirma.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.lblSenhaConfirma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblSenhaConfirma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSenhaConfirma.Location = new System.Drawing.Point(802, 397);
            this.lblSenhaConfirma.Name = "lblSenhaConfirma";
            this.lblSenhaConfirma.Size = new System.Drawing.Size(242, 42);
            this.lblSenhaConfirma.TabIndex = 41;
            this.lblSenhaConfirma.Text = "Confirme a senha:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSenha.Location = new System.Drawing.Point(872, 259);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(102, 42);
            this.lblSenha.TabIndex = 40;
            this.lblSenha.Text = "Senha:";
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.lblRa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblRa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRa.Location = new System.Drawing.Point(329, 397);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(56, 42);
            this.lblRa.TabIndex = 39;
            this.lblRa.Text = "RA:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(877, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 42);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNome.Location = new System.Drawing.Point(305, 121);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(97, 42);
            this.lblNome.TabIndex = 37;
            this.lblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(559, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(162, 51);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnCadastrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnCadastrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCadastrar.BorderRadius = 55;
            this.btnCadastrar.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(531, 563);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(225, 55);
            this.btnCadastrar.TabIndex = 50;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtSenhaConfirma);
            this.Controls.Add(this.txtRa);
            this.Controls.Add(this.rdbProfessor);
            this.Controls.Add(this.rdbAluno);
            this.Controls.Add(this.lblSenhaConfirma);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblRa);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtSenhaConfirma;
        private System.Windows.Forms.TextBox txtRa;
        private System.Windows.Forms.RadioButton rdbProfessor;
        private System.Windows.Forms.RadioButton rdbAluno;
        private System.Windows.Forms.Label lblSenhaConfirma;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitulo;
        private techDataButton btnCadastrar;
    }
}