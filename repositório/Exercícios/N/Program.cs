using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            int opcao=0;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Armazenar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Altura: ");
                        float altura = float.Parse(Console.ReadLine());
                        agenda.armazenaPessoa(nome, idade, altura);
                        break;

                    case 2:

                        Console.Write("Nome da pessoa a ser removida: ");
                        nome = Console.ReadLine();
                        agenda.removePessoa(nome);
                        break;

                    case 3:
                        Console.Write("Nome da pessoa a ser buscada: ");
                        nome = Console.ReadLine();
                        Agenda pessoa = agenda.buscaPessoa(nome);
                        if (pessoa != null)
                        {
                            Console.WriteLine("Pessoa encontrada: " + pessoa);
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada.");
                        }
                        break;

                    case 4:
                        agenda.ImprimeAgenda();
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
