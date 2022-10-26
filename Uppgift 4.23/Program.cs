using System;
namespace Uppgift_4_23
{
    class program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Skriv in ett heltal");

            int x = int.Parse(Console.ReadLine());

            int störst=x;

            string svar = "";
            while (svar != "n")
            {
                Console.WriteLine("vill du skriv in ett heltal till? (j/n)");
                svar = Console.ReadLine();

                if (svar == "n")
                {
                    break;
                }
                Console.WriteLine("skriv in ett heltal till");

                int nytttal = int.Parse(Console.ReadLine());

                if (nytttal > störst)
                {
                    störst = nytttal;

                }

            }
            Console.WriteLine("Det största talet som skrevs var " + störst);
        }
    }
}
