using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group4Child2 : ContentPage
    {
        public Group4Child2()
        {
            InitializeComponent();
            pic1.Source = ImageSource.FromResource("BFF2.Images.group4child2pic1.png");
            pic2.Source = ImageSource.FromResource("BFF2.Images.group4child2pic2.png");
            pic3.Source = ImageSource.FromResource("BFF2.Images.group4child2pic3.png");
            pic4.Source = ImageSource.FromResource("BFF2.Images.group4child2pic4.png");
            pic5.Source = ImageSource.FromResource("BFF2.Images.group4child2pic5.png");
            pic6.Source = ImageSource.FromResource("BFF2.Images.group4child2pic6.png");
        }

        async void OnCallVideo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LatchABaby());
        }
    }
}
