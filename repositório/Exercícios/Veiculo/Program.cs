using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Fusca", 1975);
            carro.Acelerar();
            carro.Acelerar();
            carro.DesAcelerar();
            carro.Acelerar();
            carro.DesAcelerar();

            Console.ReadKey();
        }
    }
}
