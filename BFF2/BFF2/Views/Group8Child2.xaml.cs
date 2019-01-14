using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group8Child2 : ContentPage
    {
        private string prefix = Helpers.ImagePrefix;
        public Group8Child2()
        {
            InitializeComponent();
            Image[] images =
            {
                new Image(){Source = ImageSource.FromResource(prefix + "group8child2pic1.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group8child2pic2.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group8child2pic3.png")},
            };
            Helpers.AddRedirectToCustomView(typeof(Group3Child7), images[2]);
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
