using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D19_EntityFeamworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void SearchProductsName(string key)
        {
            /*todo
             * LINQ (Language Integrated Query): 
             * 
             * Dile gömülü bir sorgulama mimarisidir. 
             * Nesneler için olana (array, list,...) LINQ to Objects
             * Entity Freamwork olana ise LINQ to Entity diye geçiyor.
             * Verileri filtrelemeye yarıyor
             */

            /*todo
             * Örnek 1: 
             * var result = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
             * Bu örnekte filtrelemeyi veritabanından verileri aldıktan sonra yaparız. 
             * Yani veriler _productDal.GetAll() ile veritabaından alınır. Sonra gelen sonuçlarda filtreleme uygularız. 
             * Bu filtreleme tipinde büyük harf ile küçük harf ayrı algılanır. Bu yüzden filtrelemede hem büyük harfin hem de küçük harfin aynı algılanmasını istiyorsak ToLower() methodu ile her iki tarafıda küçük harfe dönüştürüp aramalıyız. 
             * 
             * Örnek 2: 
             * context.Products.Where(p=> p.Name.Contains(key)).ToList();
             * bu örnekte ise filtreleme veritabından veriler çekilirken yapılır.
             * context verileri veritabından almaya yarar. 
             * Bu filtreleme tipinde büyük küçük harf ayrı ayrı algılanmaz. Yani büyük K yazdığımızda da küçük k yazdığımızda da aynı sonuçlar döner.
             * Profosyonel uygulamalarda genellikle bu kullanılır. 
             */


            //var result = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();

            var result = _productDal.GetByName(key);

            dgwProducts.DataSource = result;
        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            cmbSearchType.SelectedIndex = 1;
            txtMin.Visible = false;
            txtMax.Visible = false;
            textSearch.Visible = true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product()
            {
                Name = tbxName.Text.ToString(),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Added!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Product Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            };
            _productDal.Delete(product);
            LoadProducts();
            MessageBox.Show("Product Deleted!");
        }


        private void textSearch_TextChanged(object sender, EventArgs e)
        {

            if (cmbSearchType.SelectedIndex == 0)
            {
                if (textSearch.Text != "")
                {
                    SearchProductsId(textSearch.Text);
                }
                else
                {
                    LoadProducts();
                }
            }
            else if (cmbSearchType.SelectedIndex == 1)
            {
                if (textSearch.Text != "")
                {
                    SearchProductsName(textSearch.Text);
                }
                else
                {
                    LoadProducts();
                }
            }


        }

        private void SearchProductsUnitPrice(string key1, string key2)
        {
            var min = decimal.TryParse(key1, out decimal intValue1) ? intValue1 : int.MinValue;
            var max = decimal.TryParse(key2, out decimal intValue2) ? intValue2 : int.MaxValue;

            dgwProducts.DataSource = _productDal.GetByUnitPrice(min, max);
            dgwProducts.Refresh();
        }

        private void SearchProductsId(string key)
        {
            try
            {
                var id = Convert.ToInt32(key);
                var result = _productDal.GetById(id);
                dgwProducts.DataSource = new List<Product> { result };
                dgwProducts.Refresh();
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Giriniz");
            }
        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchType.SelectedIndex == 0 || cmbSearchType.SelectedIndex == 1)
            {
                txtMin.Visible = false;
                txtMax.Visible = false;
                textSearch.Visible = true;
            }
            else if (cmbSearchType.SelectedIndex == 2 || cmbSearchType.SelectedIndex == 3)
            {
                txtMin.Visible = true;
                txtMax.Visible = true;
                textSearch.Visible = false;
            }
            else
            {
                txtMin.Visible = false;
                txtMax.Visible = false;
                textSearch.Visible = false;
            }
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearchType.SelectedIndex == 2)
            {
                
                    SearchProductsUnitPrice(txtMin.Text, txtMax.Text);
                
            }
            else if (cmbSearchType.SelectedIndex == 3)
            {
                
                    SearchProductsStockAmount(txtMin.Text, txtMax.Text);
                
            }
        }

        private void SearchProductsStockAmount(string key1, string key2)
        {
            var min = decimal.TryParse(key1, out decimal intValue1) ? intValue1 : int.MinValue;
            var max = decimal.TryParse(key2, out decimal intValue2) ? intValue2 : int.MaxValue;

            dgwProducts.DataSource = _productDal.GetByStockAmount(min, max);
            dgwProducts.Refresh();
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearchType.SelectedIndex == 2)
            {
                SearchProductsUnitPrice(txtMin.Text, txtMax.Text);
            }
            else if (cmbSearchType.SelectedIndex == 3)
            {
                SearchProductsStockAmount(txtMin.Text, txtMax.Text);
            }
        }
    }
}
