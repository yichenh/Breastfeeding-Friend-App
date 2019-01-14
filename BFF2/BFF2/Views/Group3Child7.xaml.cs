using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group3Child7 : ContentPage
    {
        private string prefix = Helpers.ImagePrefix;
        public Group3Child7()
        {
            InitializeComponent();
            Image[] images =
            {
                new Image(){Source = ImageSource.FromResource(prefix + "group3child7pic1.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group3child7pic2.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group3child7pic3.png")},
            };
            Helpers.AddRedirectToCustomView(typeof(Group8Child2), images[2]);
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
