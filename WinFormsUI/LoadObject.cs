using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI
{
    public class LoadObject
    {
        LoadingForm _loadingForm;
        public Form1 form1;
        public CreateStoreForm createStoreForm;
        public CreateProductForm createProductForm;
        public CreateLocationForm createLocationForm;
        public CreatePersonForm createPersonForm;
        public CreateUserForm createUserForm;
        public AboutMeForm aboutMeForm;
        public ListofStoresForm listofStoresForm;
        public ListofProductsForm listofProductsForm;
        public ListofLocationForm listofLocationForm;
        public ListofPersonsForm listofPersonsForm;
        public ListofUsersForm listofUsersForm;
        public PswdChangeForm pswdChangeForm;
        public SettingsForm settingsForm;
        public PreferencesForm preferencesForm;

        public LoadObject(LoadingForm loadingForm)
        {
            _loadingForm = loadingForm;
            _loadingForm.LoadingUpdate(1, "Program Başlatılıyor...");
            _loadingForm.LoadingUpdate(5, "Program Hazırlanıyor...");
            createStoreForm = new CreateStoreForm();
            _loadingForm.LoadingUpdate(10, "Depo oluşturma yükleniyor...");
            createProductForm = new CreateProductForm();
            _loadingForm.LoadingUpdate(15, "Ürün oluşturma yükleniyor...");
            createLocationForm = new CreateLocationForm();
            _loadingForm.LoadingUpdate(20, "Lokasyon oluşturma yükleniyor...");
            createPersonForm = new CreatePersonForm();
            _loadingForm.LoadingUpdate(25, "Kişi oluşturma yükleniyor...");
            createUserForm = new CreateUserForm();
            _loadingForm.LoadingUpdate(30, "Kullanıcı oluşturma yükleniyor...");
            aboutMeForm = new AboutMeForm();
            _loadingForm.LoadingUpdate(35, "Hakkımda yükleniyor...");
            listofStoresForm = new ListofStoresForm();
            _loadingForm.LoadingUpdate(40, "Depo listesi yükleniyor...");
            listofProductsForm = new ListofProductsForm();
            _loadingForm.LoadingUpdate(45, "Ürün listesi yükleniyor...");
            listofLocationForm = new ListofLocationForm();
            _loadingForm.LoadingUpdate(50, "Lokasyon listesi yükleniyor...");
            listofPersonsForm = new ListofPersonsForm();
            _loadingForm.LoadingUpdate(55, "Kişi listesi yükleniyor...");
            listofUsersForm = new ListofUsersForm();
            _loadingForm.LoadingUpdate(60, "Kullanıcı listesi yükleniyor...");
            pswdChangeForm = new PswdChangeForm();
            _loadingForm.LoadingUpdate(65, "Şifre değiştirme yükleniyor...");
            settingsForm = new SettingsForm();
            _loadingForm.LoadingUpdate(70, "Ayarlar yükleniyor...");
            preferencesForm = new PreferencesForm();
            _loadingForm.LoadingUpdate(75, "Tercihler yükleniyor...");
            _loadingForm.LoadingUpdate(99, "Yükleme tamamlanıyor...");
            form1 = new Form1(this);
            _loadingForm.LoadingUpdate(100, "Yükleme tamamlanıyor...");
        }
    }
}
