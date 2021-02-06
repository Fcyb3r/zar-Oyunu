using System;
using System.Collections.Generic;
using System.Text;

namespace zarOyunu
{
    class zar1
    {

        int zarDeg2;
        Random random = new Random();
        /// <summary>
        /// zar2 degerini giriniz!!
        /// </summary>
        /// <param name="zarDeg2">zar degerini belirtir</param>
        public zar1(int zarDeg2)
        {
            this.zarDeg2 = zarDeg2;

        }

        public int zarAt()
        {
            ///rasgele sayı üretecek
            return random.Next(1, zarDeg2 + 1);
        }
    }
}
