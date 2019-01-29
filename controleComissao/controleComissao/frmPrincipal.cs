﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleComissao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlDados.Controls.Clear();
            ucComissao comissao = new ucComissao();
            pnlDados.Controls.Add(comissao);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            pnlDados.Controls.Clear();
            ucVendedor vendedor = new ucVendedor();
            pnlDados.Controls.Add(vendedor);
        }
    }
}
