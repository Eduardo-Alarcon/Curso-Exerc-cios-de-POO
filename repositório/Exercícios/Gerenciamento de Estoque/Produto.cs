using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Gerenciamento_de_Estoque
{
    internal class Produto
    {
        public string produto {  get; set; }
        public double price { get; set; }
        public int estoque {  get; set; }

        public Produto(string produto, double price, int estoque)
        {
            this.produto = produto;
            this.price = price;
            this.estoque = estoque;
        }

        private List<Produto> produtos;

        public void Adc(string produto, double price, int quantidade)
        {
            Produto newProdut = new Produto(produto, price, quantidade);
            produtos.Add(newProdut);
            Console.WriteLine($"Produto '{produto}' adicionado ao estoque.");
        }

        public void Rmv(string produto, int quantidade)
        {
            Produto produtoParaVender = produtos.Find(p => p.produtos == produtos);
            if (produtoParaVender != null )
            {
                produtos.Remove(produtoParaVender);
                Console.WriteLine($"Produto #{produto} removido com sucesso!");
            }
        }
        public void Veri(string produto)
        {
            foreach(Produto produtos in produtos)
            {
                Console.WriteLine($"Produto: {produtos.produtos}, Valor: {produtos.price}");
            }
        }
    }
}
