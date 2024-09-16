using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concreate.NHibarnate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {

        }

        public void Delete(Product product)
        {

        }


        public void Update(Product product)
        {

        }


        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product> {
                new Product() {
                    ProductId = 1, CategoryId = 1, ProductName = "Laptop", UnitPrice = 25000, QuantityPerUnit = "1 in a box", UnitsInStock = 150
                }
            };
            return products;
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return new Product();
        }
    }
}

