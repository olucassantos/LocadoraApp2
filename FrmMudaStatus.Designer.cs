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
            label4 = new Label();
            cmbNovoStatus = new ComboBox();
            button1 = new Button();
            button2 = new Button();
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
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(429, 23);
            label4.TabIndex = 0;
            label4.Text = "Selecione abaixo o novo status para o item da locação.";
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
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Location = new Point(397, 179);
            button1.Name = "button1";
            button1.Size = new Size(134, 45);
            button1.TabIndex = 2;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(6, 179);
            button2.Name = "button2";
            button2.Size = new Size(134, 45);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
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
        private Button button2;
        private Button button1;
    }
}