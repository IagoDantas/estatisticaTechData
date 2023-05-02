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
            this.lblSenhaConfirma = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblRa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lklSignIn = new System.Windows.Forms.LinkLabel();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.rdbProfessor = new estatisticaTechData.Resources.techDataRadioButton();
            this.rdbAluno = new estatisticaTechData.Resources.techDataRadioButton();
            this.txtConfirmaSenha = new estatisticaTechData.techDataTextBox();
            this.txtSenha = new estatisticaTechData.techDataTextBox();
            this.txtEmail = new estatisticaTechData.techDataTextBox();
            this.txtNome = new estatisticaTechData.techDataTextBox();
            this.txtRA = new estatisticaTechData.techDataTextBox();
            this.btnCadastrar = new estatisticaTechData.techDataButton();
            this.btnSombraCadastro = new estatisticaTechData.techDataButton();
            this.txtSombraConfirmaSenha = new estatisticaTechData.techDataTextBox();
            this.txtSombraSenha = new estatisticaTechData.techDataTextBox();
            this.txtSombraEmail = new estatisticaTechData.techDataTextBox();
            this.txtSombraNome = new estatisticaTechData.techDataTextBox();
            this.txtSombraRA = new estatisticaTechData.techDataTextBox();
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
            // lblSenhaConfirma
            // 
            this.lblSenhaConfirma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenhaConfirma.AutoSize = true;
            this.lblSenhaConfirma.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.lblSenhaConfirma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lblSenhaConfirma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSenhaConfirma.Location = new System.Drawing.Point(801, 428);
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
            this.lblSenha.Location = new System.Drawing.Point(871, 267);
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
            this.lblRa.Location = new System.Drawing.Point(327, 431);
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
            this.lblEmail.Location = new System.Drawing.Point(871, 137);
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
            this.lblNome.Location = new System.Drawing.Point(305, 137);
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
            this.lblTitulo.Location = new System.Drawing.Point(558, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(162, 51);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "Cadastro";
            // 
            // lklSignIn
            // 
            this.lklSignIn.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(189)))), ((int)(((byte)(168)))));
            this.lklSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lklSignIn.AutoSize = true;
            this.lklSignIn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklSignIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lklSignIn.Location = new System.Drawing.Point(608, 632);
            this.lklSignIn.Name = "lklSignIn";
            this.lklSignIn.Size = new System.Drawing.Size(64, 28);
            this.lklSignIn.TabIndex = 62;
            this.lklSignIn.TabStop = true;
            this.lklSignIn.Text = "entrar";
            this.lklSignIn.Click += new System.EventHandler(this.lklSignIn_Click);
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.Lbl_Resultado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_Resultado.Location = new System.Drawing.Point(1093, 331);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 34);
            this.Lbl_Resultado.TabIndex = 63;
            // 
            // rdbProfessor
            // 
            this.rdbProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbProfessor.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbProfessor.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.rdbProfessor.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbProfessor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbProfessor.Location = new System.Drawing.Point(207, 352);
            this.rdbProfessor.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbProfessor.Name = "rdbProfessor";
            this.rdbProfessor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbProfessor.Size = new System.Drawing.Size(340, 32);
            this.rdbProfessor.TabIndex = 5;
            this.rdbProfessor.Text = "Professor(a) ou Instrutor(a)";
            this.rdbProfessor.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.rdbProfessor.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbProfessor.UseVisualStyleBackColor = true;
            // 
            // rdbAluno
            // 
            this.rdbAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbAluno.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbAluno.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.rdbAluno.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbAluno.Location = new System.Drawing.Point(207, 294);
            this.rdbAluno.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbAluno.Name = "rdbAluno";
            this.rdbAluno.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbAluno.Size = new System.Drawing.Size(133, 28);
            this.rdbAluno.TabIndex = 61;
            this.rdbAluno.Text = "Aluno(a)";
            this.rdbAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdbAluno.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.rdbAluno.UseVisualStyleBackColor = true;
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
            this.txtConfirmaSenha.Location = new System.Drawing.Point(760, 474);
            this.txtConfirmaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmaSenha.Multiline = false;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtConfirmaSenha.PasswordChar = true;
            this.txtConfirmaSenha.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtConfirmaSenha.PlaceholderText = "Digite sua senha novamente:";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(326, 50);
            this.txtConfirmaSenha.TabIndex = 3;
            this.txtConfirmaSenha.Texts = "";
            this.txtConfirmaSenha.UnderlinedStyle = false;
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
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Texts = "";
            this.txtSenha.UnderlinedStyle = false;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
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
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
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
            // txtRA
            // 
            this.txtRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtRA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtRA.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtRA.BorderRadius = 25;
            this.txtRA.BorderSize = 2;
            this.txtRA.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtRA.Location = new System.Drawing.Point(191, 474);
            this.txtRA.Margin = new System.Windows.Forms.Padding(4);
            this.txtRA.Multiline = false;
            this.txtRA.Name = "txtRA";
            this.txtRA.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtRA.PasswordChar = false;
            this.txtRA.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtRA.PlaceholderText = "Digite seu RA:";
            this.txtRA.Size = new System.Drawing.Size(326, 50);
            this.txtRA.TabIndex = 4;
            this.txtRA.Texts = "";
            this.txtRA.UnderlinedStyle = false;
            this.txtRA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRA_KeyPress);
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
            this.btnCadastrar.Location = new System.Drawing.Point(530, 556);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(225, 55);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // btnSombraCadastro
            // 
            this.btnSombraCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSombraCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSombraCadastro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSombraCadastro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSombraCadastro.BorderRadius = 55;
            this.btnSombraCadastro.BorderSize = 0;
            this.btnSombraCadastro.Enabled = false;
            this.btnSombraCadastro.FlatAppearance.BorderSize = 0;
            this.btnSombraCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSombraCadastro.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSombraCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraCadastro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSombraCadastro.Location = new System.Drawing.Point(530, 568);
            this.btnSombraCadastro.Name = "btnSombraCadastro";
            this.btnSombraCadastro.Size = new System.Drawing.Size(225, 50);
            this.btnSombraCadastro.TabIndex = 55;
            this.btnSombraCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSombraCadastro.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraCadastro.UseVisualStyleBackColor = false;
            // 
            // txtSombraConfirmaSenha
            // 
            this.txtSombraConfirmaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraConfirmaSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraConfirmaSenha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSombraConfirmaSenha.BorderRadius = 25;
            this.txtSombraConfirmaSenha.BorderSize = 2;
            this.txtSombraConfirmaSenha.Enabled = false;
            this.txtSombraConfirmaSenha.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSombraConfirmaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraConfirmaSenha.Location = new System.Drawing.Point(760, 478);
            this.txtSombraConfirmaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSombraConfirmaSenha.Multiline = false;
            this.txtSombraConfirmaSenha.Name = "txtSombraConfirmaSenha";
            this.txtSombraConfirmaSenha.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtSombraConfirmaSenha.PasswordChar = false;
            this.txtSombraConfirmaSenha.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraConfirmaSenha.PlaceholderText = "";
            this.txtSombraConfirmaSenha.Size = new System.Drawing.Size(326, 50);
            this.txtSombraConfirmaSenha.TabIndex = 56;
            this.txtSombraConfirmaSenha.Texts = "";
            this.txtSombraConfirmaSenha.UnderlinedStyle = false;
            // 
            // txtSombraSenha
            // 
            this.txtSombraSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraSenha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSombraSenha.BorderRadius = 25;
            this.txtSombraSenha.BorderSize = 2;
            this.txtSombraSenha.Enabled = false;
            this.txtSombraSenha.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSombraSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraSenha.Location = new System.Drawing.Point(760, 319);
            this.txtSombraSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSombraSenha.Multiline = false;
            this.txtSombraSenha.Name = "txtSombraSenha";
            this.txtSombraSenha.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtSombraSenha.PasswordChar = false;
            this.txtSombraSenha.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraSenha.PlaceholderText = "";
            this.txtSombraSenha.Size = new System.Drawing.Size(326, 50);
            this.txtSombraSenha.TabIndex = 60;
            this.txtSombraSenha.Texts = "";
            this.txtSombraSenha.UnderlinedStyle = false;
            // 
            // txtSombraEmail
            // 
            this.txtSombraEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSombraEmail.BorderRadius = 25;
            this.txtSombraEmail.BorderSize = 2;
            this.txtSombraEmail.Enabled = false;
            this.txtSombraEmail.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSombraEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraEmail.Location = new System.Drawing.Point(760, 187);
            this.txtSombraEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtSombraEmail.Multiline = false;
            this.txtSombraEmail.Name = "txtSombraEmail";
            this.txtSombraEmail.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtSombraEmail.PasswordChar = false;
            this.txtSombraEmail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraEmail.PlaceholderText = "";
            this.txtSombraEmail.Size = new System.Drawing.Size(326, 50);
            this.txtSombraEmail.TabIndex = 59;
            this.txtSombraEmail.Texts = "";
            this.txtSombraEmail.UnderlinedStyle = false;
            // 
            // txtSombraNome
            // 
            this.txtSombraNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraNome.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSombraNome.BorderRadius = 25;
            this.txtSombraNome.BorderSize = 2;
            this.txtSombraNome.Enabled = false;
            this.txtSombraNome.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSombraNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraNome.Location = new System.Drawing.Point(191, 187);
            this.txtSombraNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSombraNome.Multiline = false;
            this.txtSombraNome.Name = "txtSombraNome";
            this.txtSombraNome.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtSombraNome.PasswordChar = false;
            this.txtSombraNome.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraNome.PlaceholderText = "";
            this.txtSombraNome.Size = new System.Drawing.Size(326, 50);
            this.txtSombraNome.TabIndex = 58;
            this.txtSombraNome.Texts = "";
            this.txtSombraNome.UnderlinedStyle = false;
            // 
            // txtSombraRA
            // 
            this.txtSombraRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraRA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSombraRA.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.txtSombraRA.BorderRadius = 25;
            this.txtSombraRA.BorderSize = 2;
            this.txtSombraRA.Enabled = false;
            this.txtSombraRA.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSombraRA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraRA.Location = new System.Drawing.Point(191, 478);
            this.txtSombraRA.Margin = new System.Windows.Forms.Padding(4);
            this.txtSombraRA.Multiline = false;
            this.txtSombraRA.Name = "txtSombraRA";
            this.txtSombraRA.Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            this.txtSombraRA.PasswordChar = false;
            this.txtSombraRA.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.txtSombraRA.PlaceholderText = "";
            this.txtSombraRA.Size = new System.Drawing.Size(326, 50);
            this.txtSombraRA.TabIndex = 57;
            this.txtSombraRA.Texts = "";
            this.txtSombraRA.UnderlinedStyle = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.lklSignIn);
            this.Controls.Add(this.rdbProfessor);
            this.Controls.Add(this.rdbAluno);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.lblSenhaConfirma);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblRa);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSombraCadastro);
            this.Controls.Add(this.txtSombraConfirmaSenha);
            this.Controls.Add(this.txtSombraSenha);
            this.Controls.Add(this.txtSombraEmail);
            this.Controls.Add(this.txtSombraNome);
            this.Controls.Add(this.txtSombraRA);
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
        private techDataButton btnSombraCadastro;
        private techDataTextBox txtSombraConfirmaSenha;
        private techDataTextBox txtSombraRA;
        private techDataTextBox txtSombraNome;
        private techDataTextBox txtSombraEmail;
        private techDataTextBox txtSombraSenha;
        private Resources.techDataRadioButton rdbAluno;
        private Resources.techDataRadioButton rdbProfessor;
        private System.Windows.Forms.LinkLabel lklSignIn;
        private System.Windows.Forms.Label Lbl_Resultado;
    }
}