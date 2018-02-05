using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class OrderItem
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public OrderItem(string name, int count)
        {
            Name = name;
            Count = count;
        }
    }
}
