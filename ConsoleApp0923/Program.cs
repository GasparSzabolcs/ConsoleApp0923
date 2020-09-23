using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0923
{
    class Program
    {
        static void Main(string[] args)
        {
            //fagy
            Console.WriteLine("adja meg a kulso homersekletet pls");
            double fagy = Convert.ToDouble(Console.ReadLine());
            if (fagy <= 0)
            {
                Console.WriteLine("fagy van odakint");
            }
            //paritas
            Console.WriteLine("adj meg egy egesz szamot pls");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("paros a szam");
            }

            //oszthato3
            Console.WriteLine("adj meg egy szamot");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            if (szam2 % 3 ==0)
            {
                Console.WriteLine("oszthato 3al");
            }
            //kozotte
            Console.WriteLine("adjon meg egy szamot");
            int kozotte = Convert.ToInt32(Console.ReadLine());
            if (kozotte >= -30 && kozotte <= 40)
            {
                Console.WriteLine("-30 és 40 kozot van");
            }


            Console.ReadKey();
        }
    }
}
