using System;

namespace Lesson_1
{
    class Pro
    {
        static void HelloWorld()
        {
            Console.WriteLine("hello world");
        }
        
        static void suanshu()
        {
            Console.WriteLine("пишите два число");

            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int c = int.Parse(a);
            int d = int.Parse(b);
            int e = c + d;
            int f = c - d;
            int g = c * d;
            int h = c / d;
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
        }
        static void nianlingpanduan()
        {
            Console.WriteLine("пишите ваш возрост");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            if (b >= 18)
            {
                Console.WriteLine("вы взрослые");

            }
            if(b<12)
            {
                Console.WriteLine("ребенок");
            }
            else
            {
                Console.WriteLine("подросток");
            }

        }
        static void panduanjiou()
        {
            Console.WriteLine("пишите число");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            int c = b % 2;
            if (b == 0)
            {
                Console.WriteLine("это четное число");
            }
            else
            {
                Console.WriteLine("это не четное число");
            }
        }
        static void sanhewu()
        {
            Console.WriteLine("пишите число");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            int c = b % 3;
            int d = b % 5;
            if (c==0&&d==0)
            {
                Console.WriteLine("это верное число");
            }
            else
            {
                Console.WriteLine("это не верное число");
            }
        }
        static void shulieqiuhe()
        {
            Console.WriteLine("пишите число");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            int d = 0;
            for (int c = 0; c <= b; c++) 
            {
                d = d + c;
            }
            Console.WriteLine(d);



        }
        static void chengshi()
        {
            Console.WriteLine("пишите число");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            for (int c = 0; c <= 10; c++)
            {
                Console.WriteLine(b * c);
            }
        }
        static void jiecheng()
        {
            Console.WriteLine("пишите число");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            int d = 1;
            for (int c = 1; c <= b; c++)
            {
                d = d * c;
            }
            Console.WriteLine(d);
        }
        static void Main()
        {
            HelloWorld();
            Console.WriteLine(",,,,,,,,,,,,,,,,,");
            suanshu();
            Console.WriteLine(",,,,,,,,,,,,,,,,,");
            nianlingpanduan();
            Console.WriteLine(",,,,,,,,,,,,,,,,,");
            panduanjiou();
            Console.WriteLine(",,,,,,,,,,,,,,,,,");
            sanhewu();
            Console.WriteLine(",,,,,,,,,,,,,,,,,");
            shulieqiuhe();
            Console.WriteLine(",,,,,,,,,,,,,,,,,");
            chengshi();
            Console.WriteLine(",,,,,,,,,,,,,,,,,");
            jiecheng();
        }
    }
}