using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LocalisationLibrary
{
    public interface IRequest
    {
        HttpWebResponse getInformations(string url);

        List<BusStop> jsonToData(HttpWebResponse response);

        List<LigneStop> jsonToDataLigne(HttpWebResponse response);

        List<BusStop> generateBusStop(string url);

        List<LigneStop> generateLineStop(string url);
    }
}
