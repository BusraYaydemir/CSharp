using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D19_EntityFeamworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            /*todo
             * using ne için, neler için ve ne zaman kullanılır? 
             * 
             * ETradeContext'i new lemek memory için pahalı bir işlevdir. Dolayısıyla bizim bu object ile işimiz bittiği zaman otomatik olarak garbage collector'ı beklemeden bellekten silmemiz gerekir. 
             * ETradeContext, DbContext classını extend etmiştir. DbContext classı ise IDisposable interface'ni implement etmiştir. 
             * IDisposable interfacelerinin inherit edildikleri classlar usingde kullanılabilir. 
             * Bu işi bittiği zaman bellekten zorla atılmasını sağlayan interfacedir.
             * using'in parantezleri içinde object kullanılır. Parantez bitince ise bellekten nesne zorla silinir. 
             */

            using (ETradeContext context = new ETradeContext())
            {
                /*todo
                 * Sadece Aşağıdakini yazmak yetmez. Hangi veritabanına bağlanacağını bildirmek için App Config dosyasına connectionStrings yazarız.
                 */
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product);
                //var entity = context.Entry(product);
                //entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }


        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p=> p.Name.Contains(key)).ToList();
            };
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.FirstOrDefault(p=> p.Id==id);
            };
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min&&p.UnitPrice <= max).ToList();
            };
        }

        public List<Product> GetByStockAmount(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.StockAmount >= min && p.StockAmount <= max).ToList();
            };
        }

    }
}
