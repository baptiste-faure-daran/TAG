using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Localisation
{
    public interface ISendRequest
    {
        List<BusStop> jsonToData(HttpWebResponse response);
        HttpWebResponse getInformations(string url);
        List<LigneStop> jsonToDataLigne(HttpWebResponse response);

    }
}
