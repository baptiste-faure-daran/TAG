using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LocalisationLibrary
{
    public class Localise
    {
        public string buildUrl(double lon, double lat)
        {
            string url = $"https://data.mobilites-m.fr/api/linesNear/json?x={lon}&y={lat}&dist=400&details=true".Replace(',', '.');

            return url;
        }
    }
}
