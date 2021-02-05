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

        [TestMethod]
        public void testBusStop()
        {
            // GIVEN
            List<BusStop> busStopList = new List<BusStop>();
            BusStop busStop = new BusStop();
            busStop.id = "SEM:1138";
            busStop.name = "Grenoble, Marceau - Jardin des Vallons";
            busStop.lon = 5.72217;
            busStop.lat = 45.18245;
            busStop.zone = "SEM_GENMARCEAU";
            busStop.lines = new List<string>(new string[] { "SEM: C3" });

            busStopList.Add(busStop);
            string expected = JsonConvert.SerializeObject(busStopList);

            // WHEN 
            OfflineRequest request = new OfflineRequest();
            string result = request.getOfflineInformations();

            // THEN
            Assert.AreEqual(expected, result);
        }
    }
}
