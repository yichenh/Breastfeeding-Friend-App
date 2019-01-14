using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();

            welcomeImage.Source = ImageSource.FromResource("BFF2.Images._welcome.png");
        }
    }
}
