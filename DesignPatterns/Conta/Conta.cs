using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Conta
{
    public class Conta
    {
        public double Saldo { get; set; }

        public IEstadoDeUmaConta Estado { get; set; }

        public Conta(double saldo)
        {
            this.Saldo = saldo;

            if(Saldo < 0)
                this.Estado = new SaldoNegativo();
            else
                this.Estado = new SaldoPositivo();
        }

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }
    }
}
