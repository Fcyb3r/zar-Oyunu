using System;

namespace zarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {

           

            zar zar1 = new zar(6);
            Console.WriteLine(zar1.zarAt());
            Console.WriteLine(zar1.zarAt());
            Console.WriteLine(zar1.zarAt());
            Console.WriteLine(zar1.zarAt());



            zar1 zar2 = new zar1(17);

            Console.WriteLine("zar  2 değeri");
           
            Console.WriteLine( zar2.zarAt());

        }
    }
}
