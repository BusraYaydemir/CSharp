using Northwind.Business.Abstract;
using Northwind.Business.Concreate;
using Northwind.DataAccess.Concreate.EntityFreamwork;
using Northwind.DataAccess.Concreate.NHibarnate;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        IProductService _productService;
        ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = _productService.GetAll();
        }
    }
}
