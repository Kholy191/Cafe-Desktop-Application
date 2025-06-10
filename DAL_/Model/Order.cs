using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int T_Price { get; set; }
        public HashSet<OrderProcuct> orderProcuct { get; set; } = new HashSet<OrderProcuct>();
    }
}
