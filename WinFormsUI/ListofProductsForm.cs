using Stock.Business.Abstract;
using Stock.Business.Concrete;
using Stock.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class ListofProductsForm : Form
    {
        IProductService _productService;
        public ListofProductsForm()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            LoadProducts();
        }

        private void LoadProducts()
        {
            bindingSource1.DataSource = _productService.GetAll();
            adgwProducts.DataSource = bindingSource1.DataSource;
        }
    }
}
