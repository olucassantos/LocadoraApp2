using LocadoraApp2.Classes;
using LocadoraApp2.Contexto;
using Microsoft.EntityFrameworkCore;
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
        private Locacao LocacaoAtual;

        public FrmNovaLocacao()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidaDadosItem())
            {
                return;
            }

            // Cria o novo item para adicionar na Locação
            Item NovoItem = new Item()
            {
                PrazoDevolucao = (int)numPrazo.Value,
                Valor = numValorItem.Value,
                Quantidade = (int)numQuantidade.Value,
                Status = "Pendente",
                MidiaId = cmbMidias.MidiaSelecionada.MidiaId,
            };

            // Adiciona o novo item dentro da locação
            LocacaoAtual.Itens.Add(NovoItem);

            // Limpa os campos do item
            LimpaCamposItens();

            MessageBox.Show("Item adicionado com sucesso!");
        }

        private void LimpaCamposItens()
        {
            // Limpa campo de valor
            numValorItem.Value = 0;
            // Limpa campo de Midia
            cmbMidias.SelectedIndex = 0;
            // Limpa campo de Prazo
            numPrazo.Value = 1;
            // Limpa campo de quantidade
            numQuantidade.Value = 1;
        }

        private bool ValidaDadosItem()
        {
            // Deve ser selecionada uma midia
            if (cmbMidias.MidiaSelecionada == null)
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

            // Instancia uma nova locação
            LocacaoAtual = new Locacao();

            CarregaDadosItensLocacao();
        }

        private void CarregaDadosItensLocacao()
        {
            // Adiciona os itens da Locação no Data Grid View
            dgvItensLocacao.DataSource = LocacaoAtual.Itens;

            // Define os titulos das colunas
            dgvItensLocacao.Columns["ItemId"].HeaderText = "Código";
            dgvItensLocacao.Columns["MidiaTitulo"].HeaderText = "Título";
            dgvItensLocacao.Columns["PrazoDevolucao"].HeaderText = "Devolução";
            dgvItensLocacao.Columns["Valor"].HeaderText = "Valor";
            dgvItensLocacao.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvItensLocacao.Columns["ValorTotal"].HeaderText = "Total";

            // Ordena os campos
            dgvItensLocacao.Columns["ItemId"].DisplayIndex = 0;
            dgvItensLocacao.Columns["MidiaTitulo"].DisplayIndex = 1;
            dgvItensLocacao.Columns["PrazoDevolucao"].DisplayIndex = 2;
            dgvItensLocacao.Columns["Valor"].DisplayIndex = 3;
            dgvItensLocacao.Columns["Quantidade"].DisplayIndex = 4;
            dgvItensLocacao.Columns["ValorTotal"].DisplayIndex = 5;

            // Oculta os campos desnecessários
            dgvItensLocacao.Columns["MidiaId"].Visible = false;
            dgvItensLocacao.Columns["Midia"].Visible = false;
            dgvItensLocacao.Columns["Locacao"].Visible = false;
            dgvItensLocacao.Columns["LocacaoId"].Visible = false;
            dgvItensLocacao.Columns["Status"].Visible = false;

            // Redimensiona as colunas
            dgvItensLocacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (!ValidaDadosLocacao())
            {
                return;
            }

            LocacaoAtual.Cpf = mtxtCpf.Text;
            LocacaoAtual.Nome = txtNomeCliente.Text;
            LocacaoAtual.Telefone = mtxtTelefone.Text;
            LocacaoAtual.Status = "Fechado";

            using (var contexto = new LocadoraAppDbContext())
            {
                contexto.Locacoes.Add(LocacaoAtual);
                contexto.SaveChanges();
            }
        }

        private bool ValidaDadosLocacao()
        {
            // Verifica se tem nome
            if (txtNomeCliente.Text.Length < 3)
            {
                MessageBox.Show("O nome do cliente é inválido!");
                txtNomeCliente.Focus();
                return false;
            }

            // Verifica se tem CPF valido
            if (mtxtCpf.Text.Length != 11)
            {
                MessageBox.Show("O CPF do cliente é inválido!");
                mtxtCpf.Focus();
                return false;
            }

            // Verifica se tem telefone valido
            if (mtxtTelefone.Text.Length < 11)
            {
                MessageBox.Show("O telefone do cliente é inválido!");
                mtxtTelefone.Focus();
                return false;
            }

            return true;
        }
    }
}
