using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TouristAppV3.model;

namespace TouristAppV3.viewmodel
{
    class AddViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<AddModel> _information;
        private AddModel _selectedInformation;

        public ObservableCollection<AddModel> Information
        {
            get { return _information; }
            set { _information = value; }
        }

        public AddModel selectedInformation
        {
            get { return _selectedInformation; }
            set
            {
                _selectedInformation = value;
                OnPropertyChanged("selectedInformation");
            }

        }

        public AddViewModel()
        {
            _information = new ObservableCollection<AddModel>();

            AddModel VikingsHistory = new AddModel();
            VikingsHistory.name = "Vikings History";
            VikingsHistory.Image = @"/Assets/Vikings/VikingHistory.jpg";
            VikingsHistory.Information = "Around the year 1000 five viking ships were deliberately sunken in Skuldelev in Roskilde Fjord, were hard and troubling times. The sunked ships bloqued a very important navigable route and protected Denmark's capital (in that moment Roskilde) from the enemies that came from the sea. The ships were found in 1962. It ends up that they were five different kind of ship that took the vikings to distant lands in their expeditions, transporting goods or fighting wars.";
            _information.Add(VikingsHistory);

            AddModel activities = new AddModel();
            activities.name = "Activities";
            activities.Image = @"/Assets/Vikings/VikingActivities.png";
            activities.Information = "The museum offers activities all the year and some seasonal\n\nThe year round activities are:\n- Five original viking ships. Experience warships, tradingships and a fishing vessel from the Viking Age.\n- Dress as a Viking and board a Viking Ship.\n- Workshops for children, write your name with runes!\n- Film about the five Viking Ships and its reconstruction\n- Boat Yard - experience the Viking's craftsmanship\n\nSeasonal:\n- Guided tours\n- Special exhibition: 'The World in the Viking Age";
            _information.Add(activities);

            AddModel transport = new AddModel();
            transport.name = "Transport";
            transport.Image = @"/Assets/Vikings/Map.png";
            transport.Information = "Parking:There is a large, free car park by the Museum Island, with parking bays for invalid cars.\nBy train: Most regional trains from Zealand and Inter-City trains from Jutland stop at Roskilde station.\nBy bus: Bus route 203 runs to and from Roskilde station.(http://www.moviatrafik.dk)";
            _information.Add(transport);

            AddModel openinghoursandcontact = new AddModel();
            openinghoursandcontact.name = "OpeninghoursAndContact";
            openinghoursandcontact.Image = @"/Assets/Vikings/VikingContact.jpg";
            openinghoursandcontact.Information = "OPENING HOURS\nMonday to Sunday\n10.00 - 16.00\n\nCONTACT\nThe Viking Ship Museum's address:\nVindeboder 12\nDK-4000 Roskilde\nDenmark\n\nTel: +45 46 300 200\nFax: +45 46 300 201\nE-mail: museum@vikingeskibsmuseet.dk";
            _information.Add(openinghoursandcontact);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

