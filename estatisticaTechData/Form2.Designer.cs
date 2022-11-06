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
            this.rdbProfessor = new System.Windows.Forms.RadioButton();
            this.rdbAluno = new System.Windows.Forms.RadioButton();
            this.lblSenhaConfirma = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblRa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCadastrar = new estatisticaTechData.techDataButton();
            this.txtRA = new estatisticaTechData.techDataTextBox();
            this.txtNome = new estatisticaTechData.techDataTextBox();
            this.txtEmail = new estatisticaTechData.techDataTextBox();
            this.txtSenha = new estatisticaTechData.techDataTextBox();
            this.txtConfirmaSenha = new estatisticaTechData.techDataTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pcbLogo.Location = new System.Drawing.Point(12, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(160, 156);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbLogo.TabIndex = 49;
            this.pcbLogo.TabStop = false;
            // 
            // rdbProfessor
            // 
            this.rdbProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbProfessor.AutoSize = true;
            this.rdbProfessor.Font = new System.Drawing.Font("Poppins", 15.75F);
            this.rdbProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbProfessor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbProfessor.Location = new System.Drawing.Point(209, 337);
            this.rdbProfessor.Name = "rdbProfessor";
            this.rdbProfessor.Size = new System.Drawing.Size(308, 41);
            this.rdbProfessor.TabIndex = 2;
            this.rdbProfessor.TabStop = true;
            this.rdbProfessor.Text = "Professor(a) / Instrutor(a)";
            this.rdbProfessor.UseVisualStyleBackColor = true;
            // 
            // rdbAluno
            // 
            this.rdbAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbAluno.AutoSize = true;
            this.rdbAluno.Font = new System.Drawing.Font("Poppins", 15.75F);
            this.rdbAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbAluno.Location = new System.Drawing.Point(209, 278);
            this.rdbAluno.Name = "rdbAluno";
            this.rdbAluno.Size = new System.Drawing.Size(127, 41);
            this.rdbAluno.TabIndex = 1;
            this.rdbAluno.TabStop = true;
            this.rdbAluno.Text = "Aluno(a)";
            this.rdbAluno.UseVisualStyleBackColor = true;
            // 
            // lblSenhaConfirma
            // 
            this.lblSenhaConfirma.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.lblRa.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // txtRA
            // 
            this.txtRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtRA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtRA.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtRA.BorderRadius = 25;
            this.txtRA.BorderSize = 2;
            this.txtRA.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtRA.Location = new System.Drawing.Point(191, 459);
            this.txtRA.Margin = new System.Windows.Forms.Padding(4);
            this.txtRA.Multiline = false;
            this.txtRA.Name = "txtRA";
            this.txtRA.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtRA.PasswordChar = false;
            this.txtRA.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtRA.PlaceholderText = "Digite seu RA:";
            this.txtRA.Size = new System.Drawing.Size(326, 50);
            this.txtRA.TabIndex = 51;
            this.txtRA.Texts = "";
            this.txtRA.UnderlinedStyle = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtNome.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtNome.BorderRadius = 25;
            this.txtNome.BorderSize = 2;
            this.txtNome.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtNome.Location = new System.Drawing.Point(191, 183);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtNome.PlaceholderText = "Digite seu nome:";
            this.txtNome.Size = new System.Drawing.Size(326, 50);
            this.txtNome.TabIndex = 0;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtEmail.BorderRadius = 25;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtEmail.Location = new System.Drawing.Point(760, 183);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtEmail.PlaceholderText = "Digite seu email:";
            this.txtEmail.Size = new System.Drawing.Size(326, 50);
            this.txtEmail.TabIndex = 52;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSenha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSenha.BorderRadius = 25;
            this.txtSenha.BorderSize = 2;
            this.txtSenha.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSenha.Location = new System.Drawing.Point(760, 315);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtSenha.PasswordChar = false;
            this.txtSenha.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSenha.PlaceholderText = "Digite sua senha:";
            this.txtSenha.Size = new System.Drawing.Size(326, 50);
            this.txtSenha.TabIndex = 53;
            this.txtSenha.Texts = "";
            this.txtSenha.UnderlinedStyle = false;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtConfirmaSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtConfirmaSenha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtConfirmaSenha.BorderRadius = 25;
            this.txtConfirmaSenha.BorderSize = 2;
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtConfirmaSenha.Location = new System.Drawing.Point(760, 459);
            this.txtConfirmaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmaSenha.Multiline = false;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtConfirmaSenha.PasswordChar = false;
            this.txtConfirmaSenha.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtConfirmaSenha.PlaceholderText = "Digite sua senha novamente:";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(326, 50);
            this.txtConfirmaSenha.TabIndex = 54;
            this.txtConfirmaSenha.Texts = "";
            this.txtConfirmaSenha.UnderlinedStyle = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.rdbProfessor);
            this.Controls.Add(this.rdbAluno);
            this.Controls.Add(this.lblSenhaConfirma);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblRa);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechData";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.RadioButton rdbProfessor;
        private System.Windows.Forms.RadioButton rdbAluno;
        private System.Windows.Forms.Label lblSenhaConfirma;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitulo;
        private techDataButton btnCadastrar;
        private techDataTextBox txtRA;
        private techDataTextBox txtNome;
        private techDataTextBox txtEmail;
        private techDataTextBox txtSenha;
        private techDataTextBox txtConfirmaSenha;
    }
}