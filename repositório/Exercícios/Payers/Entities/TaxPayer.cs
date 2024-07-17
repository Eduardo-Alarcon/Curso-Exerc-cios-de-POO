using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payers.Entities
{
    internal abstract class TaxPayer
    {
        public string Nome {  get; set; }
        public double Anualincome { get; set; }

        public TaxPayer() { }
        public TaxPayer(string nome, double anualincome)
        {
            Nome = nome;
            Anualincome = anualincome;
        }

        public abstract double Tax();
    }
}
