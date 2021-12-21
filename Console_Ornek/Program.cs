using System;

namespace Console_Ornek
{
    class Program:Mat
    {
        
        static void Main(string[] args)
        {
            int s1, s2;
            ekranaYaz("Toplanacak Sayi 1: ");
            s1 =Convert.ToInt32(Console.ReadLine());

            ekranaYaz("Toplanacak Sayi 2: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            ekranaYaz("Sonuc : " + topla(s1, s2));






            //Kisiler ks = new Kisiler();

            //string ads;
            //ekranaYaz("İsim girin: ");
            //ads = Console.ReadLine();
            //ks.kisilistesi(ads);
            //Console.Read();
        }
    }
}
