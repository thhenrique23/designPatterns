using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            //METODO ANTIGO
            //double desconto = new DescontoPorCincoItens().Desconta(orcamento);
            //if(desconto == 0)
            //{
            //    desconto = new DescontoPorMaisDeQuinhetosReais().Desconta(orcamento);
            //}

            //return desconto;

            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhetosReais();
            IDesconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}
