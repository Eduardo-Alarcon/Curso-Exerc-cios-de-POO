using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    internal class Animal
    {
        public string Nome {  get; set; }
        private string Especie { get; set; }
        public int Idade { get; set; }

        

        public void EmitirSom()
        {
            Console.WriteLine("Escolha um animal:\n Gato\n Cahorro\n Ovelha");
            string chose = Console.ReadLine();
            if ( chose == "Gato")
            {
                Console.WriteLine("O som do animal " + Nome + " é Miau"); 
            }
            if (chose == "Cachorro")
            {
                Console.WriteLine("O som do animal " + Nome + " é Hurf");
            }
            if (chose == "Ovelha")
            {
                Console.WriteLine("O som do animal " + Nome + " é Bée");
            }
            else { Console.WriteLine("Tem que ser gato, cahorro ou ovelha"); }
        }
    }
}
