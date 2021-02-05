using Localisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LocalisationsTests
{
    public class FakeSendRequest : ISendRequest
    {


        public HttpWebResponse getInformations(string url)
        {
            throw new NotImplementedException();
        }

        public List<BusStop> jsonToData(HttpWebResponse response)
        {
            throw new NotImplementedException();
        }
    }
}
