using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Product> GetAll()
        {
            // Business Code
            return _productDal.GetAll();
        }

        public Product Get(int id)
        {
            // Business Code
            return _productDal.Get(id);
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
    }
}
