using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o nome do produto ?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o preço do produto?");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade .. ?");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            p.Adc(nome, preco, quantidade);


            Console.WriteLine("Qual o nome do produto ?");
            string nome1 = Console.ReadLine();

            Console.WriteLine("Qual o preço do produto?");
            int Quantidade = int.Parse(Console.ReadLine());

            p.Rmv(nome1, Quantidade);

            p.Veri(nome);

            Console.ReadLine();

        }
    }
}
