using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 conta = new Class1("s", 2);
            Console.Write("# Nome da conta: ");
            string titular = Console.ReadLine();

            Console.Write("# Senha da conta: ");
            int senha = int.Parse(Console.ReadLine());

            Console.Write("# Fará algum depósito ? ");
            char s = char.Parse(Console.ReadLine());

            if (s == 's')
            {
                Console.Write("### Quantos deseja-se depositar ? ###\n");
                double v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Depositar(v);
                conta = new Class1(titular, senha, v);
            }
            else
            {
                conta = new Class1(titular, senha);
            }

            Console.WriteLine();

            Console.WriteLine("# - Dados da conta : " + conta + " - #");

            Console.WriteLine();

            Console.Write("### Quantos deseja-se sacar ? ###\n");
            double sacar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(sacar);
            conta = new Class1(titular, senha, sacar);

            Console.WriteLine("");


            Console.WriteLine("# - Dados da conta : " + conta + " - #");


            Console.ReadKey();
        }
    }
}
