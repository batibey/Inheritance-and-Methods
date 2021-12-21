using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Ornek
{
    class Mat
    {
        public static int topla(int s1,int s2)
        {
            return s1 + s2;
        }
        public int cikar(int s1, int s2)
        {
            return s1 - s2;
        }
        public int carp(int s1, int s2)
        {
            return s1 * s2;
        }
        public int bol(int s1, int s2)
        {
            return s1 / s2;
        }

        public static void ekranaYaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }
        public static void ekranaYaz(int mesaj)
        {
            Console.WriteLine(mesaj);
        }
    }
}
