using System;
namespace Uppgift_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            string taltext = Console.ReadLine();
            int tal1 = int.Parse(taltext);
            while (true)
            {
                {
                    Console.WriteLine("Vill du skriva in ett tal till?, y, n");
                    string svar = Console.ReadLine();
                    if (svar == "n")
                    {
                        break;
                    }
                    Console.WriteLine("skriv in ett heltal till");
                    string nytttaltext = Console.ReadLine();
                    int nytttal = int.Parse(nytttaltext);
                    if (nytttal > tal1)
                    {
                        tal1 = nytttal;
                    }
                }
            }
            Console.WriteLine("Det högsta talet du skrev var " + tal1);
        }
    }
}