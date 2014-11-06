using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace TouristAppV3.model
{
    class viking
    {
        private string _name;
        private int _lenght;
        private string _material;
        private string _imageUrl;
        private int _speed;


        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int lenght
        {
            get { return _lenght; }
            set { _lenght = value; }
        }



        public string material
        {
            get { return _material; }
            set { _material = value; }
        }

        public string ImageUrl
        {
            get { return _imageUrl; }
            set { _imageUrl = value; }
        }

        public int speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
