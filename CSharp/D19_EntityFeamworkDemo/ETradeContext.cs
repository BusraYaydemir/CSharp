using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D19_EntityFeamworkDemo
{
    public  class ETradeContext : DbContext
    {
        /*todo
         * Bu atama şu anlamdadır: 
         * public DbSet<ClassName> DatabaseTableName { get; set; }
         * Veritabanımdaki DatabaseTableName (Products) tablosuna programımdaki ClassName (Product) tablosu karşılık gelmektedir.
         */
        public DbSet<Product> Products { get; set; }
    }
}
