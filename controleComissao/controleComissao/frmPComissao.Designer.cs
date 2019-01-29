namespace controleComissao
{
    partial class frmPComissao
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
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.rbLancamento = new System.Windows.Forms.RadioButton();
            this.lblLancamento = new System.Windows.Forms.Label();
            this.txtLancamento = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.lbldataInicial = new System.Windows.Forms.Label();
            this.mskdataInicial = new System.Windows.Forms.MaskedTextBox();
            this.mskdataFinal = new System.Windows.Forms.MaskedTextBox();
            this.lbldataFinal = new System.Windows.Forms.Label();
            this.gpbExibir = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gpbOpcoes.SuspendLayout();
            this.gpbExibir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbTodos);
            this.gpbOpcoes.Controls.Add(this.rbData);
            this.gpbOpcoes.Controls.Add(this.rbVendedor);
            this.gpbOpcoes.Controls.Add(this.rbLancamento);
            this.gpbOpcoes.Location = new System.Drawing.Point(15, 12);
            this.gpbOpcoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbOpcoes.Size = new System.Drawing.Size(200, 163);
            this.gpbOpcoes.TabIndex = 0;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Opções";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(9, 126);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(71, 24);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(9, 95);
            this.rbData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(62, 24);
            this.rbData.TabIndex = 2;
            this.rbData.TabStop = true;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Location = new System.Drawing.Point(9, 64);
            this.rbVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(97, 24);
            this.rbVendedor.TabIndex = 1;
            this.rbVendedor.TabStop = true;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            // 
            // rbLancamento
            // 
            this.rbLancamento.AutoSize = true;
            this.rbLancamento.Location = new System.Drawing.Point(9, 29);
            this.rbLancamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbLancamento.Name = "rbLancamento";
            this.rbLancamento.Size = new System.Drawing.Size(116, 24);
            this.rbLancamento.TabIndex = 0;
            this.rbLancamento.TabStop = true;
            this.rbLancamento.Text = "Lançamento";
            this.rbLancamento.UseVisualStyleBackColor = true;
            // 
            // lblLancamento
            // 
            this.lblLancamento.AutoSize = true;
            this.lblLancamento.Location = new System.Drawing.Point(246, 18);
            this.lblLancamento.Name = "lblLancamento";
            this.lblLancamento.Size = new System.Drawing.Size(102, 20);
            this.lblLancamento.TabIndex = 1;
            this.lblLancamento.Text = "Lançamento:";
            // 
            // txtLancamento
            // 
            this.txtLancamento.Location = new System.Drawing.Point(246, 40);
            this.txtLancamento.Name = "txtLancamento";
            this.txtLancamento.Size = new System.Drawing.Size(100, 26);
            this.txtLancamento.TabIndex = 2;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(246, 73);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(83, 20);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(246, 91);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(355, 28);
            this.cmbVendedor.TabIndex = 4;
            // 
            // lbldataInicial
            // 
            this.lbldataInicial.AutoSize = true;
            this.lbldataInicial.Location = new System.Drawing.Point(246, 126);
            this.lbldataInicial.Name = "lbldataInicial";
            this.lbldataInicial.Size = new System.Drawing.Size(92, 20);
            this.lbldataInicial.TabIndex = 5;
            this.lbldataInicial.Text = "Data Inicial:";
            // 
            // mskdataInicial
            // 
            this.mskdataInicial.Location = new System.Drawing.Point(246, 150);
            this.mskdataInicial.Mask = "00/00/0000";
            this.mskdataInicial.Name = "mskdataInicial";
            this.mskdataInicial.Size = new System.Drawing.Size(100, 26);
            this.mskdataInicial.TabIndex = 6;
            this.mskdataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // mskdataFinal
            // 
            this.mskdataFinal.Location = new System.Drawing.Point(371, 150);
            this.mskdataFinal.Mask = "00/00/0000";
            this.mskdataFinal.Name = "mskdataFinal";
            this.mskdataFinal.Size = new System.Drawing.Size(100, 26);
            this.mskdataFinal.TabIndex = 8;
            this.mskdataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // lbldataFinal
            // 
            this.lbldataFinal.AutoSize = true;
            this.lbldataFinal.Location = new System.Drawing.Point(367, 126);
            this.lbldataFinal.Name = "lbldataFinal";
            this.lbldataFinal.Size = new System.Drawing.Size(86, 20);
            this.lbldataFinal.TabIndex = 7;
            this.lbldataFinal.Text = "Data Final:";
            // 
            // gpbExibir
            // 
            this.gpbExibir.Controls.Add(this.btnFechar);
            this.gpbExibir.Controls.Add(this.btnExibir);
            this.gpbExibir.Location = new System.Drawing.Point(607, 31);
            this.gpbExibir.Name = "gpbExibir";
            this.gpbExibir.Size = new System.Drawing.Size(146, 144);
            this.gpbExibir.TabIndex = 9;
            this.gpbExibir.TabStop = false;
            this.gpbExibir.Text = "Exibir";
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::controleComissao.Properties.Resources.Sair;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(18, 81);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(104, 51);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Image = global::controleComissao.Properties.Resources.search;
            this.btnExibir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExibir.Location = new System.Drawing.Point(18, 24);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(104, 51);
            this.btnExibir.TabIndex = 0;
            this.btnExibir.Text = "&Exibir";
            this.btnExibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(738, 193);
            this.dataGridView1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // frmPComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 389);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbExibir);
            this.Controls.Add(this.mskdataFinal);
            this.Controls.Add(this.lbldataFinal);
            this.Controls.Add(this.mskdataInicial);
            this.Controls.Add(this.lbldataInicial);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtLancamento);
            this.Controls.Add(this.lblLancamento);
            this.Controls.Add(this.gpbOpcoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPComissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Comissão";
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.gpbExibir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.RadioButton rbLancamento;
        private System.Windows.Forms.Label lblLancamento;
        private System.Windows.Forms.TextBox txtLancamento;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label lbldataInicial;
        private System.Windows.Forms.MaskedTextBox mskdataInicial;
        private System.Windows.Forms.MaskedTextBox mskdataFinal;
        private System.Windows.Forms.Label lbldataFinal;
        private System.Windows.Forms.GroupBox gpbExibir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}