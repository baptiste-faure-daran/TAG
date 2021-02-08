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
    public class Request : IRequest
    {
        public HttpWebResponse getInformations(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)request.GetResponse();
            return response;
        }
        public List<BusStop> jsonToData(HttpWebResponse response)
        {

            string jsonResponse;
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                jsonResponse = streamReader.ReadToEnd();
            }
            var busStopList = JsonConvert.DeserializeObject<List<BusStop>>(jsonResponse);
            Console.WriteLine(response.StatusDescription);

            return busStopList;
        }
        public List<LigneStop> jsonToDataLigne(HttpWebResponse response)
        {

            string jsonResponse;
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                jsonResponse = streamReader.ReadToEnd();
            }
            var busStopList = JsonConvert.DeserializeObject<List<LigneStop>>(jsonResponse);
            Console.WriteLine(response.StatusDescription);

            return busStopList;
        }

        public List<BusStop> generateBusStop(string url)
        {
            Request request = new Request();
            HttpWebResponse data = request.getInformations(url);
            List<BusStop> busStop = request.jsonToData(data);

            return busStop;
        }

        public List<LigneStop> generateLineStop(string url)
        {
            Request request = new Request();
            HttpWebResponse data = request.getInformations(url);
            List<LigneStop> ligneStop = request.jsonToDataLigne(data);

            return ligneStop;
        }


    }
}
