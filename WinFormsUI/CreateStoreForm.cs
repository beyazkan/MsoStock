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
    public partial class CreateStoreForm : Form
    {
        Form1 _form1;
        IStoreService _storeService;
        IPersonService _personService;

        public CreateStoreForm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            _storeService = new StoreManager(new EfStoreDal());
            _personService = new PersonManager(new EfPersonDal());
            LoadPersonList();
        }

        private void LoadPersonList()
        {
            cbxPerson.DataSource = _personService.GetAll();
            cbxPerson.DisplayMember = "Name";
            cbxPerson.ValueMember = "Id";
        }

        private void save_Click(object sender, EventArgs e)
        {
            Store store = new Store
            {
                Name = tbxName.Text,
                PersonId = cbxPerson.SelectedIndex
            };

            _storeService.Add(store);
            _form1.UpdateStatusBarLabel("Depo eklenmiştir.");
            this.Close();
        }
    }
}
