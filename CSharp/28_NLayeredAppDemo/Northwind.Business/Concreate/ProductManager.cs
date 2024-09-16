using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Concreate;


namespace Northwind.Business.Concreate
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();
        public List<Product> GetAll()
        {
            // Business Code : Bu methoda erişme yetkin var mı?
            
            return _productDal.GetAll();
        }

        public Product All(int id)
        {
            // Business Code : Bu methoda erişme yetkin var mı?

            return _productDal.Get(id);
        }

        public void Add(Product product)
        {
            // Business Code : Bu methoda erişme yetkin var mı?

            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            // Business Code : Bu methoda erişme yetkin var mı?

            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            // Business Code : Bu methoda erişme yetkin var mı?

            _productDal.Delete(product);
        }
    }
}
