using System;
using System.Linq; 

namespace Omkeren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een string in: ");
            string input = Console.ReadLine();

            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("Kies een methode:");
                Console.WriteLine("1. For");
                Console.WriteLine("2. While");
                Console.WriteLine("3. Do while");
                Console.WriteLine("4. Recursie");
                Console.WriteLine("5. Stoppen");
                Console.Write("Uw keuze: ");
                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        Console.WriteLine("Omgekeerd (for): " + ReverseFor(input));
                        break;
                    case "2":
                        Console.WriteLine("Omgekeerd (while): " + ReverseWhile(input));
                        break;
                    case "3":
                        Console.WriteLine("Omgekeerd (do while): " + ReverseDoWhile(input));
                        break;
                    case "4":
                        Console.WriteLine("Omgekeerd (recursie): " + ReverseRec(input));
                        break;
                    case "5":
                        stop = true;
                        Console.WriteLine("Het programma is beëindigd");
                        break;
                    default:
                        Console.WriteLine("Geen geldige keuze, geef een nieuwe keuze");
                        break;
                }
            }
        }

        // For
        static string ReverseFor(string s)
        {
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            return result;
        }

        // While
        static string ReverseWhile(string s)
        {
            string result = "";
            int i = s.Length - 1;
            while (i >= 0)
            {
                result += s[i];
                i--;
            }
            return result;
        }

        // Do while
        static string ReverseDoWhile(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            string result = "";
            int i = s.Length - 1;
            do
            {
                result += s[i];
                i--;
            } while (i >= 0);
            return result;
        }

        // Recursie
        static string ReverseRec(string s)
        {
            if (s.Length <= 1) return s;
            return s.Last() + ReverseRec(s.Substring(0, s.Length - 1));
        }
    }
}
