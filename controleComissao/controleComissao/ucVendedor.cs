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
    public partial class ucVendedor : UserControl
    {
        public ucVendedor()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            gpbDados.Enabled = true;
            txtVendedor.Focus();
            chkSituacao.Checked = true;//Marca o checkbox
            chkSituacao.Text = "Ativo"; // Altera o texto para Ativo
            chkSituacao.Enabled = false;// Desabilita o checkbox
            btnNovo.Tag = "Incluir";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true; // Habilita o botão novo
            gpbDados.Enabled = false;
            limpar(); //Chama a rotina limpar
            chkSituacao.Text = "";
            chkSituacao.Checked = false;
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Deseja Salvar?", "Salvar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clsVendedor classeVendedor = new clsVendedor();
                if (btnNovo.Tag.ToString()=="Incluir")
                {
                    classeVendedor.salvar(txtVendedor.Text, Convert.ToDecimal(txtpercentualComissao.Text), chkSituacao.Checked);
                MessageBox.Show("Vendedor inserido com sucesso!");
                }
                else
                {
                    classeVendedor.alterar(Convert.ToInt32(txtCodigo.Text),txtVendedor.Text, Convert.ToDecimal(txtpercentualComissao.Text), chkSituacao.Checked);
                    MessageBox.Show("Vendedor alterado com sucesso!");
                }
                exibirGrid();
                btnCancelar_Click(sender, e); // Chama esta subrotina               
            }
        }
        private void cabecalho()
        {
            dgvVendedor.Columns[0].HeaderText = "Código";
            dgvVendedor.Columns[0].Width = 45;
            dgvVendedor.Columns[1].HeaderText = "Vendedor";
            dgvVendedor.Columns[1].Width = 210;
            dgvVendedor.Columns[2].HeaderText = "% Comissão";
            dgvVendedor.Columns[2].Width = 60;
            dgvVendedor.Columns[3].HeaderText = "Situação";
            dgvVendedor.Columns[3].Width = 60;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void exibirGrid()
        {
            clsVendedor classeVendedor = new clsVendedor();
            dgvVendedor.DataSource = classeVendedor.pesquisaNome("");

        }

        private void ucVendedor_Load(object sender, EventArgs e)
        {
            exibirGrid(); // Chama a subrotina para exibir os dados cadastrados na tabela
            cabecalho(); // Chama a subrotina que formata a largura e o título de cada coluna
            btnCancelar_Click(sender, e); // Executa a codificação referente ao botão cancelar
        }

        private void dgvVendedor_DoubleClick(object sender, EventArgs e)
        {
            txtCodigo.Text = dgvVendedor.CurrentRow.Cells[0].Value.ToString();
            txtVendedor.Text = dgvVendedor.CurrentRow.Cells[1].Value.ToString();
            txtpercentualComissao.Text = dgvVendedor.CurrentRow.Cells[2].Value.ToString();
            chkSituacao.Checked =  Convert.ToBoolean(dgvVendedor.CurrentRow.Cells[3].Value);
            if(chkSituacao.Checked)
                chkSituacao.Text = "Ativo";
            else
                chkSituacao.Text = "Inativo";
            gpbDados.Enabled = true; // Habilita o groupbox para permitir a edição dos dados
            btnNovo.Enabled = false; // Desabilita o botão novo
            btnSalvar.Enabled = true; // Habilita o botão salvar
            btnNovo.Tag = "Editar"; // Permite a edição dos dados na tabela de vendedor
            txtVendedor.Focus(); // Coloca o foco na caixa vendedor
        }

        private void chkSituacao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSituacao.Checked) // Se o checkbox estiver selecionado
                chkSituacao.Text = "Ativo";
            else
                chkSituacao.Text = "Inativo";
        }
    }
}
