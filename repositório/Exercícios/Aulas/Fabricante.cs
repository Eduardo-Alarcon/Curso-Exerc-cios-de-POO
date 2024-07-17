using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
    internal class Fabricante
    {
        public virtual string Nome {  get; set; }
        public string Endereco { get; private set; }
        public string Cidade { get; private set; }

        
    }

    internal class Produto : Fabricante
    {
        public override string Nome { get; set; }
        public double Price { get; set; }

        public void nome(string nome)
        {
            if (nome == null)
            {
                Nome = nome;
            }


        }
    }
}
