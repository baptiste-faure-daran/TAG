﻿using LocalisationLibrary;
using System;
using System.Collections.Generic;
using System.Net;

namespace Localisation
{
    public class Model
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
                    url = buildUrl(5.7290103, 45.1858202);
                    displayBusStop(url);

                    break;
                case 2:
                    Console.WriteLine("Chez Wam");
                    url = buildUrl(5.724524, 45.188529);
                    displayBusStop(url);

                    break;
                case 3:
                    Console.WriteLine("Stade des Alpes");
                    url = buildUrl(5.724524, 45.188529);
                    displayBusStop(url);

                    break;
                case 4:
                    Console.WriteLine("Offline");
                    offlineDisplay();

                    break;

            }

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

        public void displayBusStop(string url)
        {
            Request request = new Request();
            HttpWebResponse test = request.getInformations(url);
            List<BusStop> busStop = request.jsonToData(test);
            foreach (BusStop stop in busStop)
            {

                Console.WriteLine("Id de l'arrêt : " + stop.id);
                Console.WriteLine("Nom de l'arrêt : " + stop.name);
                Console.WriteLine("Zone de l'arrêt : " + stop.zone);
                Console.WriteLine("----------------------");

                string lineUrl = BuildLineUrl(stop.lines[0]);
                displayLinesStop(lineUrl);
            }
        }
        public void displayLinesStop(string url)
        {
            Request request = new Request();
            HttpWebResponse test = request.getInformations(url);
            List<LigneStop> ligneStop = request.jsonToDataLigne(test);
            foreach(LigneStop ligne in ligneStop)
            {
                Console.WriteLine("Id de la ligne : " + ligne.id);
                Console.WriteLine("Nom de la ligne : " + ligne.shortName);
                Console.WriteLine("Couleur de la ligne : " + ligne.color);
                Console.WriteLine("-----------------------");
            } 

        }

        public void offlineDisplay()
        {
            OfflineRequest request = new OfflineRequest();
            string test = request.getOfflineInformations();
            List<BusStop> offlineBusStop = request.OfflineJsonToData(test);
            foreach (BusStop stop in offlineBusStop)
            {
                Console.WriteLine(stop.id);
                Console.WriteLine(stop.name);
                Console.WriteLine(stop.zone);

            }
        }



    }
}
