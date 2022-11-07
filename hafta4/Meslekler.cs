using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta4
{
    internal class Ogrenci : Insan 
    {
     //ilk başta sınıfın kendine has olan özelliklerini classın içinde tanımlıyorsun.
        public uint OkulNumarası;
        public uint Sınıf;
  //oluşturacağımız yapıcı metota da ilk başta bu parametreleri tanımlıyorsun ardından miras aldığımız sınıfın içindeki 
  //parametreleri tanımlıyorsun ardından iki nokta ile kalıtım aldığın sınıfı base diyorsun bu base aldığımız classın özelliklerini veri tipini belirt meden sırasıyla yazıyorsun.
        public Ogrenci(uint okulNumarası, uint sınıf, string isim, uint boy, uint kilo, string cinsiyet, uint yas) : base(isim,boy,kilo,cinsiyet,yas)
        {
            OkulNumarası = okulNumarası;
            Sınıf = sınıf;
        }

    }

    internal class Ogretmen : Insan
    {
        public uint ID;
        public string Brans;

        public Ogretmen(uint id, string brans, string isim, uint kilo, uint boy, string cinsiyet, uint yas): base(isim,boy,kilo,cinsiyet, yas) 
        {
            ID = id;
            Brans = brans;
        }
    }

    internal class Muhendis: Insan
    {
        public uint Id;
        public string Brans;

        public Muhendis(uint id, string brans, string isim, uint kilo, uint boy, string cinsiyet, uint yas): base (isim,boy, kilo, cinsiyet, yas)
        {
            Id = id;
            Brans=brans;
        }

    }
}
