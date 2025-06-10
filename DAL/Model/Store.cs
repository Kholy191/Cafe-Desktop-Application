using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Store
    {
        public int Product_Id { get; set; }
        public DateOnly Expired_date { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Product_Id")]
        public Product Product { get; set; }
    }
}
