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
    public partial class ListofLocationForm : Form
    {
        ILocationService _locationService;
        public ListofLocationForm()
        {
            InitializeComponent();
            _locationService = new LocationManager(new EfLocationDal());

            dgwLocationList.DataSource = _locationService.GetAll();
        }
    }
}
