using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "lloth";
            Customer customer2 = new Customer();
            customer2.Name = "torm";

            customer1.Orders.Add(new Order());
            customer1.Orders.Add(new Order());
            customer2.Orders.Add(new Order());

            customer1.Orders[0].OrdersItems.Add(new OrderItem("order1", 100));
            customer1.Orders[0].OrdersItems.Add(new OrderItem("order2", 1));
            customer1.Orders[0].OrdersItems.Add(new OrderItem("order3", 10));

            customer1.Orders[1].OrdersItems.Add(new OrderItem("order4", 2));
            customer1.Orders[1].OrdersItems.Add(new OrderItem("order6", 1));

            customer2.Orders[0].OrdersItems.Add(new OrderItem("order7", 1));

            Console.WriteLine("customer 1:");
            customer1.PrintOrders();
            Console.WriteLine("customer 2:");
            customer2.PrintOrders();
        }
    }
}
