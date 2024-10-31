namespace LocadoraApp2
{
    partial class FrmMudaStatus
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
            label1 = new Label();
            txtMidia = new TextBox();
            label2 = new Label();
            txtStatusAtual = new TextBox();
            label3 = new Label();
            datePrazoDevolucao = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            cmbNovoStatus = new ComboBox();
            label4 = new Label();
            pnlPrazoDevolucao = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Midia Alocada";
            // 
            // txtMidia
            // 
            txtMidia.Location = new Point(12, 32);
            txtMidia.Name = "txtMidia";
            txtMidia.ReadOnly = true;
            txtMidia.Size = new Size(537, 27);
            txtMidia.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Status Atual";
            // 
            // txtStatusAtual
            // 
            txtStatusAtual.Location = new Point(12, 102);
            txtStatusAtual.Name = "txtStatusAtual";
            txtStatusAtual.ReadOnly = true;
            txtStatusAtual.Size = new Size(269, 27);
            txtStatusAtual.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 79);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 2;
            label3.Text = "Prazo de Devolução";
            // 
            // datePrazoDevolucao
            // 
            datePrazoDevolucao.Enabled = false;
            datePrazoDevolucao.Format = DateTimePickerFormat.Short;
            datePrazoDevolucao.Location = new Point(287, 102);
            datePrazoDevolucao.Name = "datePrazoDevolucao";
            datePrazoDevolucao.Size = new Size(262, 27);
            datePrazoDevolucao.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateBlue;
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(cmbNovoStatus);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 230);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alteração de status";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Crimson;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(6, 179);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 45);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SeaGreen;
            btnSalvar.Location = new Point(397, 179);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(134, 45);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cmbNovoStatus
            // 
            cmbNovoStatus.FormattingEnabled = true;
            cmbNovoStatus.Items.AddRange(new object[] { "Atrasado", "Danificado", "Devolvido", "Pendente" });
            cmbNovoStatus.Location = new Point(6, 58);
            cmbNovoStatus.Name = "cmbNovoStatus";
            cmbNovoStatus.Size = new Size(525, 31);
            cmbNovoStatus.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(429, 23);
            label4.TabIndex = 0;
            label4.Text = "Selecione abaixo o novo status para o item da locação.";
            // 
            // pnlPrazoDevolucao
            // 
            pnlPrazoDevolucao.Location = new Point(285, 100);
            pnlPrazoDevolucao.Name = "pnlPrazoDevolucao";
            pnlPrazoDevolucao.Size = new Size(266, 31);
            pnlPrazoDevolucao.TabIndex = 6;
            // 
            // FrmMudaStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 377);
            Controls.Add(groupBox1);
            Controls.Add(datePrazoDevolucao);
            Controls.Add(txtStatusAtual);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMidia);
            Controls.Add(label1);
            Controls.Add(pnlPrazoDevolucao);
            Name = "FrmMudaStatus";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mudar o status do item";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMidia;
        private Label label2;
        private TextBox txtStatusAtual;
        private Label label3;
        private DateTimePicker datePrazoDevolucao;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox cmbNovoStatus;
        private Button btnCancelar;
        private Button btnSalvar;
        private Panel pnlPrazoDevolucao;
    }
}