using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GraspFood Order!");
            Console.WriteLine("Select your Day: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Select your Time: ");
            int time = int.Parse(Console.ReadLine());

            int b = 5, w = 2, c = 3;

            Console.WriteLine("Menu");
            Console.WriteLine("Breakfast Set");
            Console.WriteLine("Weekend Set");
            Console.WriteLine("Coffee");
            
            Console.WriteLine("Select your Order: ");

            
            string order = (Console.ReadLine());
            while (order != "End")
            {
                if (order != "Breakfast Set" && order != "Weekend Set" && order != "Coffee") { 
                Console.WriteLine("Please enter a valid menu");
                order = (Console.ReadLine());
            }


                if (order == "Breakfast Set")
            {
                    if(time < 11)
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            Console.WriteLine("Select other order or type End to exit");
                            order = (Console.ReadLine());

                        }
                        else
                        {
                            Console.WriteLine("Order 1 Breakfast Set");
                            b = b - 1;
                            Console.WriteLine("Select other order or type End to exit");
                            order = (Console.ReadLine());
                        }
                    }else
                    {
                        Console.WriteLine("Sorry your order is not available");
                        Console.WriteLine("Select other order or type End to exit");
                        order = (Console.ReadLine());
                    }
                
            }
            if (order == "Weekend Set")
            {
                    if (day !=6 && day != 7)
                    {
                        if (w == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            Console.WriteLine("Select other order or type End to exit");
                            order = (Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Order 1 Weekend Set");
                            w = w - 1;
                            Console.WriteLine("Select other order or type End to exit");
                            order = (Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry your order is not available");
                        Console.WriteLine("Select other order or type End to exit");
                        order = (Console.ReadLine());
                    }
                }
         
            if (order == "Coffee")
            {
                if (c == 0)
                {
                    Console.WriteLine("Sorry your order is out of stock");
                        Console.WriteLine("Select other order or type End to exit");
                        order = (Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Order 1 Coffee");
                    c = c - 1;
                        Console.WriteLine("Select other order or type End to exit");
                        order = (Console.ReadLine());
                }

            }
                
            }
        }
    }
}
