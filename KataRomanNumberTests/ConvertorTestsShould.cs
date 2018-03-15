using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NUnit.Framework;

namespace KataRomanNumberTests
{
    public class ConvertorTestsShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        public void TranslateArabicNumberIntoRomanNumber(int arabicNumber, string expected)
        {
            Check.That(ArabicNumberConverter.ToRomanNumber(arabicNumber)).IsEqualTo(expected);
        }
    }

    public static class ArabicNumberConverter
    {
        public static string ToRomanNumber(int arabicNumber)
        {
            StringBuilder result = new StringBuilder();
            for(int i = 1; i<=arabicNumber; i++)
                result.Append("I");
            return result.ToString();
        }
    }
}
