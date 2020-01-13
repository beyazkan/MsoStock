using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class MainForm : Form
    {
        Form1 _form1;
        LoadingForm _loadingForm;
        LoginForm _loginForm;
        LoadObject _loadObjects;

        public MainForm()
        {
            InitializeComponent();
            
            _loadingForm = new LoadingForm();
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            _loadObjects = new LoadObject(_loadingForm);


            _form1 = new Form1(_loadObjects);
            _loginForm = new LoginForm(_form1);
            
            t.Abort();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _loginForm.Show();
        }

        private void Loading()
        {
            Application.Run(_loadingForm);
        }
    }
}
