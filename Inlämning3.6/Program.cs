using System;
using System.Security.Cryptography.X509Certificates;

namespace Inlämning_3.__5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt för och efternamn");
            string namn = Console.ReadLine();
            int mellanslag = namn.IndexOf(" ");
            string förnamn = namn[..(mellanslag-(mellanslag-1))];
            string efternamn = namn[(mellanslag + 1)..(mellanslag+2)];
            Console.WriteLine(förnamn+" " + efternamn);
            if (förnamn.CompareTo(efternamn) > 0)
            {
                Console.WriteLine("Förnamn kommer före efternamnet i alfabetet");
            }
            else if (förnamn.CompareTo(efternamn) < 0)
            {
                Console.WriteLine("Förnanmnet kommer efter efternamnet i alfabetet");
            }
            else
            {
                Console.WriteLine("Något gick fel");
            }


        }
    }
}
