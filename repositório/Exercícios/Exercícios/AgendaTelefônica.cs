using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
    class AgendaTelefonica
            {
                private List<Contato> contatos;

                public AgendaTelefonica()
                {
                    contatos = new List<Contato>();
                }

                // Método para adicionar um novo contato
                public void AdicionarContato(string nome, string telefone, string email)
                {
                    Contato novoContato = new Contato(nome, telefone, email);
                    contatos.Add(novoContato);
                }

                // Método para remover um contato pelo nome
                public void RemoverContato(string nome)
                {
                    Contato contatoParaRemover = contatos.Find(c => c.Nome == nome);
                    if (contatoParaRemover != null)
                    {
                        contatos.Remove(contatoParaRemover);
                        Console.WriteLine($"Contato {nome} removido com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine($"Contato {nome} não encontrado.");
                    }
                }

                // Método para buscar um contato pelo nome
                public Contato BuscarContato(string nome)
                {
                    Contato contatoEncontrado = contatos.Find(c => c.Nome == nome);
                    if (contatoEncontrado != null)
                    {
                        Console.WriteLine($"Contato encontrado: {contatoEncontrado.Nome}, {contatoEncontrado.Telefone}, {contatoEncontrado.Email}");
                    }
                    else
                    {
                        Console.WriteLine($"Contato {nome} não encontrado.");
                    }
                    return contatoEncontrado;
                }

                // Método para listar todos os contatos
                public void ListarContatos()
                {
                    Console.WriteLine("Lista de Contatos:");
                    foreach (Contato contato in contatos)
                    {
                        Console.WriteLine($"{contato.Nome}, {contato.Telefone}, {contato.Email}");
                    }
                }
            }

}
