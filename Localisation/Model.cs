using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Localisation
{
    class Model
    {

        public Model()
        {
        }

        public void getUrl(int choiceNumber)
        {
            string url = "";
            switch (choiceNumber)
            {
                case 1:
                    Console.WriteLine("CCI");
                    url = "https://data.mobilites-m.fr/api/linesNear/json?x=5.7290103&y=45.1858202&dist=400&details=true";
                    displayBusStop(url);

                    break;
                case 2:
                    Console.WriteLine("Chez Wam");
                    url = "https://data.mobilites-m.fr/api/linesNear/json?x=5.724524&y=45.188529&dist=400&details=true";
                    displayBusStop(url);

                    break;
                case 3:
                    Console.WriteLine("Stade des Alpes");
                    url = "https://data.mobilites-m.fr/api/linesNear/json?x=5.74015&y=45.1874&dist=400&details=true";
                    displayBusStop(url);

                    break;
                case 4:
                    Console.WriteLine("Offline");

                    break;

            }

        }

        public void displayBusStop(string url)
        {
            SendRequest request = new SendRequest();
            HttpWebResponse test = request.getInformations(url);
            List<BusStop> busStop = request.jsonToData(test);
            foreach (BusStop stop in busStop)
            {
                Console.WriteLine(stop.id);
                Console.WriteLine(stop.name);
                Console.WriteLine(stop.zone);

            }
            
        }

        


    }
}
