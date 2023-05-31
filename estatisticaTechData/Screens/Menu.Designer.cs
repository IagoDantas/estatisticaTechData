
namespace estatisticaTechData
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lklSair = new System.Windows.Forms.LinkLabel();
            this.pbcPerfil = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnConfigUsuario = new estatisticaTechData.techDataButton();
            this.btnHistoricoArquivos = new estatisticaTechData.techDataButton();
            this.btnVisualizarGraficoPrevDemanda = new estatisticaTechData.techDataButton();
            this.btnVisualizarGraficoDistNormal = new estatisticaTechData.techDataButton();
            this.btnAddGraficoDistNormal = new estatisticaTechData.techDataButton();
            this.btnAddGraficoPrevDemanda = new estatisticaTechData.techDataButton();
            this.btnSombraConfigUsuario = new estatisticaTechData.techDataButton();
            this.btnSombraHistoricoArquivos = new estatisticaTechData.techDataButton();
            this.btnSombraVisualizarGraficoPrevDemanda = new estatisticaTechData.techDataButton();
            this.btnSombraVisualizarGraficoDistNormal = new estatisticaTechData.techDataButton();
            this.btnSombraAddGraficoPrevDemanda = new estatisticaTechData.techDataButton();
            this.btnSombraAddGraficoDistNormal = new estatisticaTechData.techDataButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistoricoGraficoCEP = new estatisticaTechData.techDataButton();
            this.techDataButton2 = new estatisticaTechData.techDataButton();
            this.btnAdicionarGraficoCEP = new estatisticaTechData.techDataButton();
            this.techDataButton4 = new estatisticaTechData.techDataButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lklSair
            // 
            this.lklSair.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.lklSair.AutoSize = true;
            this.lklSair.Font = new System.Drawing.Font("Poppins", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklSair.LinkColor = System.Drawing.Color.White;
            this.lklSair.Location = new System.Drawing.Point(615, 635);
            this.lklSair.Name = "lklSair";
            this.lklSair.Size = new System.Drawing.Size(50, 31);
            this.lklSair.TabIndex = 6;
            this.lklSair.TabStop = true;
            this.lklSair.Text = "Sair";
            this.lklSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklSair_LinkClicked);
            // 
            // pbcPerfil
            // 
            this.pbcPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbcPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbcPerfil.Image")));
            this.pbcPerfil.Location = new System.Drawing.Point(105, 0);
            this.pbcPerfil.Name = "pbcPerfil";
            this.pbcPerfil.Size = new System.Drawing.Size(190, 185);
            this.pbcPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcPerfil.TabIndex = 18;
            this.pbcPerfil.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(171, 195);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsuario.Size = new System.Drawing.Size(58, 34);
            this.lblUsuario.TabIndex = 19;
            this.lblUsuario.Text = "User";
            // 
            // btnConfigUsuario
            // 
            this.btnConfigUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnConfigUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnConfigUsuario.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfigUsuario.BorderRadius = 105;
            this.btnConfigUsuario.BorderSize = 0;
            this.btnConfigUsuario.FlatAppearance.BorderSize = 0;
            this.btnConfigUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigUsuario.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnConfigUsuario.Location = new System.Drawing.Point(855, 532);
            this.btnConfigUsuario.Name = "btnConfigUsuario";
            this.btnConfigUsuario.Size = new System.Drawing.Size(306, 105);
            this.btnConfigUsuario.TabIndex = 11;
            this.btnConfigUsuario.Text = "Configurações do usuário";
            this.btnConfigUsuario.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnConfigUsuario.UseVisualStyleBackColor = false;
            this.btnConfigUsuario.Click += new System.EventHandler(this.btnConfigUsuario_Click);
            // 
            // btnHistoricoArquivos
            // 
            this.btnHistoricoArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnHistoricoArquivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnHistoricoArquivos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHistoricoArquivos.BorderRadius = 105;
            this.btnHistoricoArquivos.BorderSize = 0;
            this.btnHistoricoArquivos.FlatAppearance.BorderSize = 0;
            this.btnHistoricoArquivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoricoArquivos.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoricoArquivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnHistoricoArquivos.Location = new System.Drawing.Point(128, 532);
            this.btnHistoricoArquivos.Name = "btnHistoricoArquivos";
            this.btnHistoricoArquivos.Size = new System.Drawing.Size(306, 105);
            this.btnHistoricoArquivos.TabIndex = 10;
            this.btnHistoricoArquivos.Text = "Histórico de arquivos enviados";
            this.btnHistoricoArquivos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnHistoricoArquivos.UseVisualStyleBackColor = false;
            this.btnHistoricoArquivos.Click += new System.EventHandler(this.btnHistoricoArquivos_Click);
            // 
            // btnVisualizarGraficoPrevDemanda
            // 
            this.btnVisualizarGraficoPrevDemanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnVisualizarGraficoPrevDemanda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnVisualizarGraficoPrevDemanda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVisualizarGraficoPrevDemanda.BorderRadius = 105;
            this.btnVisualizarGraficoPrevDemanda.BorderSize = 0;
            this.btnVisualizarGraficoPrevDemanda.Enabled = false;
            this.btnVisualizarGraficoPrevDemanda.FlatAppearance.BorderSize = 0;
            this.btnVisualizarGraficoPrevDemanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarGraficoPrevDemanda.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarGraficoPrevDemanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVisualizarGraficoPrevDemanda.Location = new System.Drawing.Point(855, 289);
            this.btnVisualizarGraficoPrevDemanda.Name = "btnVisualizarGraficoPrevDemanda";
            this.btnVisualizarGraficoPrevDemanda.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnVisualizarGraficoPrevDemanda.Size = new System.Drawing.Size(306, 105);
            this.btnVisualizarGraficoPrevDemanda.TabIndex = 9;
            this.btnVisualizarGraficoPrevDemanda.Text = "Visualizar gráficos de previsão de demanda (Em breve)";
            this.btnVisualizarGraficoPrevDemanda.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVisualizarGraficoPrevDemanda.UseVisualStyleBackColor = false;
            // 
            // btnVisualizarGraficoDistNormal
            // 
            this.btnVisualizarGraficoDistNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnVisualizarGraficoDistNormal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnVisualizarGraficoDistNormal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVisualizarGraficoDistNormal.BorderRadius = 105;
            this.btnVisualizarGraficoDistNormal.BorderSize = 0;
            this.btnVisualizarGraficoDistNormal.FlatAppearance.BorderSize = 0;
            this.btnVisualizarGraficoDistNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarGraficoDistNormal.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarGraficoDistNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVisualizarGraficoDistNormal.Location = new System.Drawing.Point(128, 289);
            this.btnVisualizarGraficoDistNormal.Name = "btnVisualizarGraficoDistNormal";
            this.btnVisualizarGraficoDistNormal.Size = new System.Drawing.Size(306, 105);
            this.btnVisualizarGraficoDistNormal.TabIndex = 8;
            this.btnVisualizarGraficoDistNormal.Text = "Histórico de gráfico de distribuição normal";
            this.btnVisualizarGraficoDistNormal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnVisualizarGraficoDistNormal.UseVisualStyleBackColor = false;
            this.btnVisualizarGraficoDistNormal.Click += new System.EventHandler(this.btnVisualizarGraficoDistNormal_Click);
            // 
            // btnAddGraficoDistNormal
            // 
            this.btnAddGraficoDistNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnAddGraficoDistNormal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnAddGraficoDistNormal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddGraficoDistNormal.BorderRadius = 105;
            this.btnAddGraficoDistNormal.BorderSize = 0;
            this.btnAddGraficoDistNormal.FlatAppearance.BorderSize = 0;
            this.btnAddGraficoDistNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGraficoDistNormal.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGraficoDistNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAddGraficoDistNormal.Location = new System.Drawing.Point(128, 172);
            this.btnAddGraficoDistNormal.Name = "btnAddGraficoDistNormal";
            this.btnAddGraficoDistNormal.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.btnAddGraficoDistNormal.Size = new System.Drawing.Size(306, 105);
            this.btnAddGraficoDistNormal.TabIndex = 7;
            this.btnAddGraficoDistNormal.Text = "Adicionar e visualizar novo gráfico de distribuição normal\r\n\r\n\r\n";
            this.btnAddGraficoDistNormal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAddGraficoDistNormal.UseVisualStyleBackColor = false;
            this.btnAddGraficoDistNormal.Click += new System.EventHandler(this.btnAddGraficoDistNormal_Click);
            // 
            // btnAddGraficoPrevDemanda
            // 
            this.btnAddGraficoPrevDemanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnAddGraficoPrevDemanda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnAddGraficoPrevDemanda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddGraficoPrevDemanda.BorderRadius = 105;
            this.btnAddGraficoPrevDemanda.BorderSize = 0;
            this.btnAddGraficoPrevDemanda.Enabled = false;
            this.btnAddGraficoPrevDemanda.FlatAppearance.BorderSize = 0;
            this.btnAddGraficoPrevDemanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGraficoPrevDemanda.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGraficoPrevDemanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAddGraficoPrevDemanda.Location = new System.Drawing.Point(855, 172);
            this.btnAddGraficoPrevDemanda.Name = "btnAddGraficoPrevDemanda";
            this.btnAddGraficoPrevDemanda.Size = new System.Drawing.Size(306, 105);
            this.btnAddGraficoPrevDemanda.TabIndex = 5;
            this.btnAddGraficoPrevDemanda.Text = "Adicionar novo gráfico de previsão de demanda (Em breve)";
            this.btnAddGraficoPrevDemanda.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAddGraficoPrevDemanda.UseVisualStyleBackColor = false;
            // 
            // btnSombraConfigUsuario
            // 
            this.btnSombraConfigUsuario.BackColor = System.Drawing.Color.Black;
            this.btnSombraConfigUsuario.BackgroundColor = System.Drawing.Color.Black;
            this.btnSombraConfigUsuario.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSombraConfigUsuario.BorderRadius = 105;
            this.btnSombraConfigUsuario.BorderSize = 0;
            this.btnSombraConfigUsuario.Enabled = false;
            this.btnSombraConfigUsuario.FlatAppearance.BorderSize = 0;
            this.btnSombraConfigUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSombraConfigUsuario.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSombraConfigUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraConfigUsuario.Location = new System.Drawing.Point(855, 539);
            this.btnSombraConfigUsuario.Name = "btnSombraConfigUsuario";
            this.btnSombraConfigUsuario.Size = new System.Drawing.Size(306, 105);
            this.btnSombraConfigUsuario.TabIndex = 12;
            this.btnSombraConfigUsuario.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraConfigUsuario.UseVisualStyleBackColor = false;
            // 
            // btnSombraHistoricoArquivos
            // 
            this.btnSombraHistoricoArquivos.BackColor = System.Drawing.Color.Black;
            this.btnSombraHistoricoArquivos.BackgroundColor = System.Drawing.Color.Black;
            this.btnSombraHistoricoArquivos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSombraHistoricoArquivos.BorderRadius = 105;
            this.btnSombraHistoricoArquivos.BorderSize = 0;
            this.btnSombraHistoricoArquivos.Enabled = false;
            this.btnSombraHistoricoArquivos.FlatAppearance.BorderSize = 0;
            this.btnSombraHistoricoArquivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSombraHistoricoArquivos.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSombraHistoricoArquivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraHistoricoArquivos.Location = new System.Drawing.Point(128, 539);
            this.btnSombraHistoricoArquivos.Name = "btnSombraHistoricoArquivos";
            this.btnSombraHistoricoArquivos.Size = new System.Drawing.Size(306, 105);
            this.btnSombraHistoricoArquivos.TabIndex = 13;
            this.btnSombraHistoricoArquivos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraHistoricoArquivos.UseVisualStyleBackColor = false;
            // 
            // btnSombraVisualizarGraficoPrevDemanda
            // 
            this.btnSombraVisualizarGraficoPrevDemanda.BackColor = System.Drawing.Color.Black;
            this.btnSombraVisualizarGraficoPrevDemanda.BackgroundColor = System.Drawing.Color.Black;
            this.btnSombraVisualizarGraficoPrevDemanda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSombraVisualizarGraficoPrevDemanda.BorderRadius = 105;
            this.btnSombraVisualizarGraficoPrevDemanda.BorderSize = 0;
            this.btnSombraVisualizarGraficoPrevDemanda.Enabled = false;
            this.btnSombraVisualizarGraficoPrevDemanda.FlatAppearance.BorderSize = 0;
            this.btnSombraVisualizarGraficoPrevDemanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSombraVisualizarGraficoPrevDemanda.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSombraVisualizarGraficoPrevDemanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraVisualizarGraficoPrevDemanda.Location = new System.Drawing.Point(855, 295);
            this.btnSombraVisualizarGraficoPrevDemanda.Name = "btnSombraVisualizarGraficoPrevDemanda";
            this.btnSombraVisualizarGraficoPrevDemanda.Size = new System.Drawing.Size(306, 105);
            this.btnSombraVisualizarGraficoPrevDemanda.TabIndex = 14;
            this.btnSombraVisualizarGraficoPrevDemanda.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraVisualizarGraficoPrevDemanda.UseVisualStyleBackColor = false;
            // 
            // btnSombraVisualizarGraficoDistNormal
            // 
            this.btnSombraVisualizarGraficoDistNormal.BackColor = System.Drawing.Color.Black;
            this.btnSombraVisualizarGraficoDistNormal.BackgroundColor = System.Drawing.Color.Black;
            this.btnSombraVisualizarGraficoDistNormal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSombraVisualizarGraficoDistNormal.BorderRadius = 105;
            this.btnSombraVisualizarGraficoDistNormal.BorderSize = 0;
            this.btnSombraVisualizarGraficoDistNormal.Enabled = false;
            this.btnSombraVisualizarGraficoDistNormal.FlatAppearance.BorderSize = 0;
            this.btnSombraVisualizarGraficoDistNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSombraVisualizarGraficoDistNormal.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSombraVisualizarGraficoDistNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraVisualizarGraficoDistNormal.Location = new System.Drawing.Point(128, 295);
            this.btnSombraVisualizarGraficoDistNormal.Name = "btnSombraVisualizarGraficoDistNormal";
            this.btnSombraVisualizarGraficoDistNormal.Size = new System.Drawing.Size(306, 105);
            this.btnSombraVisualizarGraficoDistNormal.TabIndex = 16;
            this.btnSombraVisualizarGraficoDistNormal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraVisualizarGraficoDistNormal.UseVisualStyleBackColor = false;
            // 
            // btnSombraAddGraficoPrevDemanda
            // 
            this.btnSombraAddGraficoPrevDemanda.BackColor = System.Drawing.Color.Black;
            this.btnSombraAddGraficoPrevDemanda.BackgroundColor = System.Drawing.Color.Black;
            this.btnSombraAddGraficoPrevDemanda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSombraAddGraficoPrevDemanda.BorderRadius = 105;
            this.btnSombraAddGraficoPrevDemanda.BorderSize = 0;
            this.btnSombraAddGraficoPrevDemanda.Enabled = false;
            this.btnSombraAddGraficoPrevDemanda.FlatAppearance.BorderSize = 0;
            this.btnSombraAddGraficoPrevDemanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSombraAddGraficoPrevDemanda.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSombraAddGraficoPrevDemanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraAddGraficoPrevDemanda.Location = new System.Drawing.Point(855, 178);
            this.btnSombraAddGraficoPrevDemanda.Name = "btnSombraAddGraficoPrevDemanda";
            this.btnSombraAddGraficoPrevDemanda.Size = new System.Drawing.Size(306, 105);
            this.btnSombraAddGraficoPrevDemanda.TabIndex = 15;
            this.btnSombraAddGraficoPrevDemanda.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraAddGraficoPrevDemanda.UseVisualStyleBackColor = false;
            // 
            // btnSombraAddGraficoDistNormal
            // 
            this.btnSombraAddGraficoDistNormal.BackColor = System.Drawing.Color.Black;
            this.btnSombraAddGraficoDistNormal.BackgroundColor = System.Drawing.Color.Black;
            this.btnSombraAddGraficoDistNormal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSombraAddGraficoDistNormal.BorderRadius = 105;
            this.btnSombraAddGraficoDistNormal.BorderSize = 0;
            this.btnSombraAddGraficoDistNormal.Enabled = false;
            this.btnSombraAddGraficoDistNormal.FlatAppearance.BorderSize = 0;
            this.btnSombraAddGraficoDistNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSombraAddGraficoDistNormal.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSombraAddGraficoDistNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraAddGraficoDistNormal.Location = new System.Drawing.Point(128, 178);
            this.btnSombraAddGraficoDistNormal.Name = "btnSombraAddGraficoDistNormal";
            this.btnSombraAddGraficoDistNormal.Size = new System.Drawing.Size(306, 105);
            this.btnSombraAddGraficoDistNormal.TabIndex = 17;
            this.btnSombraAddGraficoDistNormal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnSombraAddGraficoDistNormal.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbcPerfil);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(440, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 234);
            this.panel1.TabIndex = 20;
            // 
            // btnHistoricoGraficoCEP
            // 
            this.btnHistoricoGraficoCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnHistoricoGraficoCEP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnHistoricoGraficoCEP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHistoricoGraficoCEP.BorderRadius = 105;
            this.btnHistoricoGraficoCEP.BorderSize = 0;
            this.btnHistoricoGraficoCEP.FlatAppearance.BorderSize = 0;
            this.btnHistoricoGraficoCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoricoGraficoCEP.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoricoGraficoCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnHistoricoGraficoCEP.Location = new System.Drawing.Point(855, 406);
            this.btnHistoricoGraficoCEP.Name = "btnHistoricoGraficoCEP";
            this.btnHistoricoGraficoCEP.Size = new System.Drawing.Size(306, 105);
            this.btnHistoricoGraficoCEP.TabIndex = 21;
            this.btnHistoricoGraficoCEP.Text = "Histórico de gráfico de grafico CEP";
            this.btnHistoricoGraficoCEP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnHistoricoGraficoCEP.UseVisualStyleBackColor = false;
            // 
            // techDataButton2
            // 
            this.techDataButton2.BackColor = System.Drawing.Color.Black;
            this.techDataButton2.BackgroundColor = System.Drawing.Color.Black;
            this.techDataButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.techDataButton2.BorderRadius = 105;
            this.techDataButton2.BorderSize = 0;
            this.techDataButton2.Enabled = false;
            this.techDataButton2.FlatAppearance.BorderSize = 0;
            this.techDataButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.techDataButton2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techDataButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.techDataButton2.Location = new System.Drawing.Point(855, 412);
            this.techDataButton2.Name = "techDataButton2";
            this.techDataButton2.Size = new System.Drawing.Size(306, 105);
            this.techDataButton2.TabIndex = 22;
            this.techDataButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.techDataButton2.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarGraficoCEP
            // 
            this.btnAdicionarGraficoCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnAdicionarGraficoCEP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.btnAdicionarGraficoCEP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdicionarGraficoCEP.BorderRadius = 105;
            this.btnAdicionarGraficoCEP.BorderSize = 0;
            this.btnAdicionarGraficoCEP.FlatAppearance.BorderSize = 0;
            this.btnAdicionarGraficoCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarGraficoCEP.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarGraficoCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAdicionarGraficoCEP.Location = new System.Drawing.Point(128, 406);
            this.btnAdicionarGraficoCEP.Name = "btnAdicionarGraficoCEP";
            this.btnAdicionarGraficoCEP.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.btnAdicionarGraficoCEP.Size = new System.Drawing.Size(306, 105);
            this.btnAdicionarGraficoCEP.TabIndex = 23;
            this.btnAdicionarGraficoCEP.Text = "Adicionar e visualizar novo gráfico CEP\r\n\r\n";
            this.btnAdicionarGraficoCEP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.btnAdicionarGraficoCEP.UseVisualStyleBackColor = false;
            // 
            // techDataButton4
            // 
            this.techDataButton4.BackColor = System.Drawing.Color.Black;
            this.techDataButton4.BackgroundColor = System.Drawing.Color.Black;
            this.techDataButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.techDataButton4.BorderRadius = 105;
            this.techDataButton4.BorderSize = 0;
            this.techDataButton4.Enabled = false;
            this.techDataButton4.FlatAppearance.BorderSize = 0;
            this.techDataButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.techDataButton4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techDataButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.techDataButton4.Location = new System.Drawing.Point(128, 412);
            this.techDataButton4.Name = "techDataButton4";
            this.techDataButton4.Size = new System.Drawing.Size(306, 105);
            this.techDataButton4.TabIndex = 24;
            this.techDataButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.techDataButton4.UseVisualStyleBackColor = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnAdicionarGraficoCEP);
            this.Controls.Add(this.techDataButton4);
            this.Controls.Add(this.btnHistoricoGraficoCEP);
            this.Controls.Add(this.techDataButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConfigUsuario);
            this.Controls.Add(this.btnHistoricoArquivos);
            this.Controls.Add(this.btnVisualizarGraficoPrevDemanda);
            this.Controls.Add(this.btnVisualizarGraficoDistNormal);
            this.Controls.Add(this.btnAddGraficoDistNormal);
            this.Controls.Add(this.lklSair);
            this.Controls.Add(this.btnAddGraficoPrevDemanda);
            this.Controls.Add(this.btnSombraConfigUsuario);
            this.Controls.Add(this.btnSombraHistoricoArquivos);
            this.Controls.Add(this.btnSombraVisualizarGraficoPrevDemanda);
            this.Controls.Add(this.btnSombraVisualizarGraficoDistNormal);
            this.Controls.Add(this.btnSombraAddGraficoPrevDemanda);
            this.Controls.Add(this.btnSombraAddGraficoDistNormal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbcPerfil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private techDataButton btnAddGraficoPrevDemanda;
        private System.Windows.Forms.LinkLabel lklSair;
        private techDataButton btnAddGraficoDistNormal;
        private techDataButton btnVisualizarGraficoDistNormal;
        private techDataButton btnVisualizarGraficoPrevDemanda;
        private techDataButton btnHistoricoArquivos;
        private techDataButton btnConfigUsuario;
        private techDataButton btnSombraConfigUsuario;
        private techDataButton btnSombraHistoricoArquivos;
        private techDataButton btnSombraVisualizarGraficoPrevDemanda;
        private techDataButton btnSombraAddGraficoPrevDemanda;
        private techDataButton btnSombraVisualizarGraficoDistNormal;
        private techDataButton btnSombraAddGraficoDistNormal;
        private System.Windows.Forms.PictureBox pbcPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel1;
        private techDataButton btnHistoricoGraficoCEP;
        private techDataButton techDataButton2;
        private techDataButton btnAdicionarGraficoCEP;
        private techDataButton techDataButton4;
    }
}