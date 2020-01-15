using Stock.Business.Abstract;
using Stock.Business.Concrete;
using Stock.DataAccess.Concrete.EntityFramework;
using Stock.Entities.Concrete;
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
        Form1 _form1;
        IProductTypeService _productTypeService;
        IUsefulTypeService _usefulTypeService;
        IProductService _productService;

        public CreateProductForm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            _productService = new ProductManager(new EfProductDal());
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product {
                Name = tbxName.Text,
                Brand = tbxMarks.Text,
                Model = tbxModel.Text,
                Price = Convert.ToDecimal(tbxPrice.Text),
                Warranty = Convert.ToInt32(nUDWarranty.Value),
                Type = cbxProductType.SelectedIndex,
                WorkType = cbxUsefulType.SelectedIndex,
                Barcode = tbxBarcode.Text,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            _productService.Add(product);
            _form1.UpdateStatusBarLabel("Ürün eklenmiştir.");
            this.Close();
            
        }
    }
}
