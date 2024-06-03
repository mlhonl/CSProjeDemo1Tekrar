using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1Tekrar
{ //Kitap: Kitapların temel özelliklerini (ISBN, başlık, yazar, yayın yılı vb.) içerir ve diğer kitap türleri için temel (base class) görevi görür.
  //Kitap sınıfı içerisinde kullanmak üzere kitapların ödünç durumunu belirtmek için (OduncAlabilir, OduncVerildi, MevcutDegil, v.b.) bir enum tanımlayın.
  //KitapBilim, KitapRoman, KitapTarih:Kütüphanede bulunan kitap türlerimize göre BaseKitap’dan kalıtım alırak kütüphanedeki kitap türü kadar alt sınıf (sub class) oluşturulur. (KitapBilim, KitapRoman, v.b.) Bu sınıf mevcut durumunu (ödünç alınabilir, ödünçte, mevcut değil) tutan bir sınıf olmalıdır.
    public abstract class Kitap
    {
        public string ISBN { get; set; }

        private string baslik;
        public string Baslik
        {
            get { return baslik; }
            set { baslik = value.ToUpper(); } 
        }
        private string yazar;
        public string Yazar 
        {
            get {return yazar; }
            set { yazar = value.ToUpper(); } 
        }
        public int YayinYili { get; set; }
        public Durum Durum { get; set; }

        public Kitap(string isbn,string baslik,string yazar,int yayinYili)
        {
            ISBN = isbn;
			Baslik = baslik;
			Yazar = yazar;
            YayinYili = yayinYili;
            Durum = Durum.OduncAlabilir;

            //ISBN parametresinin null veya boş olup olmadıgını kontrol eder
            if (string.IsNullOrEmpty(isbn))
            {
                throw new ArgumentNullException(nameof(isbn), "ISBN boş olamaz.");
            }
            //Başlık parametresinin null veya boş olup olmadıgını kontrol eder
            if (string.IsNullOrEmpty(baslik))
            {
                throw new ArgumentNullException(nameof(baslik), "Başlık boş olamaz.");
            }
            if (string.IsNullOrEmpty(yazar))
            {
                throw new ArgumentNullException(nameof(yazar), "Yazar bölümü boş olamaz.");
            }
            if (yayinYili <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(yayinYili), "Yayın yılı 0'a eşit ya da 0'dan küçük olamaz. ");
            }



        }
        public abstract void BilgiGoster();
		
		

    }
}
