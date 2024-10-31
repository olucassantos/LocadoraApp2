namespace LocadoraApp2
{
    partial class FrmListaLocacoes
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
            dgvListaLocacoes = new DataGridView();
            label1 = new Label();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListaLocacoes).BeginInit();
            SuspendLayout();
            // 
            // dgvListaLocacoes
            // 
            dgvListaLocacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaLocacoes.BackgroundColor = Color.SlateBlue;
            dgvListaLocacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaLocacoes.GridColor = Color.Gray;
            dgvListaLocacoes.Location = new Point(12, 66);
            dgvListaLocacoes.Name = "dgvListaLocacoes";
            dgvListaLocacoes.ReadOnly = true;
            dgvListaLocacoes.RowHeadersWidth = 51;
            dgvListaLocacoes.RowTemplate.Height = 29;
            dgvListaLocacoes.Size = new Size(776, 372);
            dgvListaLocacoes.TabIndex = 1;
            dgvListaLocacoes.CellContentDoubleClick += dgvListaLocacoes_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Fechado", "Concluido" });
            cmbStatus.Location = new Point(12, 32);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(376, 28);
            cmbStatus.TabIndex = 3;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // FrmListaLocacoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbStatus);
            Controls.Add(label1);
            Controls.Add(dgvListaLocacoes);
            Name = "FrmListaLocacoes";
            Text = "Lista de Locações";
            Load += FrmListaLocacoes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaLocacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListaLocacoes;
        private Label label1;
        private ComboBox cmbStatus;
    }
}