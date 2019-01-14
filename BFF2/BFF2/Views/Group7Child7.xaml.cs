using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group7Child7 : ContentPage
    {
        public Group7Child7()
        {
            InitializeComponent(); 
            Image[] images =
            {
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child7pic1.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child7pic2.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child7pic3.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child7pic4.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child7pic5.png")},
            };
            Helpers.AddRedirectToViewByName("group9child0", images[1]);
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
