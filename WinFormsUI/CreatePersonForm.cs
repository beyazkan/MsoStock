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
    public partial class CreatePersonForm : Form
    {
        IPersonService _personService;

        public CreatePersonForm()
        {
            InitializeComponent();
            _personService = new PersonManager(new EfPersonDal());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Name = tbxName.Text,
                LastName = tbxLastName.Text,
                PersonID = mTbxPersonId.Text,
                Telephone = mTbxTelephone.Text,
                Email = tbxMail.Text,
                //UpdatedDate = DateTime.Now
            };

            _personService.Add(person);
            this.Close();
        }
    }
}
