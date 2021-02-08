using System.Collections.Generic;

namespace LocalisationLibrary
{
    public class BusInfo
    {
        public BusInfo(List<BusStop> busStop, List<LigneStop> ligneStop)
        {
            _busStop = busStop;
            _ligneStop = ligneStop;
        }

        public List<BusStop> _busStop { get; set; } = new List<BusStop>();
        public List<LigneStop> _ligneStop { get; set; } = new List<LigneStop>();

        
    }
}
