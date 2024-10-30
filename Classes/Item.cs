using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraApp2.Classes
{
    public class Item
    {
        public int ItemId { get; set; }
        public int PrazoDevolucao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public string Status { get; set; }

        // Dados para relação com a locação
        public int LocacaoId { get; set; }
        public Locacao Locacao { get; set; }

        // Dados para relação com a Midia
        public int MidiaId { get; set; }
        public Midia Midia { get; set; }

        // Campo para Valor Total
        public decimal ValorTotal
        {
            get
            {
                return Quantidade * Valor * PrazoDevolucao;
            }
        }

        // Campo para o titulo da Midia
        public string MidiaTitulo
        {
            get
            {
                return Midia.Titulo;
            }
        }

        public DateTime DataDevolucao
        {
            get {
                if (Locacao != null) {
                    return Locacao.Data.AddDays(PrazoDevolucao);
                } 
                else
                {
                    return DateTime.Now.AddDays(PrazoDevolucao);
                }
            }
        }

        public Item() 
        {
            Midia = new Midia();   
        }
    }
}
