using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //------------------------------------------------------------------------------
            //CALCULADOR DE IMPOSTO

            //Imposto iss = new ISS();
            //Imposto icms = new ICMS();

            //Orcamento orcamento = new Orcamento(500.0);

            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //calculador.RealizaCalculo(orcamento, iss);

            //-----------------DECORATOR-------------------------------------------------------------
            //CALCULADOR DE DESCONTO

            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            //Orcamento orcamento = new Orcamento(500);

            //orcamento.AdicionaItem(new Item("CANETA", 500));
            //orcamento.AdicionaItem(new Item("LAPIS", 500));

            //double desconto = calculador.Calcula(orcamento);
            //Console.WriteLine(desconto);

            //Imposto iss = new ISS(new ICMS());

            //Orcamento orcamento = new Orcamento(500);

            //double valor = iss.Calcula(orcamento);

            //Console.WriteLine(valor);

            //Console.ReadKey();

            //----------------STATES--------------------------------------------------------------

            //Orcamento reforma = new Orcamento(500);

            //Console.WriteLine(reforma.Valor);

            //reforma.AplicaDesscontoExtra();

            //Console.WriteLine(reforma.Valor);

            //reforma.Aprova();

            //reforma.AplicaDesscontoExtra();

            //Console.WriteLine(reforma.Valor);

            //reforma.Finaliza();

            //reforma.AplicaDesscontoExtra();

            //Console.WriteLine(reforma.Valor);
            //Console.ReadKey();

            //-----------BUILDER---------------------------------------------------------------------

            //IList<ItemDaNota> itensDaNota = new List<ItemDaNota>();

            //itensDaNota.Add(new ItemDaNota("Biscoito", 2.50));
            //itensDaNota.Add(new ItemDaNota("Desodorante", 8.00));
            //itensDaNota.Add(new ItemDaNota("Feijão", 10.0));

            //double valorTotal = 0;

            //foreach (var item in itensDaNota)
            //{
            //    valorTotal += item.Valor;
            //}

            //double impostos = valorTotal * 0.05;

            //NotaFiscal nf =
            //    new NotaFiscal
            //    (
            //        "razao",
            //        "cnpj",
            //        DateTime.Now,
            //        valorTotal,
            //        impostos,
            //        itensDaNota,
            //        "obs qualquer"

            //    );

            NotaFiscalBuilder criador = new NotaFiscalBuilder();

            criador.ParaEmpresa("Caelum Ensino e Inovacao")
                .ComCnpj("Caelum Ensino e Inovacao")
                .NaDataAtual()
                .ComObservacoes("Uma obs qualquer")
                .ComItem(new ItemDaNota("Biscoito", 100.0))
                .ComItem(new ItemDaNota("Desodorante", 200.0));

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            criador.Constroi();
            Console.ReadKey();

            //------------------------------------------------------------------------------

        }
    }
}
