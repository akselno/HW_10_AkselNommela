using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex_2;

namespace VAT_Tests
{
    [TestClass]
    public class VAT_Tests
    {
        public VAT_Calculator vat = new VAT_Calculator();

        [TestMethod]
        public void TestVATFromPrice_20_85()
        {
            double result = vat.FindVATFromPrice(85);
            Assert.AreEqual(result, 17);
        }

        [TestMethod]
        public void TestVATFromPrice_35_120()
        {
            vat.SetVATValue(35);
            double result = vat.FindVATFromPrice(120);
            Assert.AreEqual(result, 42);
        }

        [TestMethod]
        public void TestVATIfPriceIsWithTax_20_70()
        {
            double result = vat.FindPrice(true, 70);
            Assert.AreEqual(result, 58.33, 0.03);
        }

        [TestMethod]
        public void TestVATIfPriceIsWithoutTax_30_145()
        {
            vat.SetVATValue(30);
            double result = vat.FindPrice(false, 145);
            Assert.AreEqual(result, 188.5);
        }

        [TestMethod]
        public void TestPriceFromTaxAmount_10_45()
        {
            vat.SetVATValue(10);
            double result = vat.FindPriceBasedOnTax(45);
            Assert.AreEqual(result, 450);
        }

        [TestMethod]
        public void TestPriceFromTaxAmount_40_300()
        {
            vat.SetVATValue(40);
            double result = vat.FindPriceBasedOnTax(300);
            Assert.AreEqual(result, 750);
        }

        [TestMethod]
        public void TestVAT_20()
        {
            bool result = vat.IsVAT20();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestVAT_21()
        {
            vat.SetVATValue(21);
            bool result = vat.IsVAT20();
            Assert.IsFalse(result);
        }
    }
}
