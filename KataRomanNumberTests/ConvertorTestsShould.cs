using KataRomanNumber;
using NFluent;
using NUnit.Framework;

namespace KataRomanNumberTests
{
    public class ConvertorTestsShould
    {
        [TestCase(1, "I")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(5, "V")]
        [TestCase(7, "VII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(16, "XVI")]
        [TestCase(19, "XIX")]
        [TestCase(21, "XXI")]
        [TestCase(24, "XXIV")]
        [TestCase(25, "XXV")]
        [TestCase(50, "L")]
        [TestCase(51, "LI")]
        [TestCase(100, "C")]
        [TestCase(135, "CXXXV")]
        [TestCase(1650, "MDCL")]
        [TestCase(3999, "MMMCMXCIX")]
        [TestCase(4644, "MMMMDCXLIV")]
        public void TranslateArabicNumberIntoRomanNumber(int arabicNumber, string expected)
        {
            Check.That(ArabicNumberConverter.ToRomanNumber(arabicNumber)).IsEqualTo(expected);
        }
    }
}
