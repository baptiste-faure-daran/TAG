using Localisation;
using LocalisationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;



namespace LocalisationsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBusStopUrl()
        {
            // GIVEN
            Model model = new Model();

            // WHEN
            string urlToTest = model.buildUrl(0.1, 0.1);

            // THEN 
            string urlExpected = "https://data.mobilites-m.fr/api/linesNear/json?x=0.1&y=0.1&dist=400&details=true";
            Assert.AreEqual(urlExpected, urlToTest);    

        }

        [TestMethod]
        public void testBusStop()
        {
            // GIVEN
            FakeSendRequest faker = new FakeSendRequest();
            string expected = faker.getFakeInformations(); 

            // WHEN 
            OfflineRequest request = new OfflineRequest();
            string result = request.getOfflineInformations();

            // THEN
            Assert.AreEqual(expected, result);
        }

        public void testBusLine()
        {
            // GIVEN

            // WHEN

            // THEN

        }
    }
}
