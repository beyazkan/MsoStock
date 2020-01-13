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
    public partial class LoadingForm : Form
    {
        int _timer;

        public LoadingForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _timer = 250;
            
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadingUpdate(int percent, string message)
        {
            lblLoadString.Text = message;
            progressBar1.Value = percent;
            lblPercent.Text = SetPercent(percent);
            if(_timer != 0)
                Thread.Sleep(_timer);
        }

        private string SetPercent(int percent)
        {
            return percent + "/100";
        }
    }
}
