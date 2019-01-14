using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group8Child0 : ContentPage
    {
        public Group8Child0()
        {
            InitializeComponent();
            Image[] images =
            {
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group8child0pic1.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group8child0pic2.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group8child0pic3.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group8child0pic4.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group8child0pic5.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group8child0pic6.png")},
            };
            Helpers.AddRedirectToViewByName("group9child0", images[4]);
            Helpers.AddRedirectToURI(
                "https://health.mo.gov/living/wellness/tobacco/smokingandtobacco/pdf/QuitlineFactSheet2.pdf",
                images[1]
            );
            var sView = new ScrollView();
            var layout = new StackLayout();
            foreach (var image in images)
            {
                layout.Children.Add(image);
            }
            sView.Content = layout;
            Content = sView;
        }
    }
}
