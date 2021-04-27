using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
                n = int.Parse(Console.ReadLine());
            }



            int[,] arr = new int[n, n];

            
            for (int line = 0; line < n; line++)
            {
                
                for (int i = 0; i <= line; i++)
                {
                    
                    if (line == i || i == 0)
                        arr[line, i] = 1;
                    else 
                        arr[line, i] = arr[line - 1, i - 1] + arr[line - 1, i];
                    Console.Write("{0:D} ", arr[line, i]);
                }
                Console.WriteLine();
            }
        }


    }
}
