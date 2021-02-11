using System.ComponentModel;
using System.Windows.Input;
using Transport.Model;

namespace Transport.ViewModel
{
    public class MyViewModel : INotifyPropertyChanged
    {
        private Coordonates coordonates;
        public string result;
        public ICommand ModifyData { get; set; }

        public string Latitude
        {
            get { return coordonates.Latitude; }
            set
            {
                if (coordonates.Latitude != value)
                {
                    coordonates.Latitude = value;
                    OnPropertyChange("Latitude");
                }
            }
        }

        public string Longitude
        {
            get { return coordonates.Longitude; }
            set
            {
                if (coordonates.Longitude != value)
                {
                    coordonates.Longitude = value;
                    OnPropertyChange("Longitude");
                }
            }
        }

        public string Distance
        {
            get { return coordonates.Distance; }
            set
            {
                if (coordonates.Distance != value)
                {
                    coordonates.Distance = value;
                    OnPropertyChange("Distance");
                }
            }
        }

        public MyViewModel()
        {
            coordonates = new Coordonates
            {
                Latitude = "5.1245873",
                Longitude = "45.3658741",
                Distance = "500",
            };
            result = "Cliquez sur le bouton pour me changer";
            this.ModifyData = new Command(DoModifyData);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void DoModifyData()
        {
            this.Result = "Bonjour";
            OnPropertyChange("Result");
        }

        public string Result
        {
            get { return result; }
            set
            {
                if (result != value)
                {
                    result = value;
                    OnPropertyChange("Result");
                }
            }
        }
    }
}
