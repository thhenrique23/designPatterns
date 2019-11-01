using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Orcamento
    {
        public IEstadoDeUmOracamento EstadoAtual { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AplicaDesscontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
