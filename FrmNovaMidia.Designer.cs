namespace LocadoraApp2
{
    partial class FrmNovaMidia
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
            txtTitulo = new TextBox();
            label2 = new Label();
            txtAutor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbGenero = new ComboBox();
            label5 = new Label();
            cmbClassificacao = new ComboBox();
            label6 = new Label();
            txtSinopse = new TextBox();
            label1 = new Label();
            numDuracao = new NumericUpDown();
            label7 = new Label();
            numCodigo = new NumericUpDown();
            label8 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            dateAnoLancamento = new DateTimePicker();
            btnEditar = new Button();
            btnApagar = new Button();
            ((System.ComponentModel.ISupportInitialize)numDuracao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCodigo).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(12, 91);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(372, 27);
            txtTitulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 68);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "Autor";
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAutor.Location = new Point(397, 91);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(372, 27);
            txtAutor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 0;
            label3.Text = "Titulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 0;
            label4.Text = "Gênero";
            // 
            // cmbGenero
            // 
            cmbGenero.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Ação", "Terror", "Suspense", "Comédia", "Animação", "Romance", "Anime", "Luta" });
            cmbGenero.Location = new Point(12, 144);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(372, 27);
            cmbGenero.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, 121);
            label5.Name = "label5";
            label5.Size = new Size(162, 20);
            label5.TabIndex = 0;
            label5.Text = "Classificação Indicativa";
            // 
            // cmbClassificacao
            // 
            cmbClassificacao.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbClassificacao.FormattingEnabled = true;
            cmbClassificacao.Items.AddRange(new object[] { "Livre", "+10", "+13", "+16", "+18", "Ninguém" });
            cmbClassificacao.Location = new Point(397, 144);
            cmbClassificacao.Name = "cmbClassificacao";
            cmbClassificacao.Size = new Size(372, 27);
            cmbClassificacao.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 175);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 4;
            label6.Text = "Ano Lançamento";
            // 
            // txtSinopse
            // 
            txtSinopse.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSinopse.Location = new Point(12, 251);
            txtSinopse.Multiline = true;
            txtSinopse.Name = "txtSinopse";
            txtSinopse.Size = new Size(757, 105);
            txtSinopse.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 228);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 5;
            label1.Text = "Sinopse";
            // 
            // numDuracao
            // 
            numDuracao.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numDuracao.Location = new Point(397, 198);
            numDuracao.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numDuracao.Name = "numDuracao";
            numDuracao.Size = new Size(372, 27);
            numDuracao.TabIndex = 6;
            numDuracao.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 175);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 4;
            label7.Text = "Duração (Minutos)";
            // 
            // numCodigo
            // 
            numCodigo.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numCodigo.Location = new Point(12, 38);
            numCodigo.Name = "numCodigo";
            numCodigo.ReadOnly = true;
            numCodigo.Size = new Size(372, 27);
            numCodigo.TabIndex = 0;
            numCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 15);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 0;
            label8.Text = "Código";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(661, 396);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 42);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(547, 396);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(108, 42);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dateAnoLancamento
            // 
            dateAnoLancamento.CustomFormat = "yyyy";
            dateAnoLancamento.Format = DateTimePickerFormat.Custom;
            dateAnoLancamento.Location = new Point(12, 198);
            dateAnoLancamento.Name = "dateAnoLancamento";
            dateAnoLancamento.Size = new Size(372, 27);
            dateAnoLancamento.TabIndex = 5;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(433, 396);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 42);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(319, 396);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(108, 42);
            btnApagar.TabIndex = 8;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Visible = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // FrmNovaMidia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 450);
            Controls.Add(dateAnoLancamento);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(numCodigo);
            Controls.Add(txtSinopse);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(numDuracao);
            Controls.Add(label6);
            Controls.Add(cmbClassificacao);
            Controls.Add(cmbGenero);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Name = "FrmNovaMidia";
            Text = "Nova Midia";
            ((System.ComponentModel.ISupportInitialize)numDuracao).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCodigo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTitulo;
        private Label label2;
        private TextBox txtAutor;
        private Label label3;
        private Label label4;
        private ComboBox cmbGenero;
        private Label label5;
        private ComboBox cmbClassificacao;
        private Label label6;
        private TextBox txtSinopse;
        private Label label1;
        private NumericUpDown numDuracao;
        private Label label7;
        private NumericUpDown numCodigo;
        private Label label8;
        private Button btnCancelar;
        private Button btnSalvar;
        private DateTimePicker dateAnoLancamento;
        private Button btnEditar;
        private Button btnApagar;
    }
}