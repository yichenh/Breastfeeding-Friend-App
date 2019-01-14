using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group4Child1 : ContentPage
    {
        public Group4Child1()
        {
            InitializeComponent();
            pic1.Source = ImageSource.FromResource("BFF2.Images.group4child1pic1.png");
            pic2.Source = ImageSource.FromResource("BFF2.Images.group4child1pic2.png");
            pic3.Source = ImageSource.FromResource("BFF2.Images.group4child1pic3.png");
            pic4.Source = ImageSource.FromResource("BFF2.Images.group4child1pic4.png");
            pic5.Source = ImageSource.FromResource("BFF2.Images.group4child1pic5.png");
            pic6.Source = ImageSource.FromResource("BFF2.Images.group4child1pic6.png");
            pic7.Source = ImageSource.FromResource("BFF2.Images.group4child1pic7.png");
        }

        async void OnCallVideo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HowToBreastFeed());
        }
    }
}
