using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Order
    {
        public string ID { get; set; }
        public List<OrderItem> OrdersItems { get; set; }

        public Order()
        {
            OrdersItems = new List<OrderItem>();
        }
    }
}
