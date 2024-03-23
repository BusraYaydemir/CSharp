using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*todo
 * Günümüzde artık klasik ADONET kodlarıyla program yazdığımızı pek söyleyemeyiz.
 * Onun yerine günümüzde bu işlemleri bizim için oldukça kolaylaştıran ORM (Object-Releational Mapping) denilen teknolojiler var.
 * Veritabanı nesneleri ile classları birbiri ile ilişkilendirip pek kod yazmadan hızlıca programlamayı sağlar. 
 * Mimarisi ADONET'tir. Yani yine ADONET kullanılır, ama daha nesneldir. 
 */

/*todo
 * İlk adım olarak: Manage NuGet packages'dan Entity freamworkü projeye eklememiz gerekiyor.
 * Eklenip eklenmediğini Referances'ın altından kontrol edebiliriz. 2 tane Entity Freamwork referansı eklenmiş olmalı. 
 */

/*todo
 * Entity Freamwork'deki temel unsur: veritabanı tablolarına karşılık gelecek bir classın olmasıdır. 
 * Yani Veritabanımızıda Product tablosu olduğu için bu classdaki gibi Product classının açılmış olması gerekmektedir. 
 */

/*todo
 * Entity Freamwork'e "bu class veritabanındaki şu tabloya karşılık geliyor" diyebilmek için Context kullanırız. 
 * Bir projede birden fazla context olabilir ama genellikle bir tane context kullanlır. 
 * İsimlendirme kuralı: DatabasenameContext
 * public yapılır. ve entity freamwork contexti olabilmesi için DbContext inherit edilir. 
 * Unit of work design pattern'ını implemente eden yapıdır. 
 */


namespace D19_EntityFeamworkDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
