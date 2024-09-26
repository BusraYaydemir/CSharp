using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concreate
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
           _productDal = productDal;
        }

        public void Add(Product product)
        {
            // Business Code
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            // Business Code
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            // Business Code
            _productDal.Delete(product);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            // Buisness Code
            return _productDal.GetAll(filter);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            // Business Code 
            return _productDal.Get(filter);
        }
    }
}
