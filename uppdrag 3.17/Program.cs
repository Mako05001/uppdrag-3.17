using System;
namespace Uppdrag3._17
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Skriv första talet");
            string f = Console.ReadLine();
            int F = Convert.ToInt32(f);
            Console.WriteLine("Skriv andra talet");
            string a = Console.ReadLine();
            int A = Convert.ToInt32(a);
            Console.WriteLine("Välj ett alternativ 1.Addition 2.Subtraktion 3.Multiplikation 4.Division");
            string t = Console.ReadLine();
            int T = Convert.ToInt32(t);
            switch (T)
                {
                case  1:
                    Console.WriteLine(A + F);
                    break;
                case  2:
                    Console.WriteLine(A - F);
                    break;
                case  3:
                    Console.WriteLine(A * F);
                    break;
                case  4:
                    Console.WriteLine(A / F);
                    break;
            }
        }
    }
}