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
    public partial class UsefulTypeForm : Form
    {
        IUsefulTypeService _UsefulTypeService;
        CreateProductForm _parentForm;

        public UsefulTypeForm(CreateProductForm parent)
        {
            InitializeComponent();
            _UsefulTypeService = new UsefulTypeManager(new EfUsefulTypeDal());
            _parentForm = parent;
            this.LoadList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UsefulType usefulType = new UsefulType
            {
                Name = tbxName.Text,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            _UsefulTypeService.Add(usefulType);
            this.LoadList();
            _parentForm.LoadUsefulTypes();
            this.Close();
        }

        void LoadList()
        {
            dgwUsefulType.DataSource = _UsefulTypeService.GetAll();
        }
    }
}
