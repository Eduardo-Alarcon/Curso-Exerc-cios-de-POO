using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixação
{
    internal class Class1
    {
        public string titular {  get ; set; }
        public int senha { get; private set; }
        private double deposito { get; set; }

        

        public Class1(string titular, int senha, double deposito)
        {
            this.titular = titular;
            this.senha = senha;
            this.deposito = deposito;
        }
        public Class1(string titular, int senha)
        {
            this.titular = titular;
            this.senha = senha;
        }

       

        public void Depositar(double deposito)
        {
            this.deposito += deposito;
        }
        public void Saque(double deposito)
        {
            this.deposito -= deposito + 5;
        }

        public override string ToString()
        {
            return "Conta" + senha + ", " + titular + ", Saldo: $ " + deposito.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
