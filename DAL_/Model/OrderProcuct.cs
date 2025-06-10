using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Model
{
     public class OrderProcuct
    {
        //[ForeignKey]
        public int Order_Id { get; set; }
        public int Product_Id { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Order_Id")]
        public Order Orders { get; set; } = new Order();

        [ForeignKey("Product_Id")]
        public Product Products { get; set; } = new Product();


    }
}
