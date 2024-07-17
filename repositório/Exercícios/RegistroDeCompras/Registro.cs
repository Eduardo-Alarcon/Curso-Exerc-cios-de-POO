using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeCompras
{
    internal class Registro
    {
        public string Produto { get; set; }
        public double Valor { get; set; }

        public Registro(string produto, double valor)
        {
            this.Produto = produto;
            this.Valor = valor;
        }
    }
    public class R
    {
        private List<Registro> registro;

        public R()
        {
            registro = new List<Registro>();
        }

        public void Adicionar(string produto, double valor)
        {
            Registro novoRegistro = new Registro(produto, valor);
            registro.Add(novoRegistro);
            Console.WriteLine("produto " + produto + " Adicionado ");
        }
        public void Remover(string produto)
        {
            Registro removerProduto = registro.Find(c => c.Produto == produto);
            {
                if ( removerProduto != null) 
                {
                    registro.Remove(removerProduto) ;  
                    Console.WriteLine("produto " + produto + " removido ");

                }
                else 
                {
                    Console.WriteLine("Produto não encontrado");
                }
            }
        }

        public void AChar(string produto)
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (Registro registro in registro)
            {
                Console.WriteLine($"Produto: {registro.Produto}, Valor: {registro.Valor}");
            }
        }
    }
}
