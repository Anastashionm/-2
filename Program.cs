using System;

namespace rab17_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры открытки");
            string a1 = Console.ReadLine();
            int b1 = Convert.ToInt32(a1);
            int i1 = Convert.ToInt32(Math.Pow(b1, 2));

            Console.WriteLine("Введите размеры открытки");
            string a2 = Console.ReadLine();
            int b2 = Convert.ToInt32(a2);
            int i2 = Convert.ToInt32(Math.Pow(b2, 2));

            Console.WriteLine("Введите размеры конверта");
            string c1 = Console.ReadLine();
            int d1 = Convert.ToInt32(c1);
            int g1 = Convert.ToInt32(Math.Pow(d1, 2));

            Console.WriteLine("Введите размеры конверта:");
            string c2 = Console.ReadLine();
            int d2 = Convert.ToInt32(c2);
            int g2 = Convert.ToInt32(Math.Pow(d2, 2));

            int postcard = b1 + b2; //открытка
            int envelope = d1 + d2; //конверт

            if (postcard <= 0)
            {
                Console.WriteLine("Открытка не может быть меньше 0!");
                return;
            }

            if (envelope <= 0)
            {
                Console.WriteLine("Конверт не может быть меньше 0!");
                return;
            }

            if (postcard <= envelope)
            {
                Console.WriteLine("Открытка поместится.");
            }
            else
            {
                Console.WriteLine("Открытка не поместится.");
            }
        }
    }
}
