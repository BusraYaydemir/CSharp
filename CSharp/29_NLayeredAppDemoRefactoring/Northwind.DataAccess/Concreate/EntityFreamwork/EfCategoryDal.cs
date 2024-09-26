using Northwind.DataAccess.Abstract;
using Northwind.Entities.Abstract;
using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DataAccess.Abstract;

namespace Northwind.DataAccess.Concreate.EntityFreamwork
{
    public class EfCategoryDal : IEntityRepository<Category, NorthwindContext>, ICategoryDal
    {
    }
}
