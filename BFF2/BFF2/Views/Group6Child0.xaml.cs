using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group6Child0 : ContentPage
    {
        private string prefix = Helpers.ImagePrefix;
        public Group6Child0()
        {
            InitializeComponent();
            Image[] images =
            {
                new Image(){Source = ImageSource.FromResource(prefix + "group6child0pic1.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group6child0pic2.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group6child0pic3.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group6child0pic4.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group6child0pic5.png")},
            };
            Helpers.AddRedirectToCustomView(typeof(Group5Child1), images[2]);
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
