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
    public partial class CreateLocationForm : Form
    {
        Form1 _parent;
        ILocationService _locationService;
        public CreateLocationForm(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
            _locationService = new LocationManager(new EfLocationDal());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Location location = new Location
            {
                Name = tbxLocationName.Text,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            _locationService.Add(location);
            _parent.UpdateStatusBarLabel("Lokasyon Eklenmiştir.");
            this.Close();
            
        }
    }
}
