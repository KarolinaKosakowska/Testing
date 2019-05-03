
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PESEL;

namespace PeselTest
{
    [TestClass]
    public class PeselTest
    {
        [TestMethod]
        public void AreDigits_WithValidValue()
        {
            string pesel = "";
            PeselInfo PeselInfo = new PeselInfo(pesel);
            bool expected = true;
            bool actual = PeselInfo.AreDigits();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AreDigits_withNoNumericValue()
        {
            string pesel = "";
            PeselInfo PeselInfo = new PeselInfo(pesel);
            bool expected = false;
            bool actual = PeselInfo.AreDigits();
            Assert.AreEqual(expected, actual);
        }
    }
}

