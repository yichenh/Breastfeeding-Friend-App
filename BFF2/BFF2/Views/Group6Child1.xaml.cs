using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group6Child1 : ContentPage
    {
        private string prefix = Helpers.ImagePrefix;
        public Group6Child1()
        {
            InitializeComponent();
            Image[] images =
            {
                new Image(){Source = ImageSource.FromResource(prefix + "group6child1pic1.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group6child1pic2.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group6child1pic3.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group6child1pic4.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group6child1pic5.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group6child1pic6.png")},
            };
            Helpers.AddRedirectToCustomView(typeof(Group5Child0), images[3]);
            Helpers.AddRedirectToCustomView(typeof(Group7Child0), images[4]);
            Helpers.AddRedirectToCustomView(typeof(Group8Child0), images[5]);
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
