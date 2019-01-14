using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group7Child8 : ContentPage
    {
        public Group7Child8()
        {
            InitializeComponent();
            Image[] images =
            {
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child8pic1.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child8pic2.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child8pic3.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child8pic4.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child8pic5.png")},
            };
            Helpers.AddRedirectToCustomView(typeof(Group10Child0), images[2]);
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
