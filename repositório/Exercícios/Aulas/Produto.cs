using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
    internal class Produto : Fabricante
    {
        public override string Nome {  get; set; }
        public double Price { get; set; }

        public void nome(string nome  )
        {
            if (nome == null)
            {
               Nome = nome;
            }


        }
    }
}
