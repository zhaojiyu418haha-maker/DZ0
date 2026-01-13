
using System;

namespace Lesson_1
{
    class Pro
    {
        static void mima()
        {
            Console.WriteLine("пишите  ваш  пароль");

            int d = 12345;

            for(int c = 0; c <= 999; c++)
            {
                string a = Console.ReadLine();
                int b = int.Parse(a);
                if (b == d) 
                {
                    Console.WriteLine("верно");
                    break;
                }
                else
                {
                    Console.WriteLine("no верно");
                }
            }
            
        }
        static void Main()
        {
            mima();
        }
    }
}