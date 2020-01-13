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
        Form1 _form1;
        IUserService _userService;

        public LoginForm(Form1 parentForm)
        {
            InitializeComponent();
            _form1 = parentForm;
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
                    _form1.Show();
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
            _form1.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Activate();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
