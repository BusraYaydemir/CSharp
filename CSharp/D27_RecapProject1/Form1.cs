using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D27_RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listproducts();
            ListCategories();
            cbxCategory.Text = string.Empty;
        }

        private void Listproducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                // using IDisposible formatta, yani Grabage Collectorü beklemeden iş bitince silinmesi

                dgvProduct.DataSource = context.Products.ToList();
            }
        }

        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }

        private void ListProductsByCategory(int selectedValue) 
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgvProduct.DataSource = context.Products.Where(p => p.CategoryId == selectedValue).ToList();
            }
        }

        private void ListProductsByName(string value)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgvProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(value.ToLower())).ToList();

                // Sql Server büyük küçük harf duyarsızdır, yani ToLower() ı koymasakdık da gayet düzgün çalışacaktı, ama oracle gibi veritabanı yönetim sistemleri büyük küçük harf duyarlıdır. Hepsine uygun olsun diye ToLower() koyduk.

                // ToLower() ' ı koymadan önce name alanına bir şey yazıp silince tüm elemanları getiriyordu. Ama ToLower() koyunca bir şey yazıp silince hiç bir elemanı getirmemeye başladı. Bu durumda da name alanının change'ine kontrol ekledik.
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(cbxCategory.Text.ToString() + ": " + cbxCategory.SelectedValue.ToString());
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
            
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            var key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                Listproducts();
            } else
            {
                ListProductsByName(key);
            }
            
        }
    }
}
