using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProductTest.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Product
            {
                Name = "Baggins",
                Description = "fbaggins@hobbiton.me",
                CurrentPrice = 11
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingCurrentPrice()
        {
            var customer = new Product
            {
                Name = "Baggins",
                Description = "fbaggins@hobbiton.me",
            };

            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
