using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal();

            animal.EmitirSom();

            Console.ReadKey();
        }
    }
}
