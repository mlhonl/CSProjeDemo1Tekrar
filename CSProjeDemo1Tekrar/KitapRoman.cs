using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1Tekrar
{
    public class KitapRoman : Kitap
    {
        public KitapRoman(string isbn, string baslik, string yazar, int yayinYili) : base(isbn, baslik, yazar, yayinYili)
        {
        }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Roman: {Baslik} - Yazar: {Yazar} - Yayın Yılı : {YayinYili} - Durum: {Durum}");
        }
    }
}
