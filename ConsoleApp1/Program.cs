using CSProjeDemo1Tekrar;

namespace KutuphaneTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();

            Kitap tarih = new KitapTarih("1", "Nutuk", "Mustafa Kemal Atatürk", 1927);
            Kitap bilim = new KitapBilim("2", "Zamanın Kısa Tarihi", "Stephen Hawking", 1988);
            Kitap roman = new KitapRoman("3", "Suç ve Ceza", "Fyodor Dostoyevski", 1866);

            kutuphane.KitapEkle(roman);
            kutuphane.KitapEkle(bilim);
            kutuphane.KitapEkle(tarih);

            Uye uye = new Uye("Melih Ömer","Önol",1);
            kutuphane.UyeEkle(uye);

            kutuphane.KitapOduncVer(roman, uye);
            kutuphane.KitapDurumunuGoster(roman);

            kutuphane.KitapIadeAl(roman, uye);
            kutuphane.KitapDurumunuGoster(roman);
            
        }
    }
}
