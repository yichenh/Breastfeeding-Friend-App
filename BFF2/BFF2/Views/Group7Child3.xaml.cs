using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group7Child3 : ContentPage
    {
        public Group7Child3()
        {
            InitializeComponent();
            Image[] images =
           {
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child3pic1.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child3pic2.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child3pic3.png")},
                new Image(){Source = ImageSource.FromResource(Helpers.ImagePrefix + "group7child3pic4.png")},
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
