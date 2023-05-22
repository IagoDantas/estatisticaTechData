
namespace estatisticaTechData
{
    partial class frmHome
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lklForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lklSignUp = new System.Windows.Forms.LinkLabel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pcbVerSenha = new System.Windows.Forms.PictureBox();
            this.pcbEsconderSenha = new System.Windows.Forms.PictureBox();
            this.txtPassword = new estatisticaTechData.techDataTextBox();
            this.txtUser = new estatisticaTechData.techDataTextBox();
            this.btnSignIn = new estatisticaTechData.techDataButton();
            this.btnSombraEntrar = new estatisticaTechData.techDataButton();
            this.txtSombraSenha = new estatisticaTechData.techDataTextBox();
            this.txtSombraUsuario = new estatisticaTechData.techDataTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEsconderSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(513, 34);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(254, 248);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 6;
            this.pcbLogo.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblPassword.Location = new System.Drawing.Point(603, 427);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "senha:";
            // 
            // lklForgotPassword
            // 
            this.lklForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(189)))), ((int)(((byte)(168)))));
            this.lklForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lklForgotPassword.AutoSize = true;
            this.lklForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lklForgotPassword.Location = new System.Drawing.Point(546, 533);
            this.lklForgotPassword.Name = "lklForgotPassword";
            this.lklForgotPassword.Size = new System.Drawing.Size(154, 20);
            this.lklForgotPassword.TabIndex = 8;
            this.lklForgotPassword.TabStop = true;
            this.lklForgotPassword.Text = "esqueceu a senha?";
            this.lklForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklForgotPassword_LinkClicked);
            // 
            // lklSignUp
            // 
            this.lklSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(189)))), ((int)(((byte)(168)))));
            this.lklSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lklSignUp.AutoSize = true;
            this.lklSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lklSignUp.Location = new System.Drawing.Point(574, 635);
            this.lklSignUp.Name = "lklSignUp";
            this.lklSignUp.Size = new System.Drawing.Size(118, 24);
            this.lklSignUp.TabIndex = 9;
            this.lklSignUp.TabStop = true;
            this.lklSignUp.Text = "cadastre-se";
            this.lklSignUp.Click += new System.EventHandler(this.lklSignUp_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblUser.Location = new System.Drawing.Point(609, 336);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "email:";
            // 
            // pcbVerSenha
            // 
            this.pcbVerSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbVerSenha.Image = global::estatisticaTechData.Properties.Resources.olho;
            this.pcbVerSenha.Location = new System.Drawing.Point(757, 475);
            this.pcbVerSenha.Name = "pcbVerSenha";
            this.pcbVerSenha.Size = new System.Drawing.Size(27, 24);
            this.pcbVerSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVerSenha.TabIndex = 67;
            this.pcbVerSenha.TabStop = false;
            this.pcbVerSenha.Click += new System.EventHandler(this.pcbVerSenha_Click);
            // 
            // pcbEsconderSenha
            // 
            this.pcbEsconderSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbEsconderSenha.Image = global::estatisticaTechData.Properties.Resources.visivel;
            this.pcbEsconderSenha.Location = new System.Drawing.Point(790, 475);
            this.pcbEsconderSenha.Name = "pcbEsconderSenha";
            this.pcbEsconderSenha.Size = new System.Drawing.Size(26, 24);
            this.pcbEsconderSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEsconderSenha.TabIndex = 66;
            this.pcbEsconderSenha.TabStop = false;
            this.pcbEsconderSenha.Click += new System.EventHandler(this.pcbEsconderSenha_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtPassword.BorderRadius = 22;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtPassword.Location = new System.Drawing.Point(528, 462);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 9, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtPassword.PlaceholderText = "Digite sua senha:";
            this.txtPassword.Size = new System.Drawing.Size(222, 37);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtUser.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtUser.BorderRadius = 22;
            this.txtUser.BorderSize = 2;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtUser.Location = new System.Drawing.Point(528, 371);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(10, 9, 10, 7);
            this.txtUser.PasswordChar = false;
            this.txtUser.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtUser.PlaceholderText = "Digite seu email:";
            this.txtUser.Size = new System.Drawing.Size(222, 37);
            this.txtUser.TabIndex = 1;
            this.txtUser.Texts = "";
            this.txtUser.UnderlinedStyle = false;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnSignIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnSignIn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignIn.BorderRadius = 40;
            this.btnSignIn.BorderSize = 0;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSignIn.Location = new System.Drawing.Point(561, 578);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(151, 41);
            this.btnSignIn.TabIndex = 11;
            this.btnSignIn.Text = "entrar";
            this.btnSignIn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
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
            this.btnSombraEntrar.Location = new System.Drawing.Point(561, 582);
            this.btnSombraEntrar.Name = "btnSombraEntrar";
            this.btnSombraEntrar.Size = new System.Drawing.Size(151, 41);
            this.btnSombraEntrar.TabIndex = 12;
            this.btnSombraEntrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraEntrar.UseVisualStyleBackColor = false;
            // 
            // txtSombraSenha
            // 
            this.txtSombraSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSombraSenha.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtSombraSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraSenha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSombraSenha.BorderRadius = 22;
            this.txtSombraSenha.BorderSize = 2;
            this.txtSombraSenha.Enabled = false;
            this.txtSombraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.txtSombraSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraSenha.Location = new System.Drawing.Point(528, 478);
            this.txtSombraSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSombraSenha.Multiline = false;
            this.txtSombraSenha.Name = "txtSombraSenha";
            this.txtSombraSenha.Padding = new System.Windows.Forms.Padding(10, 9, 10, 7);
            this.txtSombraSenha.PasswordChar = false;
            this.txtSombraSenha.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraSenha.PlaceholderText = "";
            this.txtSombraSenha.Size = new System.Drawing.Size(222, 37);
            this.txtSombraSenha.TabIndex = 13;
            this.txtSombraSenha.Texts = "";
            this.txtSombraSenha.UnderlinedStyle = false;
            // 
            // txtSombraUsuario
            // 
            this.txtSombraUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSombraUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSombraUsuario.BorderRadius = 22;
            this.txtSombraUsuario.BorderSize = 2;
            this.txtSombraUsuario.Enabled = false;
            this.txtSombraUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.txtSombraUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraUsuario.Location = new System.Drawing.Point(528, 386);
            this.txtSombraUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSombraUsuario.Multiline = false;
            this.txtSombraUsuario.Name = "txtSombraUsuario";
            this.txtSombraUsuario.Padding = new System.Windows.Forms.Padding(10, 9, 10, 7);
            this.txtSombraUsuario.PasswordChar = false;
            this.txtSombraUsuario.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraUsuario.PlaceholderText = "";
            this.txtSombraUsuario.Size = new System.Drawing.Size(222, 37);
            this.txtSombraUsuario.TabIndex = 14;
            this.txtSombraUsuario.Texts = "";
            this.txtSombraUsuario.UnderlinedStyle = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1264, 678);
            this.Controls.Add(this.pcbVerSenha);
            this.Controls.Add(this.pcbEsconderSenha);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lklSignUp);
            this.Controls.Add(this.lklForgotPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSombraEntrar);
            this.Controls.Add(this.txtSombraSenha);
            this.Controls.Add(this.txtSombraUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechData";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEsconderSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel lklForgotPassword;
        private System.Windows.Forms.LinkLabel lklSignUp;
        private techDataButton btnSignIn;
        private techDataTextBox txtPassword;
        private techDataButton btnSombraEntrar;
        private techDataTextBox txtSombraSenha;
        private techDataTextBox txtSombraUsuario;
        private System.Windows.Forms.Label lblUser;
        private techDataTextBox txtUser;
        private System.Windows.Forms.PictureBox pcbVerSenha;
        private System.Windows.Forms.PictureBox pcbEsconderSenha;
    }
}

