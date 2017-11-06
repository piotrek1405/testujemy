using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isPalindrome(string inputText)
            {
                inputText= inputText.ToLower();
            
                int koniec = inputText.Length - 1;
                int poczatek = 0;
                for (;poczatek < koniec;poczatek++, koniec --)
                {                
                    if (inputText[poczatek] == ' ') poczatek++;
                    if (inputText[koniec] == ' ') koniec--;
                    if (inputText[poczatek] != inputText[koniec]) break;
                }
                if (poczatek < koniec)
                {
                    Console.WriteLine("Wyrażenie nie jest palindromem");
                    return false;
                }
                else
                {
                    Console.WriteLine("Wyrażenie jest palindromem!");
                    return true;
                }
            }

            Console.WriteLine("Podaj wyrażenie,aby sprawdzić czy jest palindromem: ");
            string tekst = Console.ReadLine();
            Console.WriteLine("");
            isPalindrome(tekst);
        }
    }
}
