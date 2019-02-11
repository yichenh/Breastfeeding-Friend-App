using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group7Child4 : ContentPage
    {
        public Group7Child4()
        {
            InitializeComponent();
            pic1.Source = ImageSource.FromResource("BFF2.Images.group7child4pic1.png");
            pic2.Source = ImageSource.FromResource("BFF2.Images.group7child4pic2.png");
            pic3.Source = ImageSource.FromResource("BFF2.Images.group7child4pic3.png");
            pic4.Source = ImageSource.FromResource("BFF2.Images.group7child4pic4.png");
            pic5.Source = ImageSource.FromResource("BFF2.Images.group7child4pic5.png");
        }

        async void OnCallVideo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReversePressureSofteningforEngorgement());
        }
    }
}
