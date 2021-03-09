using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulForm
{
    public class Kisi
    {
        public int SigortaNo { get; set; }
        public Kimlik KimlikBilgi { get; set; }

        public Kisi()
        {
            this.KimlikBilgi = new Kimlik();
        }
    }
}
