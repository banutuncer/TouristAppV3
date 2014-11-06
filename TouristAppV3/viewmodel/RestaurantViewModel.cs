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
    class RestaurantViewModel : INotifyPropertyChanged
    {
        private RestaurantModel _selectedRestaurantModel;
        private ObservableCollection<RestaurantModel> _restaurants;
         

        public RestaurantViewModel()
        {
            _restaurants = new ObservableCollection<RestaurantModel>();
            #region Hotels
            #region Ho1
            RestaurantModel Re1 = new RestaurantModel();
            Re1.Name = "Scandic";
            Re1.Location = "Søndre Ringvej 33";
            Re1.Phonenumber = "46320232";
            Re1.ImageUrl = @"assets/Hotels/ScandicHotel.jpg";
            Re1.Description = "Scandic Roskilde! /n Scandic is located in the beautiful Ringpark, and is just a few steps away from the city center";
            #endregion
            #region Ho2
            RestaurantModel Re2 = new RestaurantModel();
            Re2.Name = "Hotel Prindsen";
            Re2.Location = "Algade 13";
            Re2.Phonenumber = "46309100";
            Re2.ImageUrl = @"Assets/Hotels/PrindsenHotel.jpg";
            Re2.Description = "Prindsen Roskilde! /n A Hotel located in the city center, the style is ancient and the rooms feel old in a good way";
            #endregion
            #region Ho3
            RestaurantModel Re3 = new RestaurantModel();
            Re3.Name = "Comwell";
            Re3.Location = "Vestre Kirkevej 12";
            Re3.Phonenumber = "46323131";
            Re3.ImageUrl = @"Assets/Hotels/ComwellHotel.jpg";
            Re3.Description = "Comwell Roskilde! /n Comwell is a nice Hotel located near Roskilde fjord and has a nice view over the sea";
            #endregion
            #region Ho4
            RestaurantModel Re4 = new RestaurantModel();
            Re4.Name = "Danhostel";
            Re4.Location = "Vindeboder 7";
            Re4.Phonenumber = "46352184";
            Re4.ImageUrl = @"Assets/Hotels/DanhostelHotel.jpg";
            Re4.Description = "Danhostel Roskilde! /n Danhostel is a cheap but nice hotel Located near the Roskilde Harbour and has alot of green places located close to it";
            #endregion
            #region Ho5
            RestaurantModel Re5 = new RestaurantModel();
            Re5.Name = "Roskilde Camping & Cottages";
            Re5.Location = "Baunehøjvej 7";
            Re5.Phonenumber = "46757996";
            Re5.ImageUrl = @"Assets/Hotels/RoskildeCamping.jpg";
            Re5.Description = "Roskilde Camping & Cottages /n Roskilde camping is the perfect place to stay for a lowbudget vacation";
            #endregion
            #endregion

            _restaurants.Add(Re1);
            _restaurants.Add(Re2);
            _restaurants.Add(Re3);
            _restaurants.Add(Re4);
            _restaurants.Add(Re5);
        }

        public RestaurantModel SelectedRestaurantModel
        {
            get { return _selectedRestaurantModel; }
            set
            {
                _selectedRestaurantModel = value;
                OnPropertyChanged("SelectedRestaurantModel");
            }
        }

        public ObservableCollection<RestaurantModel> Restaurants
        {
            get { return _restaurants; }
            set { _restaurants = value; }
        }

        internal TouristAppV3.model.RestaurantModel RestaurantModel
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
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
