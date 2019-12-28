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
    public partial class ListofPersonsForm : Form
    {
        IPersonService _personService;
        public ListofPersonsForm()
        {
            InitializeComponent();
            _personService = new PersonManager(new EfPersonDal());
            dgwPersonList.DataSource = _personService.GetAll();
        }
    }
}
