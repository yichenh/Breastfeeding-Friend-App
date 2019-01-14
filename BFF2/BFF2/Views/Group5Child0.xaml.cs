using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group5Child0 : ContentPage
    {
        private string prefix = Helpers.ImagePrefix;
        public Group5Child0()
        {
            InitializeComponent();
            Image[] images =
            {
                new Image(){Source = ImageSource.FromResource(prefix + "group5child0pic1.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group5child0pic2.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group5child0pic3.png")},
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
