using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1Tekrar
{
    public class Kutuphane
    {
        public List<Kitap> Kitaplar { get; set; }
        public List<Uye> Uyeler { get; set; }

        public Kutuphane()
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<Uye>();
        }
        public void UyeEkle(Uye uye)
        {
            Uyeler.Add(uye);
            Console.WriteLine($"{uye.Ad} isimli üye kütüphaneye eklendi");
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
            Console.WriteLine($"{kitap.Baslik} isimli kitap kütüphaneye eklendi");
        }
        public void KitapOduncVer(Kitap kitap, Uye uye)
        {
            uye.KitapOduncAl(kitap);
        }
        public void KitapIadeAl(Kitap kitap, Uye uye)
        {
            uye.KitapIadeEt(kitap);
        }
        public void KitapDurumunuGoster(Kitap kitap)
        {
            kitap.BilgiGoster();
        }
    }
}
