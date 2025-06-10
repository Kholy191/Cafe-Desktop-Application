using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Category { get; set; }

        public HashSet<Store> Stores { get; set; } = new HashSet<Store>();
        public HashSet<OrderProcuct> OrderProcucts { get; set; } = new HashSet<OrderProcuct>();
    }
}
