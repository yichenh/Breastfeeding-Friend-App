using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group4Child0 : ContentPage
    {
        public Group4Child0()
        {
            InitializeComponent();
            pic1.Source = ImageSource.FromResource("BFF2.Images.group4child0pic1.png");
            pic2.Source = ImageSource.FromResource("BFF2.Images.group4child0pic2.png");
            pic3.Source = ImageSource.FromResource("BFF2.Images.group4child0pic3.png");
        }

        async void OnCallVideo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Unicef());
        }
    }
}
