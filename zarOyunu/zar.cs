using System;
using System.Collections.Generic;
using System.Text;

namespace zarOyunu
{
    class zar
    {
      
        int makZarDeg;
        Random random = new Random();
        /// <summary>
        /// deger giriniz
        /// </summary>
        /// <param name="makZarDeg"></param>
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
