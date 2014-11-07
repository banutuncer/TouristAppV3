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
using Windows.UI.Xaml.Media.Imaging;
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

        

         int Result = 0;
        private double Resultaverage;
        private int num1 = 4;
        private int num2 = 16;
        private int num3 = 0;
        private double num4 = 0.0;
        
        

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            
            num2 = 2;
            num3 = num3 + 1;
            Result = num1 + num2;
            Resultaverage = Result/num3;
            num1 = Result;
            
            if (Resultaverage == 1)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley1.png"));
            }
            if (Resultaverage == 2)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley2.png"));
            }
            if (Resultaverage == 3)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley3.png"));
            }
            if (Resultaverage == 4)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley4.png"));
            }
            if (Resultaverage == 5)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley5.png"));
            }
            
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            num2 = 1;
            num3 = num3 + 1;
            Result = num1 + num2;
            Resultaverage = Result / num3;
            num1 = Result;
            if (Resultaverage == 1)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley1.png"));
            }
            if (Resultaverage == 2)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley2.png"));
            }
            if (Resultaverage == 3)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley3.png"));
            }
            if (Resultaverage == 4)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley4.png"));
            }
            if (Resultaverage == 5)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley5.png"));
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            num2 = 3;
            num3 = num3 + 1;
            Result = (num1 + num2);
            Resultaverage = Result / num3;
            num1 = Result;
            if (Resultaverage == 1)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley1.png"));
            }
            if (Resultaverage == 2)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley2.png"));
            }
            if (Resultaverage == 3)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley3.png"));
            }
            if (Resultaverage == 4)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley4.png"));
            }
            if (Resultaverage == 5)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley5.png"));
            }
            
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            num2 = 4;
            num3 = num3 + 1;
            Result = (num1 + num2);
            Resultaverage = Result / num3;
            num1 = Result;
            if (Resultaverage == 1)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley1.png"));
            }
            if (Resultaverage == 2)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley2.png"));
            }
            if (Resultaverage == 3)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley3.png"));
            }
            if (Resultaverage == 4)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley4.png"));
            }
            if (Resultaverage == 5)
            {
                this.Image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley5.png"));
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            num2 = 5;
            num3 = num3 + 1;
            Result = (num1 + num2);
            Resultaverage = Result/num3;
            num1 = Result;
            if (Resultaverage == 1)
            {
                this.Image1.Source =
                    new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley1.png"));
            }
            if (Resultaverage == 2)
            {
                this.Image1.Source =
                    new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley2.png"));
            }
            if (Resultaverage == 3)
            {
                this.Image1.Source =
                    new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley3.png"));
            }
            if (Resultaverage == 4)
            {
                this.Image1.Source =
                    new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley4.png"));
            }
            if (Resultaverage == 5)
            {
                this.Image1.Source =
                    new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:/Assets/Smiley5.png"));
            }
        }

        private void ExerciseButton_OnClickButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ExerciseDetailPage));
        }

        private void HotelButton_OnClickButton_Click(object sender, RoutedEventArgs e)
        {
            
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

        private void Smiley_Click(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("ms-appx:/Assets/RandomBackground/SmileyBackground.jpg"));
            myBrush.ImageSource = image.Source;
            Grid.Background = myBrush; 
        }

        private void Cow_Click(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("ms-appx:/Assets/RandomBackground/Cow.jpg"));
            myBrush.ImageSource = image.Source;
            Grid.Background = myBrush; 
        }

        private void Daniel_Click(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("ms-appx:/Assets/RandomBackground/Daniel.JPG"));
            myBrush.ImageSource = image.Source;
            Grid.Background = myBrush; 
        }

        private void Computer_Click(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("ms-appx:/Assets/RandomBackground/Computer.jpg"));
            myBrush.ImageSource = image.Source;
            Grid.Background = myBrush; 
        }

       

       
         
    }
}
