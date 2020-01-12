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
        public LoadingForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            this.PercentUpdate(5, "Program açılıyor...");
            Thread.Sleep(250);
            this.PercentUpdate(10, "Depo oluşturma yükleniyor...");
            this.PercentUpdate(15, "Ürün oluşturma yükleniyor...");
            this.PercentUpdate(20, "Lokasyon oluşturma yükleniyor...");
            this.PercentUpdate(25, "Kişi oluşturma yükleniyor...");
            this.PercentUpdate(30, "Kullanıcı oluşturma yükleniyor...");
            this.PercentUpdate(35, "Hakkımda yükleniyor...");
            this.PercentUpdate(40, "Depo listesi yükleniyor...");
            this.PercentUpdate(45, "Ürün listesi yükleniyor...");
            this.PercentUpdate(50, "Lokasyon listesi yükleniyor...");
            this.PercentUpdate(55, "Kişi listesi yükleniyor...");
            this.PercentUpdate(60, "Kullanıcı listesi yükleniyor...");
            this.PercentUpdate(65, "Şifre değiştirme yükleniyor...");
            this.PercentUpdate(70, "Ayarlar yükleniyor...");
            this.PercentUpdate(75, "Tercihler yükleniyor...");
            this.PercentUpdate(99, "Yükleme tamamlanıyor...");
            this.PercentUpdate(100, "Yükleme tamamlanıyor...");
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
