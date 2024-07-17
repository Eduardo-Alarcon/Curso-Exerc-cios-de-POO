using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    internal class Carro
    {
        public string Modelo { get; private set; }
        public int Ano {  get; private set; }
        public double Velocidade { get; set; }


        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0;
        } 

        public void Acelerar()
        {
            Velocidade += 10;
            Console.WriteLine("Agora o carro está a: " + Velocidade);
        }

        public void DesAcelerar()
        {
            Velocidade -= 10;
            Console.WriteLine("Agora o carro está a: " + Velocidade);
        }
    }
}
