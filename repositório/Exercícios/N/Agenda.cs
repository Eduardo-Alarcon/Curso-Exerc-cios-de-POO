using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N
{
    internal class Agenda
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double altura;

        private List<Agenda> agendaList;

        public Agenda(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            this.altura = altura;
        }

        public Agenda(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public Agenda(string nome)
        {
            Nome = nome;
        }

        public Agenda()
        {
            agendaList = new List<Agenda>();
        }

        public void armazenaPessoa(string nome, int idade, double altura)
        {
            Agenda addPessoa = new Agenda(nome, idade);
            agendaList.Add(addPessoa);
            Console.WriteLine("A pessoa" + addPessoa.Nome + " foi adicionada ");
        }

        public void removePessoa(string nome)
        {
            Agenda removerPessoa = new Agenda(nome);
            agendaList.Remove(removerPessoa);
            Console.WriteLine("A pessoa" + removerPessoa+ " foi removida ");
        }

        public Agenda buscaPessoa(string nome)
        {
            Agenda buscaPessoas = agendaList.Find(c=> c.Nome == nome);

            if (buscaPessoas != null)
            {
                Console.WriteLine($"Contato encontrado: {buscaPessoas.Nome}, {buscaPessoas.Idade}, {buscaPessoas.altura}");
            }
            else
            {
                Console.WriteLine($"Contato {nome} não encontrado.");
            }
            return buscaPessoas;
        }

        public void ImprimeAgenda()
        {
            if (agendaList.Count == 0)
            {
                Console.WriteLine("A agenda está vazia.");
                return;
            }

            foreach (var a in agendaList)
            {
                Console.WriteLine(a);
            }
            
        }
    }
}
