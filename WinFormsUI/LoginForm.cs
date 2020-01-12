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
    public partial class LoginForm : Form
    {
        IUserService _userService;

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbxUsername.Text.Length == 0 || tbxPassword.Text.Length == 0)
            {
                StatusText.Text = "Kullanıcı Adı ve Şifre Boş Olamaz...";
            }
            else
            {
                if (_userService.Login(tbxUsername.Text, tbxPassword.Text))
                {
                    this.Hide();
                }
                else
                {
                    StatusText.Text = "Kullanıcı veya Şifre hatalı, lütfen tekrar deneyiniz...";
                }
            }
            
            
            //StatusText.Text = "Giriş işlemi başarılı";
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.btnLogin_Click(sender, e);
            }
        }

        private void btnPswdRecovery_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
