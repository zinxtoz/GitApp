using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string alp = Console.ReadLine();
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            for( int y = w; y <n; y++)
            {
                for (int x=0; x<w;x++)
                    if (x >= y)
                    {
                        Console.WriteLine(alp);
                    }else   {
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
