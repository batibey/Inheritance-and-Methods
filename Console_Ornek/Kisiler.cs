using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Ornek
{
    class Kisiler:Program
    {
        public void kisilistesi(string adsoyad)
        {
            
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(adsoyad);
            }
        }
    }
}
