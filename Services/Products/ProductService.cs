using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using Microsoft.Identity.Client;
using DAL_.reprosatory;

namespace BLL.Products
{
    internal class ProductService
    {

         readonly IProductReprosatory _productRepository;
        public ProductService()
        {
            _productRepository = new ProductReprosatory();
        }


        public List<Product> GetProducts()
        {
            var res =  _productRepository.GetAll();
            return res;
        }
        public Product GetProductById(int id)
        {
            var res = _productRepository.GetById(id);
            return res;
        }
        public void AddProduct(Product product)
        {
            if (product == null)
            {
                _productRepository.Add(product);
            }  
        }
        public void UpdateProductCount( int _id, int count)
        {
            var product = _productRepository.GetById(_id);
            if (product != null)
            {
                _productRepository.Update(product, count);
            }
        }
        public void DeleteProduct(int id)
        {
             _productRepository.Delete(id);

        }
    }
}