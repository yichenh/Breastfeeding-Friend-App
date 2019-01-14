using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group8Child1 : ContentPage
    {
        public Group8Child1()
        {
            InitializeComponent();
            Image[] images =
            {
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group8child1pic1.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group8child1pic2.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group8child1pic3.png")},
            };
            Helpers.AddRedirectToCustomView(typeof(Group6Child1), images[1]);
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
