using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Model;

namespace DAL_.reprosatory
{
    public class ProductReprosatory : IProductReprosatory
    {
        CafeteriaContext db;
        public ProductReprosatory()
        {
            db = new CafeteriaContext();
        }


        public List<Product> GetAll()
        {
            var res = db.Products.ToList();
            return res;
        }
        public Product GetById(int id)
        {
            var res = db.Products.FirstOrDefault(p => p.Id == id);
            return res;
        }
        public void Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        public void Update(Product product, int count)
        {
            var existingProduct = db.Products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.StockQuantity -= count;
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var product = db.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }

    }
}
