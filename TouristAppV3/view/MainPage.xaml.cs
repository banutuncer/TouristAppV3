using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using TouristAppV3.view;

namespace TouristAppV3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        

        private void NatureButton_OnClickButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NatureDetailPage));
        }

        private void RestaurantButton_OnClick_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RestaurantDetailPage));
        }

        private void ExerciseButton_OnClickButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ExerciseDetailPage));
        }

        private void HotelButton_OnClickButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HotelDetailPage));
        }

        private void MuseumButton_OnClickButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VikingView));
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Exercise_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ExerciseDetailPage));
        }

        private void Viking_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VikingView));
        }

        private void Restaurants_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RestaurantDetailPage));
        }

        private void Hotels_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HotelDetailPage));
        }
    }
}
