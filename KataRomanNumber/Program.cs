using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRomanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertAnArabicNumber();
            Console.WriteLine("Pour convertir un nouveau nombre, appuyez sur 'Y'");
            var response = Console.ReadLine().ToLower();
            while(response == "y")
            {
                ConvertAnArabicNumber();
                Console.WriteLine("Pour convertir un nouveau nombre, appuyez sur 'Y'");
                response = Console.ReadLine().ToLower();
            }

        }

        private static void ConvertAnArabicNumber()
        {
            Console.WriteLine("Veuillez saisir un nombre arabe à convertir en nombre romain :");
            var isarabicNumber = int.TryParse(Console.ReadLine(), out int arabicNumber);
            while (!isarabicNumber)
            {
                Console.WriteLine("Veuillez saisir un nombre arabe à convertir :");
                isarabicNumber = int.TryParse(Console.ReadLine(), out arabicNumber);
            }

            Console.WriteLine(arabicNumber.ToString() + "   =   " + ArabicNumberConverter.ToRomanNumber(arabicNumber));
        }
    }
}
