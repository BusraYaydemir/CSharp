using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concreate.EntityFreamwork
{
    public class EfProductDal :EfEntityRepositoryBase<Product, NorthwindContext>,  IProductDal
    {
        
    }
}
