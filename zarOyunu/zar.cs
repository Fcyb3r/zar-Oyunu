using System;
using System.Collections.Generic;
using System.Text;

namespace zarOyunu
{
    class zar
    {
        ///zarın alabileceği mak deger
        int makZarDeg;
        Random random = new Random();
public zar(int makZarDeg)
        {
            this.makZarDeg = makZarDeg;
        }         
        ///rasgele bir sayi için zar at
        public int zarAt()
        {
            ///rasgele sayı üretecek
            return random.Next(1,makZarDeg +1);
        }





    }
}
