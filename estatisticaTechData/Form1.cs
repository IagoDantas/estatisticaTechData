﻿using System;
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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void lklSignUp_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.Show();
            this.Visible = false;
        }

        private void txtUsers_Enter(object sender, EventArgs e)
        {
            txtUsers.Text = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void techDataTextBox1__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text Changed");
        }
    }
}
