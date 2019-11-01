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
    }
}
