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
            ((System.ComponentModel.ISupportInitialize)dgvListaLocacoes).BeginInit();
            SuspendLayout();
            // 
            // dgvListaLocacoes
            // 
            dgvListaLocacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaLocacoes.Dock = DockStyle.Fill;
            dgvListaLocacoes.Location = new Point(0, 0);
            dgvListaLocacoes.Name = "dgvListaLocacoes";
            dgvListaLocacoes.ReadOnly = true;
            dgvListaLocacoes.RowHeadersWidth = 51;
            dgvListaLocacoes.RowTemplate.Height = 29;
            dgvListaLocacoes.Size = new Size(800, 450);
            dgvListaLocacoes.TabIndex = 1;
            dgvListaLocacoes.CellContentDoubleClick += dgvListaLocacoes_CellContentDoubleClick;
            // 
            // FrmListaLocacoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListaLocacoes);
            Name = "FrmListaLocacoes";
            Text = "FrmListaLocacoes";
            Load += FrmListaLocacoes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaLocacoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaLocacoes;
    }
}