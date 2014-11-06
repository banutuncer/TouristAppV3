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
    internal class VikingViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<viking> _vikings;
        private viking _selectedViking;

        
        public ObservableCollection<viking> Vikings
        {
            get { return _vikings; }
            set { _vikings = value; }
        }

        public viking SelectedViking
        {
            get { return _selectedViking; }
            set
            {
                _selectedViking = value;
                OnPropertyChanged("SelectedViking");
            }
        }

        public VikingViewModel()
        {
            _vikings = new ObservableCollection<viking>();

            viking vi = new viking();
            vi.Name = "Skuldelev1";
            vi.ImageUrl = @"/Assets/Vikings/resim5.jpg";
            vi.speed = 6;
            vi.material = "Pine, Oak and Lime";
            vi.lenght = 16;




            viking vi2 = new viking();
            vi2.Name = "Skuldelev2";
            vi2.ImageUrl = @"/Assets/Vikings/resim6.jpg";
            vi2.speed = 7;
            vi2.material = "Oak";
            vi2.lenght = 30;


            viking vi3 = new viking();
            vi3.Name = "Skuldelev3";
            vi3.ImageUrl = @"/Assets/Vikings/resim7.jpg";
            vi3.speed = 4;
            vi3.material = "Oak";
            vi3.lenght = 14;


            viking vi4 = new viking();
            vi4.Name = "Skuldelev5";
            vi4.ImageUrl = @"/Assets/Vikings/resim8.jpg";
            vi4.speed = 7;
            vi4.material = "Oak, Pine, Ash, Alder";
            vi4.lenght = 14;


            viking vi5 = new viking();
            vi5.Name = "Skuldelev6";
            vi5.ImageUrl = @"/Assets/Vikings/resim9.jpg";
            vi5.speed = 5;
            vi5.material = "Pine, Birch, and Oak";
            vi5.lenght = 12;

            _vikings.Add(vi);
            _vikings.Add(vi2);
            _vikings.Add(vi3);
            _vikings.Add(vi4);
            _vikings.Add(vi5);


        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}