using System.Collections.Generic;
using System.Linq;

namespace LocalisationLibrary
{
    public class BusInfo
    {

        public string Message { get; set; }
        public List<BusStop> _busStop { get; set; } = new List<BusStop>();
        public List<LigneStop> _ligneStop { get; set; } = new List<LigneStop>();

        public BusInfo(List<BusStop> busStop, List<LigneStop> ligneStop)
        {
            _busStop = busStop;
            _ligneStop = ligneStop;
            if(!_ligneStop.Any())
            {
                Message = "Il n'y a pas de transport correspondant à votre demande.";
            } else
            {
                Message = "Liste des transports correspondants à votre demande :";
            }
        }
    }
}
