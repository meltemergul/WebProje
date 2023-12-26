# webproje

Çanta E-Ticaret Sitesi
Bu proje, çanta satışı üzerine odaklanan bir e-ticaret sitesini oluşturmayı amaçlar. Müşterilerin çanta seçeneklerini görmelerine, ürünleri sepetlerine eklemelerine ve sipariş vermelerine olanak tanır. Ayrıca, yöneticilerin ürünleri yönetmeleri ve siparişleri izlemeleri için bir yönetici paneli içerir.

Başlangıç
Bu talimatlar, projenizi yerel bir makinede çalıştırmak ve geliştirmek için gerekli adımları içerir. Projenin sorunsuz bir şekilde çalışabilmesi için önce aşağıdaki gereksinimleri sağlamalısınız.

Gereksinimler
Node.js
MongoDB
npm veya yarn
Kurulum
Depoyu yerel makinenize kopyalayın:

bash
Copy code
git clone https://github.com/kullaniciadi/canta-eticaret-site.git
Proje dizinine gidin:

bash
Copy code
cd canta-eticaret-site
Bağımlılıkları yükleyin:

bash
Copy code
npm install
Ortam değişkenlerini ayarlayın:

bash
Copy code
cp .env.example .env
.env dosyasını açın ve MongoDB bağlantı bilgilerinizi ekleyin.

Uygulamayı başlatın:

bash
Copy code
npm start
veya

bash
Copy code
yarn start
Tarayıcıda http://localhost:3000 adresine gidin. Uygulama burada çalışıyor olmalıdır.

Kullanım
Ana sayfada mevcut çanta koleksiyonunu görüntüleyin.
İstediğiniz çantayı sepetinize ekleyin.
Sepetinizi görüntüleyin ve siparişinizi tamamlayın.
Yönetici paneline giriş yapmak için /admin sayfasına gidin.
Yönetici panelinden ürünleri yönetin ve siparişleri izleyin.
Katkıda Bulunma
Bu depoyu fork edin.
Yeni bir özellik ekleyin veya hata düzeltmeleri yapın.
Pull request oluşturun.
Lisans
Bu proje MIT lisansı altında lisanslanmıştır. Detaylı bilgi için LICENSE.md dosyasını inceleyin.
