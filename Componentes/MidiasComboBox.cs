using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraApp2.Classes;
using LocadoraApp2.Contexto;

namespace LocadoraApp2.Componentes
{
    public partial class MidiasComboBox : ComboBox
    {
        public MidiasComboBox()
        {
            // Define o estilo do combo box
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.BackColor = Color.RebeccaPurple;
            this.ForeColor = Color.White;
        }

        public void CarregarMidias()
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                // Define os dados que o combo box irá utilizar
                this.DataSource = contexto.
                    Midias
                    .OrderBy(m => m.Titulo)
                    .ToList();

                // Definir qual o campo será usado como texto
                this.DisplayMember = "Titulo";

                // Definir qual o campo será o valor real
                this.ValueMember = "MidiaId";
            }
        }

        public Midia MidiaSelecionada
        {
            get
            {
                return this.SelectedItem as Midia;
            }
        }

        public int? MidiaIdSelecionada
        {
            get
            {
                return this.SelectedItem as int?;
            }
        }
    }
}
