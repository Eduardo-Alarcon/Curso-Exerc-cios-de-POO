using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            R r = new R();

            Console.WriteLine("Qual o nome do produto?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o valor?");
            double valor = double.Parse(Console.ReadLine());

            r.Adicionar(nome, valor);

            Console.WriteLine();
            Console.WriteLine("Lista de Produtos após adição:");
            r.AChar(nome);

            Console.WriteLine();
            Console.WriteLine("Qual o nome do produto que deseja remover?");
            string produtoParaRemover = Console.ReadLine();

            r.Remover(produtoParaRemover);

            Console.WriteLine();
            Console.WriteLine("Lista de Produtos após remoção:");
            r.AChar(nome);

            Console.ReadKey();
        }
    }
}
