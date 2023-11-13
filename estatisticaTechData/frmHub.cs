using estatisticaTechData.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace estatisticaTechData
{
    public partial class frmHub : Form
    {
        public static frmHub funEstancia;
        int ControleDistribuicaoNormal = 0;
        int ControleHistoricoArquivoDistNormal = 0;
        int ControleHistoricoDistNormal = 0;
        int ControleConfig = 0;
        int ControleCompara = 0;
        int ControleCEP = 0; 
        int ControleBackgroundDist = 0;
        int ControleBackgroundAtributo = 0;
        int ControleBackgroundVariavel = 0;
        int ControleCEPVariavel = 0;
        int ControleCEPAtributo = 0;
        int ControleInicio = 0;
        public string emailUser;

        public frmHub(string email)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            funEstancia = this;
            emailUser = email;
        }


        public void abrirHist()
        {
            if (ControleHistoricoDistNormal == 0)
            {
                ControleHistoricoDistNormal += 1;
                UC_HistoricoDistribuicaoNormal HistDistNormal = new UC_HistoricoDistribuicaoNormal();
                HistDistNormal.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "HistoricoDistribuicaoNormal";
                TbPage.Text = "Historico Distribuição Normal";
                TbPage.Controls.Add(HistDistNormal);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
            else
            {
                guia("HistoricoDistribuicaoNormal");
                MessageBox.Show("Já existem abas de histórico distribuição normal abertas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnInicio.Enabled = true;

        }

        public void abrirBackgroundDist()
        {
            if (ControleBackgroundDist == 0)
            {
                ControleBackgroundDist += 1;
                UC_BackgroundDist Teste = new UC_BackgroundDist();
                Teste.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "BackgroundDist";
                TbPage.Text = "Background";
                TbPage.Controls.Add(Teste);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
        }
        public void abrirBackgroundAtributos()
        {
            if (ControleBackgroundAtributo == 0)
            {
                ControleBackgroundAtributo += 1;
                UC_BackgroundAtributos Teste = new UC_BackgroundAtributos();
                Teste.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "BackgroundAtributo";
                TbPage.Text = "Background";
                TbPage.Controls.Add(Teste);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
        }
        public void abrirBackgroundVariaveis()
        {
            if (ControleBackgroundVariavel == 0)
            {
                ControleBackgroundVariavel += 1;
                UC_BackgroundVariaveis Teste = new UC_BackgroundVariaveis();
                Teste.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "BackgroundVariavel";
                TbPage.Text = "Background";
                TbPage.Controls.Add(Teste);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
        }
        public void abrirCEPVariavel()
        {
            if (ControleCEPVariavel == 0)
            {
                ControleCEPVariavel += 1;
                UC_controlVariaveis Teste = new UC_controlVariaveis();
                Teste.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "ControleDeVariaveis";
                TbPage.Text = "Controle De Variáveis";
                TbPage.Controls.Add(Teste);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
            else
            {
                guia("ControleDeVariaveis");
                MessageBox.Show("Já existem abas de Controle De Variáveis", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnInicio.Enabled = true;

        }
        public void abrirCEPAtributo()
        {
            if (ControleCEPAtributo == 0)
            {
                ControleCEPAtributo += 1;
                UC_controlAtributos Teste = new UC_controlAtributos();
                Teste.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "ControleDeAtributos";
                TbPage.Text = "Controle De Atributos";
                TbPage.Controls.Add(Teste);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
            else
            {
                guia("ControleDeAtributos");
                MessageBox.Show("Já existem abas de Controle De Atributos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnInicio.Enabled = true;

        }

        public void abrirCompara()
        {
            if (ControleCompara == 0)
            {
                ControleCompara += 1;
                UC_DistribuicaoNormalComparacao compara = new UC_DistribuicaoNormalComparacao();
                compara.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "ComparacaoDistribuicaoNormal";
                TbPage.Text = "Comparacao Distribuição Normal";
                TbPage.Controls.Add(compara);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
            else
            {
                guia("ComparacaoDistribuicaoNormal");
                MessageBox.Show("Já existem abas de comparação abertas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;

            btnDistribuicao.BackColor = Color.FromArgb(220, 236, 223);
            btnDistribuicao.ForeColor = Color.Black;


            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;

            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;

            btnDistribuicao.Enabled = false;
            btnInicio.Enabled = true;

            btnHistorico.Enabled = true;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            if (ControleHistoricoArquivoDistNormal == 0)
            {
                ControleHistoricoArquivoDistNormal += 1;
                UC_HistoricoArquivos HistArquivos = new UC_HistoricoArquivos();
                HistArquivos.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "HistArquivos";
                TbPage.Text = "Histórico de arquivos";
                TbPage.Controls.Add(HistArquivos);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
            else
            {
                guia("HistArquivos");
                MessageBox.Show("Já existem abas de histórico de arquivos abertas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;

            btnCEP.BackColor = Color.FromArgb(0, 107, 117);
            btnCEP.ForeColor = Color.White;

            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;


            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;

            btnHistorico.BackColor = Color.FromArgb(220, 236, 223);
            btnHistorico.ForeColor = Color.Black;

            btnDistribuicao.Enabled = true;
            btnCEP.Enabled = true;
            btnInicio.Enabled = true;

            btnConfig.Enabled = true;
            btnHistorico.Enabled = false;
        }

        private void btnPrevisaoDemanda_Click(object sender, EventArgs e)
        {
           
            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;
            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;
            btnDistribuicao.Enabled = true;
            btnInicio.Enabled = true;

        }

        private void btnDistribuicao_Click(object sender, EventArgs e)
        {
            abrirBackgroundDist();
            if(ControleDistribuicaoNormal == 0)
            {
                ControleDistribuicaoNormal += 1;
                Screens.UC_DistribuicaoNormal DistNormal = new Screens.UC_DistribuicaoNormal();
                DistNormal.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "DistribuicaoNormal";
                TbPage.Text = "Distribuição Normal";
                TbPage.Controls.Add(DistNormal);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
            else
            {
                guia("DistribuicaoNormal");
                MessageBox.Show("Já existem abas de distribuição normal abertas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;

            btnDistribuicao.BackColor = Color.FromArgb(220, 236, 223);
            btnDistribuicao.ForeColor = Color.Black;


            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;

            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;

            btnCEP.BackColor = Color.FromArgb(0, 107, 117);
            btnCEP.ForeColor = Color.White;


            btnDistribuicao.Enabled = false;
            btnHistorico.Enabled = true;
            btnInicio.Enabled = true;

            btnCEP.Enabled = true;
            btnConfig.Enabled = true;
        }

        private void Tbc_Telas_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Right)
            {
                /*MessageBox.Show("Direito " + PosicaoX + " " + PosicaoY);*/

                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("Apagar aba selecionada");
                var vToolTip002 = DesenhaItemMenu("Apagar todas as abas menos a selecionada");

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new System.EventHandler(ToolTipApagarAbaSelecionada_Click);
                vToolTip002.Click += new System.EventHandler(ToolTipApagarTodasAsAbas_Click);
            }

            void ToolTipApagarAbaSelecionada_Click(object sender1, EventArgs e1)
            {
                if (!(Tbc_Telas.SelectedTab == null))
                {
                    int var = confereAba(Tbc_Telas.SelectedTab);
                    if(var == 1)
                    {
                        int SelectedTab = Tbc_Telas.SelectedIndex-1;
                        if(SelectedTab >=0)
                            ApagaAba(Tbc_Telas.TabPages[SelectedTab]);
                        if (Tbc_Telas.TabCount == 0)
                        {

                        }
                    }
                    if (var == 2)
                    {
                        
                        int SelectedTab = Tbc_Telas.SelectedIndex + 1;
                        if(SelectedTab<Tbc_Telas.TabCount)
                            ApagaAba(Tbc_Telas.TabPages[SelectedTab]);
                        if (Tbc_Telas.TabCount == 0)
                        {

                        }
                    }
                    ApagaAba(Tbc_Telas.SelectedTab);
                    if (Tbc_Telas.TabCount == 0)
                    {
                        
                    }
                }
                
            }

            
            void ToolTipApagarTodasAsAbas_Click(object sender1, EventArgs e1)
            {
                if (!(Tbc_Telas.SelectedTab == null))
                {
                    int SelectedTab = Tbc_Telas.SelectedIndex;
                    int var = confereAba(Tbc_Telas.SelectedTab);
                    if(var == 1)
                    {
                        ApagaDireita(SelectedTab);
                        if (SelectedTab > 0)
                        {
                            int abaAnterior = SelectedTab - 1;
                            ApagaEsquerda(abaAnterior);
                        }
                    }
                    else if (var == 2)
                    {
                        ApagaEsquerda(SelectedTab);
                        if(SelectedTab < Tbc_Telas.TabCount - 1)
                        {
                            int abaPosterior = SelectedTab + 1;
                            ApagaDireita(abaPosterior);
                        }
                    }
                    else
                    {
                        ApagaDireita(SelectedTab);
                        ApagaEsquerda(SelectedTab);
                    }
                }
            }

            ToolStripMenuItem DesenhaItemMenu(string text)
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = text;

                return vToolTip;
            }

            int confereAba(TabPage Tb)
            {
                int var = 0;
                if (Tb.Name == "ControleDeVariaveis" || Tb.Name == "ControleDeAtributos" || Tb.Name == "DistribuicaoNormal")
                    var = 1;
                if(Tb.Name == "BackgroundDist" || Tb.Name == "BackgroundAtributo" || Tb.Name == "BackgroundVariavel")
                    var = 2;
                return var;
            }

        }
        public void apagarAbaSelecionada()
        {
            if (!(Tbc_Telas.SelectedTab == null))
            {
                int var = confereAba(Tbc_Telas.SelectedTab);
                if (var == 1)
                {
                    int SelectedTab = Tbc_Telas.SelectedIndex - 1;
                    if (SelectedTab >= 0)
                        ApagaAba(Tbc_Telas.TabPages[SelectedTab]);
                    if (Tbc_Telas.TabCount == 0)
                    {

                    }
                }
                if (var == 2)
                {

                    int SelectedTab = Tbc_Telas.SelectedIndex + 1;
                    if (SelectedTab < Tbc_Telas.TabCount)
                        ApagaAba(Tbc_Telas.TabPages[SelectedTab]);
                    if (Tbc_Telas.TabCount == 0)
                    {

                    }
                }
                ApagaAba(Tbc_Telas.SelectedTab);
                if (Tbc_Telas.TabCount == 0)
                {

                }
            }

            int confereAba(TabPage Tb)
            {
                int var = 0;
                if (Tb.Name == "ControleDeVariaveis" || Tb.Name == "ControleDeAtributos" || Tb.Name == "DistribuicaoNormal")
                    var = 1;
                if (Tb.Name == "BackgroundDist" || Tb.Name == "BackgroundAtributo" || Tb.Name == "BackgroundVariavel")
                    var = 2;
                return var;
            }
        }
        void ApagaDireita(int ItemSelecionado)
        {
            for (int i = Tbc_Telas.TabPages.Count - 1; i > ItemSelecionado; i += -1)
            {
                ApagaAba(Tbc_Telas.TabPages[i]);
            }
        }
        void ApagaEsquerda(int ItemSelecionado)
        {
            for (int i = ItemSelecionado - 1; i >= 0; i += -1)
            {
                ApagaAba(Tbc_Telas.TabPages[i]);
            }
        }
        public void ApagaAba(TabPage Tb)
        {
            if (Tb.Name == "HistoricoDistribuicaoNormal")
            {
                ControleHistoricoDistNormal = 0;
            }
            if (Tb.Name == "BackgroundDist")
            {
                ControleBackgroundDist = 0;
            }
            if (Tb.Name == "BackgroundAtributo")
            {
                ControleBackgroundAtributo = 0;
            }
            if (Tb.Name == "BackgroundVariavel")
            {
                ControleBackgroundVariavel = 0;
            }
            if (Tb.Name == "ComparacaoDistribuicaoNormal")
            {
                ControleCompara = 0;
            }
            if (Tb.Name == "HistArquivos")
            {
                ControleHistoricoArquivoDistNormal = 0;
            }
            if (Tb.Name == "DistribuicaoNormal")
            {
                ControleDistribuicaoNormal = 0;
            }
            if (Tb.Name == "Configuracoes")
            {
                ControleConfig = 0;
            }
            if (Tb.Name == "GraficoCEP")
            {
                ControleCEP = 0;
            }
            if (Tb.Name == "ControleDeVariaveis")
            {
                ControleCEPVariavel = 0;
            }
            if (Tb.Name == "ControleDeAtributos")
            {
                ControleCEPAtributo = 0;
            }
            if (Tb.Name == "Inicio")
            {
                ControleInicio = 0;
            }

            Tbc_Telas.TabPages.Remove(Tb);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (ControleConfig == 0)
            {
                ControleConfig += 1;
                UC_Configuracao Config = new UC_Configuracao();
                Config.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "Configuracoes";
                TbPage.Text = "Configuracoes";
                TbPage.Controls.Add(Config);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
            else
            {
                guia("Configuracoes");
            }

            btnConfig.BackColor = Color.FromArgb(220, 236, 223);
            btnConfig.ForeColor = Color.Black;

            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;


            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;

            btnCEP.BackColor = Color.FromArgb(0, 107, 117);
            btnCEP.ForeColor = Color.White;

            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;


            btnCEP.Enabled = true;
            btnInicio.Enabled = true;

            btnDistribuicao.Enabled = true;
            btnHistorico.Enabled = true;
            btnConfig.Enabled = false;
        }

        private void btnCEP_Click(object sender, EventArgs e)
        {
            if (ControleCEP == 0)
            {
                ControleCEP += 1;
                Screens.UC_CEP CEP = new Screens.UC_CEP();
                CEP.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "GraficoCEP";
                TbPage.Text = "Gráfico CEP";
                TbPage.Controls.Add(CEP);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
            else
            {
                guia("GraficoCEP");
            }

            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;
            btnCEP.BackColor = Color.FromArgb(220, 236, 223);
            btnCEP.ForeColor = Color.Black;
            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;
            btnCEP.Enabled = false;
            btnInicio.Enabled = true;
            btnDistribuicao.Enabled = true;
            btnHistorico.Enabled = true;
        }

        private void btnHistGraph_Click(object sender, EventArgs e)
        {
            abrirHist();
        }

        public void guia(string guia)
        {
            TabPage guiaDesejada = Tbc_Telas.TabPages[guia];

            // Verifica se a guia foi encontrada
            if (guiaDesejada != null)
            {
                // Define a guia encontrada como a guia selecionada
                Tbc_Telas.SelectedTab = guiaDesejada;
            }
        }

        private void frmHub_Load(object sender, EventArgs e)
        {

            ControleInicio += 1;
            Screens.UC_Inicio Inicio = new Screens.UC_Inicio();
            Inicio.Dock = DockStyle.Fill;
            TabPage TbPage = new TabPage();
            TbPage.Name = "Inicio";
            TbPage.Text = "Início";
            TbPage.Controls.Add(Inicio);
            Tbc_Telas.TabPages.Add(TbPage);
            Tbc_Telas.SelectedTab = TbPage;

            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;


            btnCEP.BackColor = Color.FromArgb(0, 107, 117);
            btnCEP.ForeColor = Color.White;

            btnInicio.BackColor = Color.FromArgb(220, 236, 223);
            btnInicio.ForeColor = Color.Black;

            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;
            btnInicio.Enabled = false;
            btnCEP.Enabled = true;
            btnDistribuicao.Enabled = true;
            btnHistorico.Enabled = true;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (ControleInicio == 0)
            {
                ControleInicio += 1;

                Screens.UC_Inicio Inicio = new Screens.UC_Inicio();
                Inicio.Dock = DockStyle.Fill;
                TabPage TbPage = new TabPage();
                TbPage.Name = "Inicio";
                TbPage.Text = "Início";
                TbPage.Controls.Add(Inicio);
                Tbc_Telas.TabPages.Add(TbPage);
                Tbc_Telas.SelectedTab = TbPage;
            }
            else
            {
                guia("Inicio");
            }

            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;


            btnCEP.BackColor = Color.FromArgb(0, 107, 117);
            btnCEP.ForeColor = Color.White;

            btnInicio.BackColor = Color.FromArgb(220, 236, 223);
            btnInicio.ForeColor = Color.Black;

           
            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;
            btnInicio.Enabled = true;
            btnCEP.Enabled = true;
            btnDistribuicao.Enabled = true;
            btnHistorico.Enabled = true;
        }
    }
}
