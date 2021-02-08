using System;
using System.Collections.Generic;

namespace LocalisationLibrary
{
    public class Model
    {

        private double X = 5.7290103;
        private double Y = 45.1858202;

        public Model()
        {
        }

        public void getUrl(int choiceNumber)
        {
            switch (choiceNumber)
            {
                case 1:
                    choiceCase(5.7290103, 45.1858202, "CCI");
                    break;

                case 2:
                    choiceCase(5.724524, 45.188529, "Chez Wam");
                    break;

                case 3:
                    choiceCase(5.724524, 45.188529, "Stade des Alpes");

                    break;

                case 4:
                    Console.WriteLine("Offline");
                    OfflineRequest offline = new OfflineRequest();
                    List<BusStop> resultStop = offline.generateOfflineBusStop();
                    offlineStopDisplay(resultStop);
                    break;

            }

        }
        public BusInfo CreateBusInfoObjet()
        {

            Request request = new Request();
            string url = buildUrl(X, Y);

            List<BusStop> resultBus = request.generateBusStop(url);

            string lineUrl = "";
            foreach (BusStop stop in resultBus)
            {
                lineUrl = BuildLineUrl(stop.lines[0]);
            }

            List<LigneStop> resultLine = request.generateLineStop(lineUrl);

            BusInfo busInfo = new BusInfo(resultBus, resultLine);

            return busInfo;

        }


        private void choiceCase(double lon, double lat, string text)
        {
            Console.WriteLine(text);
            string url = buildUrl(lon, lat);
            Request request = new Request();
            List<BusStop> resultBus = request.generateBusStop(url);
            displayBusStop(resultBus);
        }

        public string buildUrl(double lon, double lat)
        {
            string url = $"https://data.mobilites-m.fr/api/linesNear/json?x={lon}&y={lat}&dist=400&details=true".Replace(',', '.');

            return url;
        }
        public string BuildLineUrl(string lineId)
        {
            string url = $"https://data.mobilites-m.fr/api/routers/default/index/routes?codes={lineId}";

            return url;
        }

        public void displayBusStop(List<BusStop> result)
        {

            foreach (BusStop stop in result)
            {

                Console.WriteLine("Id de l'arrêt : " + stop.id);
                Console.WriteLine("Nom de l'arrêt : " + stop.name);
                Console.WriteLine("Zone de l'arrêt : " + stop.zone);
                Console.WriteLine("----------------------");

                string lineUrl = BuildLineUrl(stop.lines[0]);

                Request request = new Request();
                List<LigneStop> resultLine = request.generateLineStop(lineUrl);
                displayLinesStop(resultLine);
            }
        }

        public void displayLinesStop(List<LigneStop> ligneStop)
        {

            foreach (LigneStop ligne in ligneStop)
            {
                Console.WriteLine("Id de la ligne : " + ligne.id);
                Console.WriteLine("Nom de la ligne : " + ligne.shortName);
                Console.WriteLine("Couleur de la ligne : " + ligne.color);
                Console.WriteLine("-----------------------");
            }

        }

        public void offlineStopDisplay(List<BusStop> resultStop)
        {

            foreach (BusStop stop in resultStop)
            {

                Console.WriteLine("Id de l'arrêt : " + stop.id);
                Console.WriteLine("Nom de l'arrêt : " + stop.name);
                Console.WriteLine("Zone de l'arrêt : " + stop.zone);
                Console.WriteLine("----------------------");


                OfflineRequest offlineRequest = new OfflineRequest();
                List<LigneStop> resultLine = offlineRequest.generateOfflineLineStop();
                offlineLineDisplay(resultLine);
            }
        }

        public void offlineLineDisplay(List<LigneStop> resultLine)
        {

            foreach (LigneStop ligne in resultLine)
            {

                Console.WriteLine("Id de la ligne : " + ligne.id);
                Console.WriteLine("Nom de la ligne : " + ligne.shortName);
                Console.WriteLine("Couleur de la ligne : " + ligne.color);
                Console.WriteLine("-----------------------");

            }
        }

    }
}

