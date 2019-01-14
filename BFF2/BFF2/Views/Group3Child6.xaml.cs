using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class Group3Child6 : ContentPage
    {
        private string prefix = Helpers.ImagePrefix;
        public Group3Child6()
        {
            InitializeComponent();
            Image[] images =
            {
                new Image(){Source = ImageSource.FromResource(prefix + "group3child6pic1.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group3child6pic2.png")},
                new Image(){Source = ImageSource.FromResource(prefix + "group3child6pic3.png")},
            };
            Helpers.AddRedirectToCustomView(typeof(Group4Child2), images[2]);
            var sView = new ScrollView();
            var layout = new StackLayout();
            foreach(var image in images)
            {
                layout.Children.Add(image);
            }
            sView.Content = layout;
            Content = sView;
        }
    }
}
