﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estatisticaTechData.Screens
{
    public partial class UC_DistribuicaoNormal : UserControl
    {
        public UC_DistribuicaoNormal()
        {
            InitializeComponent();
        }

        private void btnAcessoHistorico_Click(object sender, EventArgs e)
        {
            frmHistoricoDistNormal hist = new frmHistoricoDistNormal();
            hist.Show();
        }

        private void btnNovaBase_Click(object sender, EventArgs e)
        {
            testes pag = new testes();
            pag.Show();
        }
    }
}