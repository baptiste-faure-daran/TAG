using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LocalisationLibrary
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

        public string getOfflineLineInformations()
        {
            List<LigneStop> busLigneList = new List<LigneStop>();
            LigneStop busLigne= new LigneStop();


            busLigne.id = "SEM:1138";
            busLigne.gtfsId = "Grenoble, Marceau - Jardin des Vallons";
            busLigne.shortName = "";
            busLigne.longName = "";
            busLigne.color = "SEM_GENMARCEAU";
            busLigne.textColor = "SEM_GENMARCEAU";
            busLigne.mode = "SEM_GENMARCEAU";
            busLigne.type = "SEM_GENMARCEAU";

            busLigneList.Add(busLigne);
            string output = JsonConvert.SerializeObject(busLigneList);
            return output;
        }

        public List<BusStop> OfflineJsonToDataBus(string response)
        {
            var busStopList = JsonConvert.DeserializeObject<List<BusStop>>(response);

            return busStopList;
        }

        public List<LigneStop> OfflineJsonToDataLigne(string response)
        {
            var busLigneList = JsonConvert.DeserializeObject<List<LigneStop>>(response);

            return busLigneList;
        }

        public List<BusStop> generateOfflineBusStop()
        {
            OfflineRequest request = new OfflineRequest();
            string test = request.getOfflineInformations();
            List<BusStop> offlineBusStop = request.OfflineJsonToDataBus(test);

            return offlineBusStop;
        }

        public List<LigneStop> generateOfflineLineStop()
        {
            OfflineRequest request = new OfflineRequest();

            string data = request.getOfflineLineInformations();
            List<LigneStop> offlineLigneStop = request.OfflineJsonToDataLigne(data);


            return offlineLigneStop;
        }
    }
}
