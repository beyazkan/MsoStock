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
    public partial class ListofStoresForm : Form
    {
        IStoreService _storeService;
        public ListofStoresForm()
        {
            InitializeComponent();
            _storeService = new StoreManager(new EfStoreDal());
        }

        private void ListofStoresForm_Load(object sender, EventArgs e)
        {
            dgwListofStores.DataSource = _storeService.GetAll();
        }
    }
}
