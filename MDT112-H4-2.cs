using System;

namespace ConsoleApp1
{
    class Program
    {
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }

        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Input a half DNA sequence : ");
            string halfDNASequence = Console.ReadLine();

            if (IsValidSequence(halfDNASequence) == true)
            {
                Console.WriteLine("Current half DNA sequence : {0}", halfDNASequence);
                Console.Write("Do you want to replicate it ? (Y/N) : ");
                char ans = char.Parse(Console.ReadLine());
                while (ans != 'Y' && ans != 'N')
                {
                    Console.WriteLine("Please input Y or N.");
                    ans = char.Parse(Console.ReadLine());
                    if (ans == 'Y')
                    {
                        Console.WriteLine("Replicated half DNA sequence :  {0}", ReplicateSeqeunce(halfDNASequence));
                        Console.Write("Do you want to process another sequence ? (Y / N) : ");
                        char ansp = char.Parse(Console.ReadLine());
                        if (ansp == 'Y')
                        {
                            Main(args);
                        }
                        else if (ansp != 'N')
                        {
                            while (ansp != 'Y' && ansp != 'N')
                            {
                                Console.WriteLine("Please input Y or N.");
                                ansp = char.Parse(Console.ReadLine());
                                if (ansp == 'Y')
                                {
                                    Main(args);
                                }
                            }
                        }

                    }
                    else if (ans == 'N')
                    {
                        Console.Write("Do you want to process another sequence ? (Y / N) : ");
                        char ansp = char.Parse(Console.ReadLine());
                        if (ansp == 'Y')
                        {
                            Main(args);
                        }
                        else if (ans != 'N')
                        {
                            while (ansp != 'Y' || ans != 'N')
                            {
                                Console.WriteLine("Please input Y or N.");
                                ansp = char.Parse(Console.ReadLine());
                                if (ansp == 'Y')
                                {
                                    Main(args);
                                }
                            }
                        }
                    }

                }
                /////
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
                Console.Write("Do you want to process another sequence ? (Y / N) : ");
                char ans = char.Parse(Console.ReadLine());
                while (ans != 'Y' && ans != 'N')
                {
                    Console.WriteLine("Please input Y or N.");
                    ans = char.Parse(Console.ReadLine());

                    if (ans == 'Y')
                    {
                        Main(args);
                    }
                }
            }
        }
    }
}

