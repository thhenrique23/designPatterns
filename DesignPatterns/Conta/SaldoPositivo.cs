using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Conta
{
    public class SaldoPositivo : IEstadoDeUmaConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Saca(Conta conta, double valor)
        {
            conta.Saldo -= valor;

            if (conta.Saldo < 0) conta.Estado = new SaldoNegativo();
        }
    }
}
