using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string mode = Console.ReadLine();
            float filmBackWidth = float.Parse(Console.ReadLine());
            while (filmBackWidth < 0)
            {
                Console.WriteLine("Invalid filmBackWidth. Please input again");
                filmBackWidth = float.Parse(Console.ReadLine());

            }
            double fLength, fov; //ใช้ doudle แทนเพราะ Math.Atan ต้องใช้double
            switch (mode)
            {
                case "fLength":
                fLength = float.Parse(Console.ReadLine());
                    if (fLength > 0)
                    {
                        fov = 2 * Math.Atan(filmBackWidth / 2 * fLength);
                        Console.WriteLine("fLength= {0} , fov = {1}", fLength, fov);
                    }
                    else
                    {
                        Console.WriteLine("Invalid fLength. Please input again");
                        fLength = float.Parse(Console.ReadLine());
                    }

                break;

                case "fov":
                    fov = float.Parse(Console.ReadLine());

                    if (fov > 0.1 && fov < 6.28)
                    {
                        fLength = filmBackWidth / (2 * Math.Tan(fov / 2));
                        Console.WriteLine("fLength= {0} , fov = {1}", fLength, fov);
                    }
                    else
                    {
                        Console.WriteLine("Invalid fov. Please input again");
                        fov = float.Parse(Console.ReadLine());
                    }
                    break;
            }
           

            









        }
}

}

