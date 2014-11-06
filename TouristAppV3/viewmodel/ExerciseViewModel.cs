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
    class ExerciseViewModel:INotifyPropertyChanged
    {
        private Route _myRoute;
        public ObservableCollection<Route> Routes { get; set; } 

        public ExerciseViewModel()
        {
            Route Running1 = new Route() {Name = "Running1", ImageUrl = @"/Assets/Running/map1.jpg", Description = "This is a 2.83 km Run in Roskilde, SJ, Denmark. The Run has a total ascent of 39.43 m and has a maximum elevation of 43.26 m. This route was created by baun1 on 11/02/2012."};
            Route Running2 = new Route() { Name = "Running2", ImageUrl = @"/Assets/Running/map2.jpg", Description = "This is a 3.74 km Run in Roskilde, SJ, Denmark. The Run has a total ascent of 11.45 m and has a maximum elevation of 51.88 m. This route was created by krhan87 on 11/15/2012." };
            Route Cycling1 = new Route() { Name = "Cycling1", ImageUrl = @"/Assets/Running/map3.jpg", Description = "This is a 13.67 km Mtn Biking in Roskilde, Denmark. The Mtn Biking has a total ascent of 82.67 m and has a maximum elevation of 47.71 m. This route was created by tvh1308 on 07/31/2012." };
            Route Cycling2 = new Route() { Name = "Cycling2", ImageUrl = @"/Assets/Running/map4.jpg", Description = "This is a 18.58 km Mtn Biking in Roskilde, Denmark. The Mtn Biking has a total ascent of 134.35 m and has a maximum elevation of 53.26 m. This route was created by jenslc on 09/19/2013." };
           
            MyRoute = Running1;
            Routes = new ObservableCollection<Route>() { Running1, Running2, Cycling1, Cycling2 };

        }

        public Route MyRoute
        {
            get { return _myRoute; }
            set
            {
                _myRoute = value;
                OnPropertyChanged("MyRoute");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
