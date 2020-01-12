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
    public partial class ListofUsersForm : Form
    {
        IUserService _userService;
        public ListofUsersForm()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
            LoadUsers();
        }

        private void LoadUsers()
        {
            advancedDataGridView1.DataSource = _userService.GetAll();
        }
    }
}
