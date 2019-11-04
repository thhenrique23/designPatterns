using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto /*string tipo*/)
        {

            //MODO ANTIGO
            //if ("ICMS".Equals(tipo))
            //{
            //    Console.WriteLine(orcamento.Valor * 0.01);
            //}else if ("ISS".Equals(tipo))
            //{
            //    Console.WriteLine(orcamento.Valor * 0.06);
            //}

            //NOVO MODO
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
