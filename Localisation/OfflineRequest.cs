using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Localisation
{
    public class OfflineRequest
    {

        public string getOfflineInformations()
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
            string output = JsonConvert.SerializeObject(busStopList);
            return output;
        }

        public List<BusStop> OfflineJsonToData(string response)
        {
            var busStopList = JsonConvert.DeserializeObject<List<BusStop>>(response);

            return busStopList;
        }

    }
}
