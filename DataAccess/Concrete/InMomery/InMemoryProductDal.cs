using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMomery
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {

              new Product { CategoryId= 1,ProductId= 1,ProductName="bardak",UnitPrice=15,UnitsInStock=15},
              new Product { CategoryId= 2,ProductId= 1,ProductName="kamera",UnitPrice=500,UnitsInStock=3},
              new Product { CategoryId= 3,ProductId= 2,ProductName="telefon",UnitPrice=1500,UnitsInStock=2},
              new Product { CategoryId= 4,ProductId= 2,ProductName="klavye",UnitPrice=150,UnitsInStock=65},
              new Product { CategoryId= 5,ProductId= 2,ProductName="fare",UnitPrice=85,UnitsInStock=1}
            };
        }


        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete  = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            
            _products.Remove(productToDelete); 
        }

        public Product Get(Expression<Func<Product, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> fiter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int category)
        {
            return _products.Where(p => p.CategoryId==category).ToList();
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;

        }
    }
}
