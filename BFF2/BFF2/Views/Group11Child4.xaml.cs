using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group11Child4 : ContentPage
    {
        public Group11Child4()
        {
            InitializeComponent();
            pic1.Source = ImageSource.FromResource("BFF2.Images.group11child4pic1.png");
        }

        async void OnCallVideo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PacedBottleFeeding());
        }
    }
}
