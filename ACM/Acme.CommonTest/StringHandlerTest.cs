using static Acme.Common.StringHandler;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // -- Arrange

            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // -- Act

            var actual = source.InsertSpaces();

            // -- Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesWithExeistingSpace()
        {
            // -- Arrange

            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            // -- Act

            var actual = source.InsertSpaces();

            // -- Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
