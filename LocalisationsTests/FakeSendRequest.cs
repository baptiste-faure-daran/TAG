using Localisation;
using LocalisationLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace LocalisationsTests
{
    public class FakeSendRequest
    {


        public string getFakeInformations()
        {
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
            return expected;
        }

        public List<BusStop> JsonToData(HttpWebResponse response)
        {
            throw new NotImplementedException();
        }

        public List<LigneStop> JsonToDataLigne(HttpWebResponse response)
        {
            throw new NotImplementedException();
        }

        HttpWebResponse getInformations(string url)
        {
            throw new NotImplementedException();
        }

        List<BusStop> jsonToData(HttpWebResponse response)
        {
            throw new NotImplementedException();
        }

        List<LigneStop> jsonToDataLigne(HttpWebResponse response)
        {
            throw new NotImplementedException();
        }
    }
}
