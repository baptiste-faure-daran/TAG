//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;

//namespace Localisation
//{
//    public class SendRequest : ISendRequest
//    {

//        public HttpWebResponse getInformations(string url)
//        {
//            WebRequest request = WebRequest.Create(url);
//            request.Credentials = CredentialCache.DefaultCredentials;
//            request.ContentType = "application/json; charset=utf-8";
//            var response = (HttpWebResponse)request.GetResponse();
//            return response;
//        }

//        public List<BusStop> jsonToData(HttpWebResponse response)
//        {

//            string jsonResponse;
//            using (var streamReader = new StreamReader(response.GetResponseStream()))
//            {
//                jsonResponse = streamReader.ReadToEnd();
//            }
//            var busStopList = JsonConvert.DeserializeObject<List<BusStop>>(jsonResponse);
//            Console.WriteLine(response.StatusDescription);

//            return busStopList;
//        }

        
//    }
//}
