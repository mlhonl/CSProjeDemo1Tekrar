using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1Tekrar
{
    public interface IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }

        List<Kitap>OduncAlinanKitaplar {  get; set; }
        public void KitapOduncAl(Kitap kitap);
        public void KitapIadeEt(Kitap kitap);



    }
}
