using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group7Child1 : ContentPage
    {
        public Group7Child1()
        {
            InitializeComponent();
            Image[] images =
           {
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child1pic1.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child1pic2.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child1pic3.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child1pic4.png")},
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
