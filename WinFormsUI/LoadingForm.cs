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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        public void PercentUpdate(int percent, string message)
        {
            lblLoadString.Text = message;
            progressBar1.Value = percent;
            lblPercent.Text = SetPercent(percent);
        }

        private string SetPercent(int percent)
        {
            return percent + "/100";
        }
    }
}
