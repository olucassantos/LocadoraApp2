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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LocadoraApp2
{
    public partial class FrmNovaMidia : Form
    {
        private Midia MidiaAtual;

        public FrmNovaMidia()
        {
            InitializeComponent();
        }

        public FrmNovaMidia(int idMidia)
        {
            InitializeComponent();

            // Desabilita os campos
            CamposApenasLeitura(true);

            // Busca uma Midia no Banco de Dados
            MidiaAtual = GetMidiaById(idMidia);

            // Carrega os dados para os campos
            CarregaDadosFormulario();
        }

        private void CarregaDadosFormulario()
        {
            numCodigo.Value = MidiaAtual.MidiaId;
            txtTitulo.Text = MidiaAtual.Titulo;
            txtSinopse.Text = MidiaAtual.Sinopse;
            txtAutor.Text = MidiaAtual.Autor;
            cmbGenero.Text = MidiaAtual.Genero;
            cmbClassificacao.Text = MidiaAtual.ClassificacaoIndicativa;
        }

        // Retorna uma Midia do Banco de Dados
        private Midia GetMidiaById(int Id)
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                return contexto.Midias.Find(Id);
            }
        }

        private void CamposApenasLeitura(bool status)
        {
            txtTitulo.ReadOnly = status;
            txtAutor.ReadOnly = status;
            txtSinopse.ReadOnly = status;
            numDuracao.ReadOnly = status;

            cmbGenero.Enabled = !status;
            cmbClassificacao.Enabled = !status;
            btnSalvar.Enabled = !status;

            btnEditar.Visible = status;
            btnApagar.Visible = status;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MidiaAtual != null)
            {
                // Atualiza a Nova Midia
                using (var contexto = new LocadoraAppDbContext())
                {
                    MidiaAtual = contexto.Midias.Find(MidiaAtual.MidiaId);

                    // Atribui os campos corretos a edição
                    MidiaAtual.Titulo = txtTitulo.Text;
                    MidiaAtual.Sinopse = txtSinopse.Text;
                    MidiaAtual.Autor = txtAutor.Text;
                    MidiaAtual.Duracao = (int)numDuracao.Value;
                    MidiaAtual.ClassificacaoIndicativa = cmbClassificacao.SelectedItem.ToString();
                    MidiaAtual.Genero = cmbGenero.SelectedItem.ToString();
                    MidiaAtual.Ano = 2024;

                    // Salva as alterações no Bando de Dados
                    int resultado = contexto.SaveChanges();

                    if (resultado > 0)
                        MessageBox.Show("Midia editada com sucesso!");
                    else
                        MessageBox.Show("Erro ao salvar Midia!");
                }

                // Bloqueia a edição dos campos
                CamposApenasLeitura(true);
            }
            else
            {
                // Salva a Nova Midia
                NovaMidia(
                    txtTitulo.Text,
                    txtAutor.Text,
                    txtSinopse.Text,
                    cmbGenero.SelectedItem.ToString(),
                    cmbClassificacao.SelectedItem.ToString(),
                    (int)numDuracao.Value,
                    2024
                );
            }
        }

        /*
            Salvar uma nova midia no banco de dados 
        */
        private void NovaMidia(
            string titulo,
            string autor,
            string sinopse,
            string genero,
            string classificacaoIndicativa,
            int duracao,
            int ano
        )
        {
            // Iniciamos a conexão com o banco
            using (var contexto = new LocadoraAppDbContext())
            {
                // Cria uma nova instancia de Midia, com os dados da função
                Midia novaMidia = new Midia
                {
                    Titulo = titulo,
                    Autor = autor,
                    Sinopse = sinopse,
                    Genero = genero,
                    ClassificacaoIndicativa = classificacaoIndicativa,
                    Duracao = duracao,
                    Ano = ano
                };

                // Adiciona uma nova midia ao contexto
                contexto.Midias.Add(novaMidia);

                // Salvando as alterações do contexto
                int res = contexto.SaveChanges();

                // Verificar se salvou a Midia
                if (res == 0)
                {
                    MessageBox.Show("Erro ao salvar a midia!");
                }
                else
                {
                    MessageBox.Show("Midia criada com sucesso!");
                    txtTitulo.Clear();
                    txtAutor.Clear();
                    txtSinopse.Clear();
                    cmbGenero.SelectedItem = null;
                    cmbClassificacao.SelectedItem = null;
                    numDuracao.Value = 0;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CamposApenasLeitura(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(
                "Deseja realmente cancelar?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (res == DialogResult.Yes)
                this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(
                $"Deseja realmente apagar a midia {MidiaAtual.Titulo}?",
                "Confirmação de deleção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (res == DialogResult.Yes)
            {
                // Apaga a Midia do banco de dadoss

                using (var contexto = new LocadoraAppDbContext())
                {
                    MidiaAtual = contexto.Midias.Find(MidiaAtual.MidiaId);

                    if (MidiaAtual != null)
                    {
                        contexto.Midias.Remove(MidiaAtual);
                        int resultado = contexto.SaveChanges();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Midia removida com sucesso!");
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
