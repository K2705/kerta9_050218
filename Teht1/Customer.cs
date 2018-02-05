using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }

        public void PrintOrders()
        {
            foreach (Order order in Orders)
            {
                foreach (OrderItem item in order.OrdersItems)
                {
                    Console.WriteLine(item.Name + ", " + item.Count);
                }
            }
        }
    }
}
