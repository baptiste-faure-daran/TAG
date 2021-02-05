using Localisation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocalisationsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUrl()
        {
            // GIVEN
            Model model = new Model();

            // WHEN
            string urlToTest = model.buildUrl(0.1, 0.1);

            // THEN 
            string urlExpected = "https://data.mobilites-m.fr/api/linesNear/json?x=0.1&y=0.1&dist=400&details=true";
            Assert.AreEqual(urlExpected, urlToTest);
            

        }
    }
}
