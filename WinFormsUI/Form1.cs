﻿using System;
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
    public partial class Form1 : Form
    {
        LoadingForm _loadingForm;
        LoginForm _loginForm;
        CreateStoreForm _createStoreForm;
        CreateProductForm _createProductForm;
        CreateLocationForm _createLocationForm;
        CreatePersonForm _createPersonForm;
        CreateUserForm _createUserForm;
        AboutMeForm _aboutMeForm;
        ListofStoresForm _listofStoresForm;
        ListofProductsForm _listofProductsForm;
        ListofLocationForm _listofLocationForm;
        ListofPersonsForm _listofPersonsForm;
        ListofUsersForm _listofUsersForm;
        PswdChangeForm _pswdChangeForm;
        SettingsForm _settingsForm;
        PreferencesForm _preferencesForm;
        int _timer = 500;


        public Form1()
        {
            _loadingForm = new LoadingForm();
            Thread t = new Thread(new ThreadStart(Startup));
            t.Start();
            _loginForm = new LoginForm();
            _loadingForm.PercentUpdate(5, "Program açılıyor...");
            Thread.Sleep(_timer);
            _createStoreForm = new CreateStoreForm();
            _loadingForm.PercentUpdate(10, "Depo oluşturma yükleniyor...");
            Thread.Sleep(_timer);
            _createProductForm = new CreateProductForm();
            _loadingForm.PercentUpdate(15, "Ürün oluşturma yükleniyor...");
            Thread.Sleep(_timer);
            _createLocationForm = new CreateLocationForm();
            _loadingForm.PercentUpdate(20, "Lokasyon oluşturma yükleniyor...");
            Thread.Sleep(_timer);
            _createPersonForm = new CreatePersonForm();
            _loadingForm.PercentUpdate(25, "Kişi oluşturma yükleniyor...");
            Thread.Sleep(_timer);
            _createUserForm = new CreateUserForm();
            _loadingForm.PercentUpdate(30, "Kullanıcı oluşturma yükleniyor...");
            Thread.Sleep(_timer);
            _aboutMeForm = new AboutMeForm();
            _loadingForm.PercentUpdate(35, "Hakkımda yükleniyor...");
            Thread.Sleep(_timer);
            _listofStoresForm = new ListofStoresForm();
            _loadingForm.PercentUpdate(40, "Depo listesi yükleniyor...");
            Thread.Sleep(_timer);
            _listofProductsForm = new ListofProductsForm();
            _loadingForm.PercentUpdate(45, "Ürün listesi yükleniyor...");
            Thread.Sleep(_timer);
            _listofLocationForm = new ListofLocationForm();
            _loadingForm.PercentUpdate(50, "Lokasyon listesi yükleniyor...");
            Thread.Sleep(_timer);
            _listofPersonsForm = new ListofPersonsForm();
            _loadingForm.PercentUpdate(55, "Kişi listesi yükleniyor...");
            Thread.Sleep(_timer);
            _listofUsersForm = new ListofUsersForm();
            _loadingForm.PercentUpdate(60, "Kullanıcı listesi yükleniyor...");
            Thread.Sleep(_timer);
            _pswdChangeForm = new PswdChangeForm();
            _loadingForm.PercentUpdate(65, "Şifre değiştirme yükleniyor...");
            Thread.Sleep(_timer);
            _settingsForm = new SettingsForm();
            _loadingForm.PercentUpdate(70, "Ayarlar yükleniyor...");
            Thread.Sleep(_timer);
            _preferencesForm = new PreferencesForm();
            _loadingForm.PercentUpdate(75, "Tercihler yükleniyor...");
            Thread.Sleep(_timer);

            _loadingForm.PercentUpdate(99, "Yükleme tamamlanıyor...");
            Thread.Sleep(2000);
            _loadingForm.PercentUpdate(100, "Yükleme tamamlanıyor...");
            
            InitializeComponent();
            if(_loadingForm.progressBar1.Value == 100)
            {
                t.Abort();
            }
        }

        private void OluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _createStoreForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _createStoreForm = new CreateStoreForm();
                _createStoreForm.Show();
            }
        }

        private void OluşturToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                _createProductForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _createProductForm = new CreateProductForm();
                _createProductForm.Show();
            }
        }

        private void OluşturToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                _createLocationForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _createLocationForm = new CreateLocationForm();
                _createLocationForm.Show();
            }
        }

        private void OluşturToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                _createPersonForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _createPersonForm = new CreatePersonForm();
                _createPersonForm.Show();
            }
        }

        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oluşturToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                _createUserForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _createUserForm = new CreateUserForm();
                _createUserForm.Show();
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _aboutMeForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _aboutMeForm = new AboutMeForm();
                _aboutMeForm.Show();
            }
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _listofStoresForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _listofStoresForm = new ListofStoresForm();
                _listofStoresForm.Show();
            }
        }

        private void listeleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                _listofProductsForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _listofProductsForm = new ListofProductsForm();
                _listofProductsForm.Show();
            }
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                _listofLocationForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _listofLocationForm = new ListofLocationForm();
                _listofLocationForm.Show();
            }
        }

        private void listeleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                _listofPersonsForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _listofPersonsForm = new ListofPersonsForm();
                _listofPersonsForm.Show();
            }
        }

        private void ListeleToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                _listofUsersForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _listofUsersForm = new ListofUsersForm();
                _listofUsersForm.Show();
            }
        }

        private void ParolaDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _pswdChangeForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _pswdChangeForm = new PswdChangeForm();
                _pswdChangeForm.Show();
            }
        }

        private void AyarlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                _settingsForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _settingsForm = new SettingsForm();
                _settingsForm.Show();
            }
        }

        private void TercihlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _preferencesForm.Show();
            }
            catch (ObjectDisposedException)
            {
                _preferencesForm = new PreferencesForm();
                _preferencesForm.Show();
            }
        }

        private void TsStoresBtn_Click(object sender, EventArgs e)
        {
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 299);
            this.tabPage1.Text = "Depolar";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.ContextMenuStrip = contextMenuStrip1;
            

            if (!tabControl1.TabPages.Contains(this.tabPage1))
            {
                this.tabControl1.Controls.Add(this.tabPage1);
                this.tabPage1.Controls.Add(new Deneme());
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage1);
            }
            else
            {
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage1);
            }
        }

        private void TsProductBtn_Click(object sender, EventArgs e)
        {
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 299);
            this.tabPage2.Text = "Ürünler";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.ContextMenuStrip = contextMenuStrip1;
            

            if (!tabControl1.TabPages.Contains(this.tabPage2))
            {
                this.tabControl1.Controls.Add(this.tabPage2);
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage2);
            }
            else
            {
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage2);
            }
        }

        private void TsLocationBtn_Click(object sender, EventArgs e)
        {
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 299);
            this.tabPage3.Text = "Lokasyonlar";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.ContextMenuStrip = contextMenuStrip1;

            if (!tabControl1.TabPages.Contains(this.tabPage3))
            {
                this.tabControl1.Controls.Add(this.tabPage3);
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage3);
            }
            else
            {
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage3);
            }
        }

        private void TsPersonBtn_Click(object sender, EventArgs e)
        {
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 299);
            this.tabPage4.Text = "Kişiler";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.ContextMenuStrip = contextMenuStrip1;

            if (!tabControl1.TabPages.Contains(this.tabPage4))
            {
                this.tabControl1.Controls.Add(this.tabPage4);
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage4);
            }
            else
            {
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage4);
            }
        }

        private void TsSettingBtn_Click(object sender, EventArgs e)
        {
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 299);
            this.tabPage5.Text = "Ayarlar";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.ContextMenuStrip = contextMenuStrip1;

            if (!tabControl1.TabPages.Contains(this.tabPage5))
            {
                this.tabControl1.Controls.Add(this.tabPage5);
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage5);
            }
            else
            {
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage5);
            }
        }

        private void TsAboutMeBtn_Click(object sender, EventArgs e)
        {
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(768, 299);
            this.tabPage6.Text = "Hakkımda";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.ContextMenuStrip = contextMenuStrip1;

            if (!tabControl1.TabPages.Contains(this.tabPage6))
            {
                this.tabControl1.Controls.Add(this.tabPage6);
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage6);
            }
            else
            {
                this.tabControl1.SelectedIndex = tabControl1.TabPages.IndexOf(this.tabPage6);
            }
        }

        private void PencereyiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _loginForm.ShowDialog();
        }

        public void Startup()
        {
            Application.Run(_loadingForm);
        }
    }
}
