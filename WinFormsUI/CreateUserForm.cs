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
    public partial class CreateUserForm : Form
    {
        Form1 _parent;
        IUserService _userService;
        IPersonService _personService;

        public CreateUserForm(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
            _userService = new UserManager(new EfUserDal());
            _personService = new PersonManager(new EfPersonDal());
            LoadPerson();
        }

        private void LoadPerson()
        {
            cbxUser.DataSource = _personService.GetAllFullName();
            cbxUser.DisplayMember = "FullName";
            cbxUser.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbxPassword.Text) && string.IsNullOrEmpty(tbxPasswordAgain.Text))
                
            {
                MessageBox.Show("Lütfen Şifre alanlarını doldurunuz...");
            }
            else if (string.IsNullOrEmpty(tbxUserName.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı giriniz...");
            }
            else if(tbxPassword.Text != tbxPasswordAgain.Text)
            {
                MessageBox.Show("Girdiğiniz parolalar birbiri ile uyuşmamaktadır.");
            }
            else
            {
                User user = new User{
                    UserId = cbxUser.SelectedIndex,
                    Username = tbxUserName.Text,
                    Password = tbxPassword.Text,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Authorization = "Admin",
                    Last_Logon = DateTime.Now
                };

                _userService.Add(user);
                _parent.UpdateStatusBarLabel("Kullanıcı başarılı bir şekilde oluşturulmuştur.");
                this.Close();
                    
            }           

        }
    }
}
