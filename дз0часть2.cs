using System;

namespace Lesson_1
{
    class Pro
    {
        static void sanheer()
        {
            Console.WriteLine("пишите число");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            for (int c = 1; c <= b; c++)
            {
                int d = c % 2;
                int e = c % 3;
                if (d == 0 || e == 0)
                {
                    Console.WriteLine(c);
                }
            }
        }
        static void caishu()
        {
            Console.WriteLine("угадайте  число");
            int d = 7;

            for (int c = 0; c <= 999; c++)
            {
                string a = Console.ReadLine();
                int b = int.Parse(a);
                if (b > d)
                {
                    Console.WriteLine("больше");

                }
                if (b < d)
                {
                    Console.WriteLine("меньше");

                }
                if (b == d)
                {
                    Console.WriteLine("верно");
                }
            }




        }
        static void Main()
        {
            sanheer();
            caishu();
        }
    }
}
