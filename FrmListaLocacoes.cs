using LocadoraApp2.Classes;
using LocadoraApp2.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraApp2
{
    public partial class FrmListaLocacoes : Form
    {
        public FrmListaLocacoes()
        {
            InitializeComponent();
        }

        private void FrmListaLocacoes_Load(object sender, EventArgs e)
        {
            CarregaDadosDGV();
        }

        private List<Locacao> GetLocacoes()
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                return contexto.Locacoes.ToList();
            }
        }

        private void CarregaDadosDGV()
        {
            // Carregando os dados para o DGV
            dgvListaLocacoes.DataSource = GetLocacoes();

            // Renomear o cabeçalho
            dgvListaLocacoes.Columns["LocacaoId"].HeaderText = "Código";
            dgvListaLocacoes.Columns["Nome"].HeaderText = "Cliente";
            dgvListaLocacoes.Columns["Data"].HeaderText = "Data Locação";
            dgvListaLocacoes.Columns["ValorTotal"].HeaderText = "Valor Total";

            // Muda os dados de ValorTotal
            dgvListaLocacoes.Columns["ValorTotal"].DefaultCellStyle.Format = "C";

            // Ocultar os campos desnecessários
            dgvListaLocacoes.Columns["Telefone"].Visible = false;
            dgvListaLocacoes.Columns["Cpf"].Visible = false;

            // Muda o redimensionamento do DGV
            dgvListaLocacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
