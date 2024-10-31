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

        public FrmNovaLocacao(int LocacaoId)
        {
            InitializeComponent();

            // Coloca os campos em apenas leitura
            CamposApenasLeitura(true);

            // Busca a Locação no banco de dados
            LocacaoAtual = GetLocacaoById(LocacaoId);

            // Carrega os dados para os campos
            CarregaDadosLocacaoCampos();
        }

        private void CarregaDadosLocacaoCampos()
        {
            txtNomeCliente.Text = LocacaoAtual.Nome;
            mtxtCpf.Text = LocacaoAtual.Cpf;
            mtxtTelefone.Text = LocacaoAtual.Telefone;

            dateDataLocacao.Value = LocacaoAtual.Data;
            numValorTotal.Value = LocacaoAtual.ValorTotal;
            txtStatus.Text = LocacaoAtual.Status;

            CarregaDadosItensLocacao();
        }

        private Locacao? GetLocacaoById(int id)
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                return contexto
                        .Locacoes
                        .Include(l => l.Itens)
                            .ThenInclude(i => i.Midia)
                        .FirstOrDefault(l => l.LocacaoId == id);
            }
        }

        private void CamposApenasLeitura(bool status)
        {
            // Marca a propriedade ReadOnly como true nos campos de texto
            txtNomeCliente.ReadOnly = status;
            mtxtCpf.ReadOnly = status;
            mtxtTelefone.ReadOnly = status;

            // Oculta o formulário de novos itens
            grbNovoItem.Visible = !status;

            // Oculta o botão de cancelar
            btnCancelar.Visible = !status;
            // Oculta o botão de fechar locação
            btnFechar.Visible = !status;

            // Mostra o groupBox de dados
            grbDadosLocacao.Visible = status;

            // Desabilita o DataGridView dos itens
            dgvItensLocacao.ReadOnly = status;
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
                Midia = cmbMidias.MidiaSelecionada
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
            if (LocacaoAtual == null)
            {
                // Carrega as midias no ComboBox Personalizado
                cmbMidias.CarregarMidias();

                // Instancia uma nova locação
                LocacaoAtual = new Locacao();

                CarregaDadosItensLocacao();
            }
        }

        private void CarregaDadosItensLocacao()
        {
            // Adiciona os itens da Locação no Data Grid View
            dgvItensLocacao.DataSource = LocacaoAtual.Itens;

            // Define os titulos das colunas
            dgvItensLocacao.Columns["ItemId"].HeaderText = "Código";
            dgvItensLocacao.Columns["MidiaTitulo"].HeaderText = "Título";

            dgvItensLocacao.Columns["PrazoDevolucao"].HeaderText = "Prazo";
            dgvItensLocacao.Columns["DataDevolucao"].HeaderText = "Data Devolução";

            dgvItensLocacao.Columns["Valor"].HeaderText = "Valor";
            dgvItensLocacao.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvItensLocacao.Columns["ValorTotal"].HeaderText = "Total";

            // Formata os campos de valor para Moeda
            dgvItensLocacao.Columns["Valor"].DefaultCellStyle.Format = "C";
            dgvItensLocacao.Columns["ValorTotal"].DefaultCellStyle.Format = "C";

            // Ordena os campos
            dgvItensLocacao.Columns["ItemId"].DisplayIndex = 0;
            dgvItensLocacao.Columns["MidiaTitulo"].DisplayIndex = 1;
            dgvItensLocacao.Columns["PrazoDevolucao"].DisplayIndex = 2;
            dgvItensLocacao.Columns["DataDevolucao"].DisplayIndex = 3;
            dgvItensLocacao.Columns["Valor"].DisplayIndex = 4;
            dgvItensLocacao.Columns["Quantidade"].DisplayIndex = 5;
            dgvItensLocacao.Columns["ValorTotal"].DisplayIndex = 6;
            dgvItensLocacao.Columns["Status"].DisplayIndex = 7;

            // Oculta os campos desnecessários
            dgvItensLocacao.Columns["MidiaId"].Visible = false;
            dgvItensLocacao.Columns["Midia"].Visible = false;
            dgvItensLocacao.Columns["Locacao"].Visible = false;
            dgvItensLocacao.Columns["LocacaoId"].Visible = false;

            // Redimensiona as colunas
            dgvItensLocacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (!ValidaDadosLocacao())
            {
                return;
            }

            // Adiciona os dados da locação
            LocacaoAtual.Cpf = mtxtCpf.Text;
            LocacaoAtual.Nome = txtNomeCliente.Text;
            LocacaoAtual.Telefone = mtxtTelefone.Text;
            LocacaoAtual.Status = "Fechado";
            LocacaoAtual.Data = DateTime.Now;

            // Abre o contexto para salvar a locação
            using (var contexto = new LocadoraAppDbContext())
            {
                // Adiciona todas as midias ao contexto para não serem inseridas novamente
                foreach (var item in LocacaoAtual.Itens)
                {
                    contexto.Midias.Attach(item.Midia);
                    LocacaoAtual.ValorTotal += item.ValorTotal; // Soma o valor total do item na locação
                }

                contexto.Locacoes.Add(LocacaoAtual);
                int resultado = contexto.SaveChanges();

                if (resultado > 0)
                {
                    var opcao = MessageBox.Show(
                        "Locação criada com sucesso! Deseja criar outra?",
                        "Locação criada",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                    );

                    if (opcao == DialogResult.Yes)
                    {
                        // Limpa o formulário
                        LimparFormularioLocacao();
                    }
                    else
                    {
                        // Fecha o formulário
                        this.Close();
                    }
                }
            }
        }

        private void LimparFormularioLocacao()
        {
            txtNomeCliente.Clear();
            mtxtCpf.Clear();
            mtxtTelefone.Clear();
            LocacaoAtual = new Locacao();

            CarregaDadosItensLocacao();
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

        private void dgvItensLocacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se existe uma celula selecionada
            if (e.RowIndex >= 0)
            {
                // Pega qual linha foi clicada
                DataGridViewRow linha = dgvItensLocacao.Rows[e.RowIndex];

                // Pega o código da linha selecionada
                int ItemId = (int) linha.Cells["ItemId"].Value;

                using (var contexto = new LocadoraAppDbContext())
                {
                    // Busca o item no banco de dados
                    var Item = contexto
                                .Itens
                                .Include(i => i.Midia)
                                .Include(i => i.Locacao)
                                .FirstOrDefault(i => i.ItemId == ItemId);

                    if (Item != null)
                    {
                        // Chama o formulário de mudar status passando o item buscado
                        FrmMudaStatus frmMudaStatus = new FrmMudaStatus(Item);
                        frmMudaStatus.ShowDialog();
                    }
                }
            }
        }
    }
}
