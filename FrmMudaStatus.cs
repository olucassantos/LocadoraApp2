using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraApp2.Classes;
using LocadoraApp2.Contexto;
using Microsoft.EntityFrameworkCore;

namespace LocadoraApp2
{
    public partial class FrmMudaStatus : Form
    {
        Item ItemAtual;
        public FrmMudaStatus(Item item)
        {
            InitializeComponent();
            ItemAtual = item;
            CarregaDadosCampos();
        }

        private void CarregaDadosCampos()
        {
            txtMidia.Text = ItemAtual.Midia.Titulo;
            txtStatusAtual.Text = ItemAtual.Status;
            datePrazoDevolucao.Value = ItemAtual.DataDevolucao;

            // Muda o panel de acordo com o prazo de devoluçaõ
            if (ItemAtual.DataDevolucao < DateTime.Now)
            {
                pnlPrazoDevolucao.BackColor = Color.Red;
            }
            else
            {
                pnlPrazoDevolucao.BackColor = Color.Green;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Valida se selecionou um campo no combo box
            if (cmbNovoStatus.SelectedIndex < 0) {
                MessageBox.Show("Selecione um novo status!");
                return;
            }

            using (var contexto = new LocadoraAppDbContext())
            {
                var ItemAlteracao = contexto.Itens.Find(ItemAtual.ItemId);

                ItemAlteracao.Status = cmbNovoStatus.SelectedItem.ToString();

                int res = contexto.SaveChanges();

                // Verifica se existe algum item que ainda não foi devolvido
                // Caso não tenha, marca a locação como concluida

                var LocacaoItem = contexto.Locacoes
                        .Include(l => l.Itens)
                        .FirstOrDefault(l => l.LocacaoId == ItemAlteracao.LocacaoId);

                if (LocacaoItem.Itens.All(i => i.Status == "Devolvido"))
                {
                    LocacaoItem.Status = "Concluido";
                    contexto.SaveChanges();
                }

                if (res > 0)
                {
                    MessageBox.Show("Status alterado com sucesso!");
                    this.Close();
                }
            }
        }
    }
}
