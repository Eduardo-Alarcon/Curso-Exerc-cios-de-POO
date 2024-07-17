using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Taredas
{
    internal class Gerenciar
    {
        public string Descriocao { get; set; }
        public string dataVencimento { get; set; }

        public Gerenciar(string descricao, string dataVencimento)
        {
            this.Descriocao = descricao;
            this.dataVencimento = dataVencimento;
        }
    }
    public class GerenciarT
    {
        private List<Gerenciar> gerenciar;
        public GerenciarT()
        {
            gerenciar = new List<Gerenciar>();
        }

        public void Adicionar(string descricao, string dataVencimento)
        {
            Gerenciar addTarefa = new Gerenciar(descricao, dataVencimento);
            gerenciar.Add(addTarefa);
            Console.WriteLine("Nova tarefa adicionada");
        }
        public void Remover(string descricao)
        {
            Gerenciar removerTarefa = gerenciar.Find(c=> c.Descriocao == descricao);
            if (removerTarefa != null)
            {
                gerenciar.Remove(removerTarefa);
                Console.WriteLine($"A tarefa #{descricao} foi removida com sucesso!");

            }
            else
            {
                Console.WriteLine("Não foi possivel remover");
            }
        }
    }
}
