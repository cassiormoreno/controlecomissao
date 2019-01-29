namespace controleComissao
{
    partial class ucComissao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txttotalComissao = new System.Windows.Forms.TextBox();
            this.lbltotalComissao = new System.Windows.Forms.Label();
            this.txtpercentualComissao = new System.Windows.Forms.TextBox();
            this.lblpercentualComissao = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblcodigoVendedor = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtLancamento = new System.Windows.Forms.TextBox();
            this.lblLancamento = new System.Windows.Forms.Label();
            this.gpbOpcoes.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.BackColor = System.Drawing.Color.White;
            this.gpbOpcoes.Controls.Add(this.btnFechar);
            this.gpbOpcoes.Controls.Add(this.btnPesquisar);
            this.gpbOpcoes.Controls.Add(this.lblTitulo);
            this.gpbOpcoes.Controls.Add(this.btnCancelar);
            this.gpbOpcoes.Controls.Add(this.btnSalvar);
            this.gpbOpcoes.Controls.Add(this.btnNovo);
            this.gpbOpcoes.Location = new System.Drawing.Point(17, 3);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(481, 79);
            this.gpbOpcoes.TabIndex = 1;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Opções";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.Image = global::controleComissao.Properties.Resources.Sair;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(279, 19);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(67, 51);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::controleComissao.Properties.Resources.search;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(143, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(68, 51);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(365, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(115, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Comissão";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::controleComissao.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(211, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 51);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "C&ancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Image = global::controleComissao.Properties.Resources.save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(75, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(68, 51);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.Image = global::controleComissao.Properties.Resources.insert;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(7, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(68, 51);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gpbDados
            // 
            this.gpbDados.BackColor = System.Drawing.Color.White;
            this.gpbDados.Controls.Add(this.txttotalComissao);
            this.gpbDados.Controls.Add(this.lbltotalComissao);
            this.gpbDados.Controls.Add(this.txtpercentualComissao);
            this.gpbDados.Controls.Add(this.lblpercentualComissao);
            this.gpbDados.Controls.Add(this.txtValor);
            this.gpbDados.Controls.Add(this.lblValor);
            this.gpbDados.Controls.Add(this.mskData);
            this.gpbDados.Controls.Add(this.lblData);
            this.gpbDados.Controls.Add(this.lblcodigoVendedor);
            this.gpbDados.Controls.Add(this.cmbVendedor);
            this.gpbDados.Controls.Add(this.lblVendedor);
            this.gpbDados.Controls.Add(this.txtLancamento);
            this.gpbDados.Controls.Add(this.lblLancamento);
            this.gpbDados.Location = new System.Drawing.Point(15, 86);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(483, 130);
            this.gpbDados.TabIndex = 2;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados";
            // 
            // txttotalComissao
            // 
            this.txttotalComissao.Location = new System.Drawing.Point(275, 101);
            this.txttotalComissao.MaxLength = 4;
            this.txttotalComissao.Name = "txttotalComissao";
            this.txttotalComissao.ReadOnly = true;
            this.txttotalComissao.Size = new System.Drawing.Size(63, 20);
            this.txttotalComissao.TabIndex = 12;
            // 
            // lbltotalComissao
            // 
            this.lbltotalComissao.AutoSize = true;
            this.lbltotalComissao.Location = new System.Drawing.Point(187, 104);
            this.lbltotalComissao.Name = "lbltotalComissao";
            this.lbltotalComissao.Size = new System.Drawing.Size(82, 13);
            this.lbltotalComissao.TabIndex = 11;
            this.lbltotalComissao.Text = "Total Comissão:";
            // 
            // txtpercentualComissao
            // 
            this.txtpercentualComissao.Enabled = false;
            this.txtpercentualComissao.Location = new System.Drawing.Point(78, 101);
            this.txtpercentualComissao.MaxLength = 4;
            this.txtpercentualComissao.Name = "txtpercentualComissao";
            this.txtpercentualComissao.Size = new System.Drawing.Size(63, 20);
            this.txtpercentualComissao.TabIndex = 10;
            // 
            // lblpercentualComissao
            // 
            this.lblpercentualComissao.AutoSize = true;
            this.lblpercentualComissao.Location = new System.Drawing.Point(10, 104);
            this.lblpercentualComissao.Name = "lblpercentualComissao";
            this.lblpercentualComissao.Size = new System.Drawing.Size(66, 13);
            this.lblpercentualComissao.TabIndex = 9;
            this.lblpercentualComissao.Text = "% Comissão:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(224, 72);
            this.txtValor.MaxLength = 4;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(63, 20);
            this.txtValor.TabIndex = 8;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(189, 75);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor:";
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(78, 71);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(71, 20);
            this.mskData.TabIndex = 6;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(10, 75);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data:";
            // 
            // lblcodigoVendedor
            // 
            this.lblcodigoVendedor.BackColor = System.Drawing.Color.White;
            this.lblcodigoVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcodigoVendedor.Location = new System.Drawing.Point(374, 45);
            this.lblcodigoVendedor.Name = "lblcodigoVendedor";
            this.lblcodigoVendedor.Size = new System.Drawing.Size(76, 21);
            this.lblcodigoVendedor.TabIndex = 4;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(78, 45);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(282, 21);
            this.cmbVendedor.TabIndex = 3;
            this.cmbVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbVendedor_SelectedIndexChanged);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(7, 49);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // txtLancamento
            // 
            this.txtLancamento.Enabled = false;
            this.txtLancamento.Location = new System.Drawing.Point(78, 19);
            this.txtLancamento.MaxLength = 4;
            this.txtLancamento.Name = "txtLancamento";
            this.txtLancamento.Size = new System.Drawing.Size(100, 20);
            this.txtLancamento.TabIndex = 1;
            // 
            // lblLancamento
            // 
            this.lblLancamento.AutoSize = true;
            this.lblLancamento.Location = new System.Drawing.Point(7, 22);
            this.lblLancamento.Name = "lblLancamento";
            this.lblLancamento.Size = new System.Drawing.Size(69, 13);
            this.lblLancamento.TabIndex = 0;
            this.lblLancamento.Text = "Lançamento:";
            // 
            // ucComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbDados);
            this.Controls.Add(this.gpbOpcoes);
            this.Name = "ucComissao";
            this.Size = new System.Drawing.Size(510, 224);
            this.Load += new System.EventHandler(this.ucComissao_Load);
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label lblcodigoVendedor;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtLancamento;
        private System.Windows.Forms.Label lblLancamento;
        private System.Windows.Forms.TextBox txtpercentualComissao;
        private System.Windows.Forms.Label lblpercentualComissao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txttotalComissao;
        private System.Windows.Forms.Label lbltotalComissao;
        private System.Windows.Forms.Button btnFechar;
    }
}
