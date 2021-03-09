using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulForm
{
     public class Kimlik
    {
        public long TCKimlikNo { get; private set; }
        public  string Ad { get; private set; }

        public string Soyad { get; private set; }
        public void KimlikBilgileriDoldur(int TCNo)
        {
            this.TCKimlikNo = TCNo;
            //Simulasyon
            //Git Servise bağlan k adi şifre ile doğrulama yap ve ad soyad bilgilerini doldur .E devlet gibi
        }
    }
}
