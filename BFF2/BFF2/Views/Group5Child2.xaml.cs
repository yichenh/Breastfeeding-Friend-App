using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group5Child2 : ContentPage
    {
        public Group5Child2()
        {
            InitializeComponent();
            Image[] images =
            {
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group5child2pic1.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group5child2pic2.png")},
            };
            Helpers.AddRedirectToCustomView(typeof(Group11Child3), images[1]);
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
