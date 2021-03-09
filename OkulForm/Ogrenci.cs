using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulForm
{
    public class Ogrenci:Kisi
    {
        public int OgrenciNo { get; set; }

        public Hoca DanismanHoca { get; set; }

        public Ogrenci()
        {
            this.DanismanHoca = new Hoca();
        }
        public Ogrenci(Hoca h)
        {
            this.DanismanHoca = h;
        }

    }
}
