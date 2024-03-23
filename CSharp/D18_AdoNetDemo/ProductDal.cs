using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D18_AdoNetDemo
{
    public class ProductDal
    {
        //todo Connection'a sürekli ihtiyacımız olacağı için onu dışarda tanımlıyorum. Dışarda tanımlanan nesneler için başına _ konur. Best Practice dir.
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        //todo Bağlantı kontrolünü sürekli yapacağımız için onu method haline getiriyorum.
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }




        //todo DataTable ile GetAll : 

        /*todo
         * Burada DataTable ile yaptık ama günümüzde neredeyse DataTable hiç kullanılmamaktadır.
         * Çünkü DataTable memory açısından hem pahalı bir nesnedir, hem de serileştirme özelliği bulunmamaktadır.
         * DataTable AdoNet için yazılmış eski bir nesne. Bu yüzden veriyi Load methodu ile hemen alabiliyoruz.
         */

        /*
        public DataTable GetAll()
        {

            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();
            
            DataTable dataTable = new DataTable();

            dataTable.Load(reader);

            reader.Close();
            _connection.Close();


            return dataTable;
        }
        */


        //todo List ile GetAll : 

        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * From Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();

            return products;
        }


        //todo Eleman Ekleme Methodu : 

        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Insert into Products values (@name, @unitPrice, @stockAmount)", _connection);

            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        //todo Eleman Güncelleme Methodu : 

        public void Update (Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);

            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);

            command.ExecuteNonQuery();
            _connection.Close();
        }
        

        //todo Elemean Silme Methodu : 

        public void Delete(int Id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Delete from Products where Id=@id", _connection);

            command.Parameters.AddWithValue("@id", Id);

            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
