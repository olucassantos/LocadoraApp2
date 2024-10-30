namespace LocadoraApp2
{
    partial class FrmNovaLocacao
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
            groupBox1 = new GroupBox();
            mtxtTelefone = new MaskedTextBox();
            label2 = new Label();
            mtxtCpf = new MaskedTextBox();
            label1 = new Label();
            txtNomeCliente = new TextBox();
            label3 = new Label();
            grbNovoItem = new GroupBox();
            btnAdicionar = new Button();
            numPrazo = new NumericUpDown();
            numQuantidade = new NumericUpDown();
            label7 = new Label();
            numValorItem = new NumericUpDown();
            label5 = new Label();
            cmbMidias = new Componentes.MidiasComboBox();
            label4 = new Label();
            dgvItensLocacao = new DataGridView();
            btnFechar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            grbNovoItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrazo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValorItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensLocacao).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Lavender;
            groupBox1.Controls.Add(mtxtTelefone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mtxtCpf);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNomeCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 141);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtxtTelefone.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtTelefone.Location = new Point(474, 100);
            mtxtTelefone.Mask = "(99) 0 0000-0000";
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Size = new Size(466, 27);
            mtxtTelefone.TabIndex = 3;
            mtxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 77);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Telefone";
            // 
            // mtxtCpf
            // 
            mtxtCpf.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtCpf.Location = new Point(6, 100);
            mtxtCpf.Mask = "000.000.000-00";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(462, 27);
            mtxtCpf.TabIndex = 2;
            mtxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 77);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeCliente.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCliente.Location = new Point(6, 47);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(934, 27);
            txtNomeCliente.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // grbNovoItem
            // 
            grbNovoItem.BackColor = Color.MediumSlateBlue;
            grbNovoItem.Controls.Add(btnAdicionar);
            grbNovoItem.Controls.Add(numPrazo);
            grbNovoItem.Controls.Add(numQuantidade);
            grbNovoItem.Controls.Add(label7);
            grbNovoItem.Controls.Add(numValorItem);
            grbNovoItem.Controls.Add(label5);
            grbNovoItem.Controls.Add(cmbMidias);
            grbNovoItem.Controls.Add(label4);
            grbNovoItem.ForeColor = Color.White;
            grbNovoItem.Location = new Point(12, 159);
            grbNovoItem.Name = "grbNovoItem";
            grbNovoItem.Size = new Size(946, 192);
            grbNovoItem.TabIndex = 1;
            grbNovoItem.TabStop = false;
            grbNovoItem.Text = "Itens da Locação";
            // 
            // btnAdicionar
            // 
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(824, 146);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(116, 40);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // numPrazo
            // 
            numPrazo.Location = new Point(656, 90);
            numPrazo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPrazo.Name = "numPrazo";
            numPrazo.Size = new Size(284, 27);
            numPrazo.TabIndex = 1;
            numPrazo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(331, 90);
            numQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(284, 27);
            numQuantidade.TabIndex = 1;
            numQuantidade.TextAlign = HorizontalAlignment.Center;
            numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(656, 67);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 2;
            label7.Text = "Prazo Devolução (Dias)";
            // 
            // numValorItem
            // 
            numValorItem.DecimalPlaces = 2;
            numValorItem.Location = new Point(6, 90);
            numValorItem.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numValorItem.Name = "numValorItem";
            numValorItem.Size = new Size(284, 27);
            numValorItem.TabIndex = 1;
            numValorItem.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 67);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 2;
            label5.Text = "Quantidade";
            // 
            // cmbMidias
            // 
            cmbMidias.BackColor = Color.RebeccaPurple;
            cmbMidias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMidias.ForeColor = Color.White;
            cmbMidias.FormattingEnabled = true;
            cmbMidias.Location = new Point(6, 26);
            cmbMidias.Name = "cmbMidias";
            cmbMidias.Size = new Size(934, 28);
            cmbMidias.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 67);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 2;
            label4.Text = "Valor";
            // 
            // dgvItensLocacao
            // 
            dgvItensLocacao.BackgroundColor = Color.DarkSlateBlue;
            dgvItensLocacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensLocacao.Location = new Point(12, 357);
            dgvItensLocacao.Name = "dgvItensLocacao";
            dgvItensLocacao.ReadOnly = true;
            dgvItensLocacao.RowHeadersWidth = 51;
            dgvItensLocacao.RowTemplate.Height = 29;
            dgvItensLocacao.ShowEditingIcon = false;
            dgvItensLocacao.Size = new Size(946, 203);
            dgvItensLocacao.TabIndex = 2;
            // 
            // btnFechar
            // 
            btnFechar.ForeColor = Color.Black;
            btnFechar.Location = new Point(797, 566);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(161, 40);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar Locação";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(630, 566);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(161, 40);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnAdicionar_Click;
            // 
            // FrmNovaLocacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 613);
            Controls.Add(btnCancelar);
            Controls.Add(btnFechar);
            Controls.Add(dgvItensLocacao);
            Controls.Add(grbNovoItem);
            Controls.Add(groupBox1);
            Name = "FrmNovaLocacao";
            Text = "Nova Locação";
            Load += FrmNovaLocacao_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbNovoItem.ResumeLayout(false);
            grbNovoItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrazo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValorItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensLocacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox mtxtCpf;
        private Label label1;
        private TextBox txtNomeCliente;
        private Label label3;
        private MaskedTextBox mtxtTelefone;
        private Label label2;
        private GroupBox grbNovoItem;
        private Componentes.MidiasComboBox cmbMidias;
        private NumericUpDown numValorItem;
        private Label label5;
        private Label label4;
        private Button btnAdicionar;
        private NumericUpDown numPrazo;
        private NumericUpDown numQuantidade;
        private Label label7;
        private DataGridView dgvItensLocacao;
        private Button btnFechar;
        private Button btnCancelar;
    }
}