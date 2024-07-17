using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica();

            // Adicionando alguns contatos
            agenda.AdicionarContato("José", "555666777", "jose@example.com");

            // Listando todos os contatos
            agenda.ListarContatos();

            // Buscando um contato pelo nome
            agenda.BuscarContato("Maria");

            // Removendo um contato pelo nome
            agenda.RemoverContato("João");

            // Listando os contatos após a remoção
            agenda.ListarContatos();



            Console.ReadKey();
        }
    }
}
