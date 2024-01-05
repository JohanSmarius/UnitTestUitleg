using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestUitleg
{
    public class Order
    {
        public List<OrderItem> OrderItems { get; set; }
        public string Customer { get; set; }
    }
}
