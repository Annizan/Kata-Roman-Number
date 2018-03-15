using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NUnit.Framework;

namespace KataRomanNumberTests
{
    public class ConvertorTestsShould
    {
        [Test]
        public void TranslateArabicNumberIntoRomanNumber()
        {
            Check.That(Convertor.ToRomanNumber(1)).IsEqualTo("I");
        }
    }

    public static class Convertor
    {
        public static object ToRomanNumber(int v)
        {
            throw new NotImplementedException();
        }
    }
}
