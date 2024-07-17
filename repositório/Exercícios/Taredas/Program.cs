using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Advanced;
using Taredas;

namespace Tarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciarT gerenciar = new GerenciarT();

            Console.WriteLine("Quantas tarefas deseja controlar ?");
            int r = int.Parse(Console.ReadLine());

            for (int i = 0; i < r; i++)
            {
                Console.WriteLine("Qual a tarefa?");
                string descricao = Console.ReadLine();

                Console.WriteLine("Qual a data?");
                string data = Console.ReadLine();
                gerenciar.Adicionar(descricao, data);
            }

            Console.WriteLine("Deseja remover alguma tarefa?\n [ SIM }\n [ NAO }");
            string resposta = Console.ReadLine();

            if (resposta == "SIM")
            {
                Console.WriteLine("Qual tarefa deseja remover?");
                gerenciar.Remover(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
