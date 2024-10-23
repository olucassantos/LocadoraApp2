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
    public partial class FrmNovaLocacao : Form
    {
        public FrmNovaLocacao()
        {
            InitializeComponent();
        }

        private void FrmNovaLocacao_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (! ValidaDadosItem())
            {
                return;
            }

            MessageBox.Show("Item adicionado com sucesso!");
        }

        private bool ValidaDadosItem()
        {
            // Deve ser selecionada uma midia
            if (cmbMidias.MidiaIdSelecionada == null)
            {
                MessageBox.Show("Selecione uma midia!");
                cmbMidias.Focus();
                return false;
            }

            // Deve ser adicionado pelo menos um item
            if (numQuantidade.Value < 1)
            {
                MessageBox.Show("A quandidade não pode ser menor que um!");
                numQuantidade.Focus();
                return false;
            }

            // O prazo de devolução não deve ser inferior a 1 dia!
            if (numPrazo.Value < 1)
            {
                MessageBox.Show("O prazo não pode ser menor que um dia!");
                numPrazo.Focus();
                return false;
            }

            // O campo de valor não deve ser zero!
            if (numValorItem.Value <= 0)
            {
                MessageBox.Show("O valor do item não pode ser zero!");
                numValorItem.Focus();
                return false;
            }

            return true;
        }

        private void FrmNovaLocacao_Load_1(object sender, EventArgs e)
        {
            // Carrega as midias no ComboBox Personalizado
            cmbMidias.CarregarMidias();
        }
    }
}
