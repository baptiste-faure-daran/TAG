using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Localisation
{
    interface ISendRequest
    {
        HttpWebResponse getInformations(string url);

        List<BusStop> jsonToData(HttpWebResponse response);
    }
}
