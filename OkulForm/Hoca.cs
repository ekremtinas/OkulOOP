using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulForm
{
    public class Hoca:Kisi
    {
        private   List<Ogrenci> Ogrenciler { get; set; }
        public void OgrenciEkle(Ogrenci o)
        {
            Ogrenciler.Add(o);
        }
        public void OgrenciCikar(Ogrenci o)
        {
            Ogrenciler.Remove(o);
        }
        public string OgrenciListele()
        {
            string temp="";

            foreach (Ogrenci o in Ogrenciler)
            {
                temp += o.OgrenciNo.ToString();
            }
            return temp;
        }
        public int OgrenciSayisi()
        {
            return Ogrenciler.Count();
        }
    }
}
