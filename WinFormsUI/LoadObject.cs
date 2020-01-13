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
        public CreateStoreForm _createStoreForm;
        public CreateProductForm _createProductForm;
        public CreateLocationForm _createLocationForm;
        public CreatePersonForm _createPersonForm;
        public CreateUserForm _createUserForm;
        public AboutMeForm _aboutMeForm;
        public ListofStoresForm _listofStoresForm;
        public ListofProductsForm _listofProductsForm;
        public ListofLocationForm _listofLocationForm;
        public ListofPersonsForm _listofPersonsForm;
        public ListofUsersForm _listofUsersForm;
        public PswdChangeForm _pswdChangeForm;
        public SettingsForm _settingsForm;
        public PreferencesForm _preferencesForm;

        public LoadObject(LoadingForm loadingForm)
        {
            _loadingForm = loadingForm;
            _loadingForm.LoadingUpdate(1, "Program Başlatılıyor...");
            _loadingForm.LoadingUpdate(5, "Program Hazırlanıyor...");
            _createStoreForm = new CreateStoreForm();
            _loadingForm.LoadingUpdate(10, "Depo oluşturma yükleniyor...");
            _createProductForm = new CreateProductForm();
            _loadingForm.LoadingUpdate(15, "Ürün oluşturma yükleniyor...");
            _createLocationForm = new CreateLocationForm();
            _loadingForm.LoadingUpdate(20, "Lokasyon oluşturma yükleniyor...");
            _createPersonForm = new CreatePersonForm();
            _loadingForm.LoadingUpdate(25, "Kişi oluşturma yükleniyor...");
            _createUserForm = new CreateUserForm();
            _loadingForm.LoadingUpdate(30, "Kullanıcı oluşturma yükleniyor...");
            _aboutMeForm = new AboutMeForm();
            _loadingForm.LoadingUpdate(35, "Hakkımda yükleniyor...");
            _listofStoresForm = new ListofStoresForm();
            _loadingForm.LoadingUpdate(40, "Depo listesi yükleniyor...");
            _listofProductsForm = new ListofProductsForm();
            _loadingForm.LoadingUpdate(45, "Ürün listesi yükleniyor...");
            _listofLocationForm = new ListofLocationForm();
            _loadingForm.LoadingUpdate(50, "Lokasyon listesi yükleniyor...");
            _listofPersonsForm = new ListofPersonsForm();
            _loadingForm.LoadingUpdate(55, "Kişi listesi yükleniyor...");
            _listofUsersForm = new ListofUsersForm();
            _loadingForm.LoadingUpdate(60, "Kullanıcı listesi yükleniyor...");
            _pswdChangeForm = new PswdChangeForm();
            _loadingForm.LoadingUpdate(65, "Şifre değiştirme yükleniyor...");
            _settingsForm = new SettingsForm();
            _loadingForm.LoadingUpdate(70, "Ayarlar yükleniyor...");
            _preferencesForm = new PreferencesForm();
            _loadingForm.LoadingUpdate(75, "Tercihler yükleniyor...");
            _loadingForm.LoadingUpdate(99, "Yükleme tamamlanıyor...");
            _loadingForm.LoadingUpdate(100, "Yükleme tamamlanıyor...");
        }
    }
}
