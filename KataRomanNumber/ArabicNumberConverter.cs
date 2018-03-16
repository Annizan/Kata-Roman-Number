using System.Collections.Generic;
using System.Text;

namespace KataRomanNumber
{
    public class ArabicNumberConverter
    {
        private static Dictionary<int, string> romanEquivalencyOfArabicNumber = new Dictionary<int, string>
        {
            {1000, "M" },
            {900, "CM" },
            {500, "D" },
            {400, "CD" },
            {100, "C" },
            {90, "XC" },
            {50, "L" },
            {40, "XL" },
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I" },
        };


        public static string ToRomanNumber(int arabicNumber)
        {


            StringBuilder result = new StringBuilder();

            while (arabicNumber != 0)
            {
                foreach (KeyValuePair<int, string> equivalency in romanEquivalencyOfArabicNumber)
                {
                    if (arabicNumber >= equivalency.Key)
                    {
                        result.Append(equivalency.Value);
                        arabicNumber -= equivalency.Key;
                        break;
                    }
                }
            }

            return result.ToString();
        }
    }
}
