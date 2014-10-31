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
        private ObservableCollection<HotelModel> _hotels;

        public HotelViewModel()
        {
            _hotels = new ObservableCollection<HotelModel>();
            #region Hotels
            #region Ho1
            HotelModel Ho1 = new HotelModel();
            Ho1.Name = "Scandic";
            Ho1.Location = "";
            Ho1.Phonenumber = "";
            Ho1.Stars = 3;
            Ho1.ImageUrl = "";
            Ho1.Description = "";
            #endregion
            #region Ho2
            HotelModel Ho2 = new HotelModel();
            Ho2.Name = "Scandic";
            Ho2.Location = "";
            Ho2.Phonenumber = "";
            Ho2.Stars = 3;
            Ho2.ImageUrl = "";
            Ho2.Description = "";
            #endregion
            #region Ho3
            HotelModel Ho3 = new HotelModel();
            Ho3.Name = "Scandic";
            Ho3.Location = "";
            Ho3.Phonenumber = "";
            Ho3.Stars = 3;
            Ho3.ImageUrl = "";
            Ho3.Description = "";
            #endregion
            #region Ho4
            HotelModel Ho4 = new HotelModel();
            Ho4.Name = "Scandic";
            Ho4.Location = "";
            Ho4.Phonenumber = "";
            Ho4.Stars = 3;
            Ho4.ImageUrl = "";
            Ho4.Description = "";
            #endregion
            #region Ho5
            HotelModel Ho5 = new HotelModel();
            Ho5.Name = "Scandic";
            Ho5.Location = "";
            Ho5.Phonenumber = "";
            Ho5.Stars = 3;
            Ho5.ImageUrl = "";
            Ho5.Description = "";
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
