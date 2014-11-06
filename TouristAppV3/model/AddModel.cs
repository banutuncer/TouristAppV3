using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace TouristAppV3.model
{
    class AddModel
    {
        private string _name;
        private string _image;
        private string _information;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public string Information
        {
            get { return _information; }
            set { _information = value; }
        }

        public override string ToString()
        {
            return name.ToString();
        }


    }
}