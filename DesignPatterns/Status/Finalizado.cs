using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos já está finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamentos já está finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos já está finalizado");
        }
    }
}
