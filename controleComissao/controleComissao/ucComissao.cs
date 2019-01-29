using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleComissao
{
    public partial class ucComissao : UserControl
    {
        public ucComissao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gpbDados.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            limpar();
        }

        private void limpar()
        {
            foreach (Control ctl in gpbDados.Controls)
            {
                if (ctl is TextBox) ctl.Text = "";
                if (ctl is MaskedTextBox) ctl.Text = "";
                if (ctl is ComboBox) ctl.Text = "";
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            gpbDados.Enabled = true;
            btnNovo.Tag = "Incluir";
            cmbVendedor.Focus();
        }

        private void ucComissao_Load(object sender, EventArgs e)
        {
            clsVendedor classeVendedor = new clsVendedor();
            cmbVendedor.DataSource = classeVendedor.pesquisaNome("");
            cmbVendedor.ValueMember = "codigo"; // identifica a chave primária
            cmbVendedor.DisplayMember = "nome_Vendedor"; // identifica qual coluna será listada
            cmbVendedor.SelectedIndex = -1; // Não faz a listagem de nenhum nome. Se for igual a 0, será listado o primeiro nome
            lblcodigoVendedor.Text = ""; // Apaga o conteúdo deste label
            btnCancelar_Click(sender, e);
        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void selecionaVendedor()
        {
            if (cmbVendedor.SelectedValue != null)
            {
                lblcodigoVendedor.Text = cmbVendedor.SelectedValue.ToString();

                clsVendedor classeVendedor = new clsVendedor();
                DataRow linha = classeVendedor.pesquisaNome(cmbVendedor.Text).Rows[0];
                txtpercentualComissao.Text = linha["percentual_Comissao"].ToString();
            }
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            selecionaVendedor();            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPComissao pesquisar = new frmPComissao();
            pesquisar.ShowDialog();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) 
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }

        private void calculaTotalComissao()
        {
            double valorVenda = Convert.ToDouble(txtValor.Text);
            double percentualComissao = Convert.ToDouble(txtpercentualComissao.Text);
            double totalComissao = (valorVenda * percentualComissao) / 100;
            txttotalComissao.Text = string.Format("{0:C}", totalComissao);
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            calculaTotalComissao();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar ?","Salvar",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if(txtValor.Text.Length==0)
                {
                    MessageBox.Show("Informe o Valor da Comissão", "Valor", MessageBoxButtons.OK);
                    txtValor.Focus();
                    return;
                }

                if(txtpercentualComissao.Text.Length==0)
                {
                    MessageBox.Show("Informe o % da Comissão", "% da Comissão", MessageBoxButtons.OK);
                    txtpercentualComissao.Focus();
                    return;
                }

                if(lblcodigoVendedor.Text.Length==0)
                {
                    MessageBox.Show("Selecione o Vendedor", "Vendedor", MessageBoxButtons.OK);
                    cmbVendedor.Focus();
                    return;
                }

                calculaTotalComissao();

                try
                {
                    clsComissao classeComissao = new clsComissao();
                    classeComissao.inserir(Convert.ToInt32(lblcodigoVendedor.Text), Convert.ToDateTime(mskData.Text), Convert.ToDecimal(txtValor.Text), Convert.ToDecimal(txtpercentualComissao.Text));
                    MessageBox.Show("Comissão incluída com sucesso!", "Comissão", MessageBoxButtons.OK);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
