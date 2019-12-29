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
    public partial class CreateProductForm : Form
    {
        IProductTypeService _productTypeService;
        IUsefulTypeService _usefulTypeService;

        public CreateProductForm()
        {
            InitializeComponent();
            _productTypeService = new ProductTypeManager(new EfProductTypeDal());
            _usefulTypeService = new UsefulTypeManager(new EfUsefulTypeDal());
            LoadProductTypes();
            LoadUsefulTypes();
        }

        public void LoadUsefulTypes()
        {
            cbxUsefulType.DataSource = _usefulTypeService.GetAll();
            cbxUsefulType.DisplayMember = "Name";
            cbxUsefulType.ValueMember = "Id";
        }

        public void LoadProductTypes()
        {
            cbxProductType.DataSource = _productTypeService.GetAll();
            cbxProductType.DisplayMember = "Name";
            cbxProductType.ValueMember = "Id";
        }

        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            ProductTypeForm productTypeForm = new ProductTypeForm(this);
            productTypeForm.Show();
        }

        private void btnAddUsefulType_Click(object sender, EventArgs e)
        {
            UsefulTypeForm usefulTypeForm = new UsefulTypeForm(this);
            usefulTypeForm.Show();
        }
    }
}
