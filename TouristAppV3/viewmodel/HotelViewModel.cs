using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TouristAppV3.model;

namespace TouristAppV3.viewmodel
{
    class HotelViewModel : INotifyPropertyChanged
    {
        private HotelModel _selectedHotelModel;
        public ObservableCollection<HotelModel> _hotels;

        public HotelViewModel()
        {
            _hotels = new ObservableCollection<HotelModel>();
            #region Hotels
            #region Ho1
            HotelModel Ho1 = new HotelModel();
            Ho1.Name = "Scandic";
            Ho1.Location = "Søndre Ringvej 33";
            Ho1.Phonenumber = "46320232";
            Ho1.Stars = 3;
            Ho1.ImageUrl = @"assets/Hotels/ScandicHotel.jpg";
            Ho1.Description = "Scandic Roskilde! /n Scandic is located in the beautiful Ringpark, and is just a few steps away from the city center";
            #endregion
            #region Ho2
            HotelModel Ho2 = new HotelModel();
            Ho2.Name = "Hotel Prindsen";
            Ho2.Location = "Algade 13";
            Ho2.Phonenumber = "46309100";
            Ho2.Stars = 3;
            Ho2.ImageUrl = @"Assets/Hotels/PrindsenHotel.jpg";
            Ho2.Description = "Prindsen Roskilde! /n A Hotel located in the city center, the style is ancient and the rooms feel old in a good way";
            #endregion
            #region Ho3
            HotelModel Ho3 = new HotelModel();
            Ho3.Name = "Comwell";
            Ho3.Location = "Vestre Kirkevej 12";
            Ho3.Phonenumber = "46323131";
            Ho3.Stars = 3;
            Ho3.ImageUrl = @"Assets/Hotels/ComwellHotel.jpg";
            Ho3.Description = "Comwell Roskilde! /n Comwell is a nice Hotel located near Roskilde fjord and has a nice view over the sea";
            #endregion
            #region Ho4
            HotelModel Ho4 = new HotelModel();
            Ho4.Name = "Danhostel";
            Ho4.Location = "Vindeboder 7";
            Ho4.Phonenumber = "46352184";
            Ho4.Stars = 0;
            Ho4.ImageUrl = @"Assets/Hotels/DanhostelHotel.jpg";
            Ho4.Description = "Danhostel Roskilde! /n Danhostel is a cheap but nice hotel Located near the Roskilde Harbour and has alot of green places located close to it";
            #endregion
            #region Ho5
            HotelModel Ho5 = new HotelModel();
            Ho5.Name = "Roskilde Camping & Cottages";
            Ho5.Location = "Baunehøjvej 7";
            Ho5.Phonenumber = "46757996";
            Ho5.Stars = 3;
            Ho5.ImageUrl = @"Assets/Hotels/RoskildeCamping.jpg";
            Ho5.Description = "Roskilde Camping & Cottages /n Roskilde camping is the perfect place to stay for a lowbudget vacation";
            #endregion
            #endregion

            _hotels.Add(Ho1);
            _hotels.Add(Ho2);
            _hotels.Add(Ho3);
            _hotels.Add(Ho4);
            _hotels.Add(Ho5);
        }

        public HotelModel SelectedHotelModel
        {
            get { return _selectedHotelModel; }
            set
            {
                _selectedHotelModel = value;
                OnPropertyChanged("SelectedHotelModel");
            }
        }

        public ObservableCollection<HotelModel> Hotels
        {
            get { return _hotels; }
            set { _hotels = value; }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        
        }
        #endregion
    }
}
