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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStoreForm createStoreForm = new CreateStoreForm();
            createStoreForm.Show();

        }

        private void OluşturToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm();
            createProductForm.Show();
        }

        private void OluşturToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateLocationForm createLocationForm = new CreateLocationForm();
            createLocationForm.Show();
        }

        private void OluşturToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CreatePersonForm createPersonForm = new CreatePersonForm();
            createPersonForm.Show();
        }

        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oluşturToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMeForm aboutMeForm = new AboutMeForm();
            aboutMeForm.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListofStoresForm listofStoresForm = new ListofStoresForm();
            listofStoresForm.Show();
        }

        private void listeleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ListofProductsForm listofProductsForm = new ListofProductsForm();
            listofProductsForm.Show();
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListofLocationForm listofLocationForm = new ListofLocationForm();
            listofLocationForm.Show();
        }

        private void listeleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListofPersonsForm listofPersonsForm = new ListofPersonsForm();
            listofPersonsForm.Show();
        }

        private void ListeleToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ListofUsersForm listofUsersForm = new ListofUsersForm();
            listofUsersForm.Show();
        }

        private void ParolaDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PswdChangeForm pswdChangeForm = new PswdChangeForm();
            pswdChangeForm.Show();
        }

        private void AyarlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void TercihlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesForm preferencesForm = new PreferencesForm();
            preferencesForm.Show();
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
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
