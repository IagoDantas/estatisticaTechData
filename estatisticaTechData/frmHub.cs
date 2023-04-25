using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estatisticaTechData
{
    public partial class frmHub : Form
    {
        public frmHub()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            UC_HistoricoArquivos HistArquivos = new UC_HistoricoArquivos();
            TabPage TbPage = new TabPage();
            TbPage.Name = "HistArquivos";
            TbPage.Text = "Histórico de arquivos";
            TbPage.Controls.Add(HistArquivos);
            Tbc_Telas.TabPages.Add(TbPage);


            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;
            btnPrevisaoDemanda.BackColor = Color.FromArgb(0, 107, 117);
            btnPrevisaoDemanda.ForeColor = Color.White;
            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
            btnHistorico.BackColor = Color.FromArgb(220, 236, 223);
            btnHistorico.ForeColor = Color.Black;
            btnDistribuicao.Enabled = true;
            btnHistorico.Enabled = false;
            btnPrevisaoDemanda.Enabled = true;
        }

        private void btnPrevisaoDemanda_Click(object sender, EventArgs e)
        {
           
            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;
            btnPrevisaoDemanda.BackColor = Color.FromArgb(220, 236, 223);
            btnPrevisaoDemanda.ForeColor = Color.Black;
            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;
            btnDistribuicao.Enabled = true;
            btnHistorico.Enabled = true;
            btnPrevisaoDemanda.Enabled = false;
        }

        private void btnDistribuicao_Click(object sender, EventArgs e)
        {
            Screens.UC_DistribuicaoNormal DistNormal = new Screens.UC_DistribuicaoNormal();
            TabPage TbPage = new TabPage();
            TbPage.Name = "DistribuicaoNormal";
            TbPage.Text = "Distribuição Normal";
            TbPage.Controls.Add(DistNormal);
            Tbc_Telas.TabPages.Add(TbPage);
            
            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            btnDistribuicao.BackColor = Color.FromArgb(220, 236, 223);
            btnDistribuicao.ForeColor = Color.Black;
            btnPrevisaoDemanda.BackColor = Color.FromArgb(0, 107, 117);
            btnPrevisaoDemanda.ForeColor = Color.White;
            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;
            btnDistribuicao.Enabled = false;
            btnHistorico.Enabled = true;
            btnPrevisaoDemanda.Enabled = true;
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
                    ApagaAba(Tbc_Telas.SelectedTab);
                }
            }
            void ToolTipApagarTodasAsAbas_Click(object sender1, EventArgs e1)
            {
                if (!(Tbc_Telas.SelectedTab == null))
                {
                    int SelectedTab = Tbc_Telas.SelectedIndex;
                    ApagaDireita(SelectedTab);
                    ApagaEsquerda(SelectedTab);
                }
            }

            ToolStripMenuItem DesenhaItemMenu(string text)
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = text;

                return vToolTip;
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
        void ApagaAba(TabPage Tb)
        {
            Tbc_Telas.TabPages.Remove(Tb);
        }
    }
}
