﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payers.Entities
{
    class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (Anualincome < 20000.0)
            {
                return Anualincome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return Anualincome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}