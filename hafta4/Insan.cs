using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta4
{
    internal class Insan
    {
        public string Isim;
        public uint Boy; // unsigned integer means they cannot store negative numbers this means they can store 0 and natural numbers
        public uint Kilo;
        public string Cinsiyet;
        public uint Yas;


        //yapıcı fonksiyon kullanımı
        public Insan(string isim, uint boy, uint kilo, string cinsiyet, uint yas)
        {
            Isim = isim;
            Boy = boy;  
            Kilo = kilo;    
            Cinsiyet = cinsiyet;
            Yas = yas;
            
        }
    }
}

