using Order_People.Entitites;
using Order_People.Entitites.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_People
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Product product = new Product();
            Order order = new Order();
            OrderItem item = new OrderItem();

            Console.WriteLine("Enter client data: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date ( DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            client = new Client(nome, email, birthDate);
            order = new Order(birthDate, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string Nome = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                product = new Product(Nome, price);
                item = new OrderItem(quantity, price, product);

                order.Items.Add(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

            Console.ReadKey();
        }
    }
}
