using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1Tekrar
{
    public class Uye : IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }
        
        //Üye nin ödünç aldığı kitapları tutan liste 
        public List<Kitap> OduncAlinanKitaplar { get; set; }

        //Uye sınıfının parametreli yapıcı metodu. Üye numarası adı ve soyadıyla başlatılır
        public Uye(string ad,string soyad, int uyeNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNumarasi = uyeNumarasi;
            //Ödünç alınan kitapları tutan liste başlatılır
            OduncAlinanKitaplar = new List<Kitap>();
        }
        
        //Üyenin ödünç aldığı kitapları listeye eklemek için metot
        public void KitapOduncAl(Kitap kitap)
        {
            //Eğer kitap daha önce alınmışsa hata fırlatır
            if (kitap.Durum != Durum.OduncAlabilir)
            {
                throw new Exception("Kitap daha önce ödünç alınmış ya da alınamaz durumda");
            }

            //Kitabın durumunu ödünç verildi olarak günceller ve listeye ekler
            kitap.Durum = Durum.OduncVerildi;
            OduncAlinanKitaplar.Add(kitap);
        }

        //Üyenin ödünç aldığı kitabı iade etmek için metot
        public void KitapIadeEt(Kitap kitap)
        {
            //Kitap ödünç alınmamışsa hata fırlatır
            if (!OduncAlinanKitaplar.Contains(kitap))
            {
                throw new Exception("Bu kitap ödünç alınmamış");
            }

            //Kitap durumunu ödünç alabilir olarak günceller ve listeden çıkarır
            kitap.Durum = Durum.OduncAlabilir;
            OduncAlinanKitaplar.Remove(kitap);
        }

        //Üyenin ödünç aldığı kitapları görüntülemek için metot
        public List<Kitap> OduncAlinanKitaplariGoruntule()
        {
            return OduncAlinanKitaplar;
        }
    }
}
