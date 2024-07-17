using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payers.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees;
        public Company() { }
        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
           if (NumberOfEmployees > 10)
            {
                return Anualincome * 14 / 100;
            }
           else
            {
                return Anualincome * 16 / 100 ;
            }
        }
    }
}
