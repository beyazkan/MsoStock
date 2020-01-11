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
            dgwProducts.DataSource = _productService.GetAll();
            dgwProducts.Columns[0].HeaderText = "Sıra No";
            dgwProducts.Columns[0].Visible = false;
            dgwProducts.Columns[1].HeaderText = "Ürün İsmi";
            dgwProducts.Columns[2].HeaderText = "Markası";
            dgwProducts.Columns[3].HeaderText = "Modeli";
            dgwProducts.Columns[4].HeaderText = "Ürün Tipi";
            dgwProducts.Columns[5].HeaderText = "Kullanım Tipi";
            dgwProducts.Columns[6].HeaderText = "Garanti Süresi";
            dgwProducts.Columns[7].HeaderText = "Fiyatı";
            dgwProducts.Columns[8].HeaderText = "Barkot Numarası";
            dgwProducts.Columns[9].HeaderText = "Oluşturulma Tarihi";
            dgwProducts.Columns[9].Visible = false;
            dgwProducts.Columns[10].HeaderText = "Güncellenme Tarihi";
            dgwProducts.Columns[10].Visible = false;
        }
    }
}
