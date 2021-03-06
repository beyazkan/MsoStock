﻿using Stock.Business.Abstract;
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
    public partial class ProductTypeForm : Form
    {
        IProductTypeService _productTypeService;
        CreateProductForm _parentForm;

        public ProductTypeForm(CreateProductForm parent)
        {
            InitializeComponent();
            _productTypeService = new ProductTypeManager(new EfProductTypeDal());
            this.LoadList();
            _parentForm = parent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductType productType = new ProductType
            {
                Name = tbxName.Text,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            _productTypeService.Add(productType);
            this.LoadList();
            _parentForm.LoadProductTypes();
            this.Close();
        }

        void LoadList()
        {
            dgwProductType.DataSource = _productTypeService.GetAll();
        }
    }
}
