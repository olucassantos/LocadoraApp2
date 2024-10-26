namespace LocadoraApp2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovaMidia frmNovaMidia = new FrmNovaMidia();
            frmNovaMidia.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaMidias frmListaMidias = new FrmListaMidias();
            frmListaMidias.Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNovaLocacao frmNovaLocacao = new FrmNovaLocacao();
            frmNovaLocacao.Show();
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListaLocacoes frmListaLocacoes = new FrmListaLocacoes();
            frmListaLocacoes.Show();
        }
    }
}
