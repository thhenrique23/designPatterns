using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Conta
{
    public class SaldoNegativo : IEstadoDeUmaConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.Estado = new SaldoPositivo();
        }

        public void Saca(Conta conta, double valor)
        {
            throw new Exception("A conta está com saldo negativo");
        }
    }
}
