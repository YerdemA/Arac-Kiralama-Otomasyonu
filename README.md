# Araç Kiralama Otomasyonu

C# ve .NET 8.0 kullanılarak geliştirilmiş, DevExpress bileşenleri ile modern bir arayüze sahip kapsamlı bir Araç Kiralama Otomasyonu projesi. Bu uygulama, galeri ve araç kiralama şirketlerinin günlük operasyonlarını (araç takibi, müşteri yönetimi, kiralama işlemleri ve muhasebe) kolayca yönetmelerini sağlar.

## 🚀 Özellikler

Proje aşağıdaki temel modülleri içermektedir:

*   **Araç Yönetimi:**
    *   Yeni araç kiralama envanterine ekleme (`AracEkleFormu`)
    *   Araç bilgilerini güncelleme (`AracGuncelle`)
    *   Araç silme ve pasife alma (`AracSilFormu`)
    *   Tüm araçları listeleme ve filtreleme (`AracListele`)
*   **Müşteri Yönetimi:**
    *   Müşteri kayıt ve takibi (`MusteriEkle`)
    *   Müşteri bilgilerini düzenleme (`MusteriGuncelle`)
    *   Müşteri silme (`MusteriSil`)
    *   Müşteri listesi (`MusteriListele`)
*   **Kiralama İşlemleri:**
    *   Yeni kiralama sözleşmesi oluşturma (`KiralamaFormu`)
    *   Geçmiş kiralama kayıtlarını görüntüleme (`KiralamaGecmisi`)
*   **Muhasebe & Finans:**
    *   Gelir ve Gider takibi (`GelirFormu`, `GiderFormu`)
    *   Genel muhasebe raporları (`MuhasebeFormu`)
*   **Kullanıcı İşlemleri:**
    *   Güvenli Giriş (`Form1`)
    *   Kayıt Olma (`KayitFormu`)
    *   Şifre Sıfırlama (`SifremiUnuttumFormu`)

## 🛠 Kullanılan Teknolojiler

*   **Dil:** C#
*   **Platform:** .NET 8.0 (Windows Forms)
*   **Veritabanı:** Microsoft SQL Server
*   **UI Framework:** DevExpress WinForms Controls (v24.2.3)
*   **Veri Erişimi:** Microsoft.Data.SqlClient / System.Data.SqlClient

## ⚙️ Kurulum

1.  Projeyi bilgisayarınıza klonlayın:
    ```bash
    git clone https://github.com/kullaniciadi/repo-adi.git
    ```
2.  Visual Studio 2022'de `WinFormsApp2.sln` dosyasını açın.
3.  SQL Server bağlantı ayarlarınızı yapılandırın (Proje içerisindeki bağlantı dizelerini yerel veritabanınıza göre güncelleyin).
4.  Projeyi derleyin ve çalıştırın.

## 📝 Notlar
Bu proje DevExpress bileşenlerini kullanmaktadır. Projeyi derleyebilmek için uygun DevExpress lisansına veya deneme sürümüne sahip olmanız gerekebilir.
