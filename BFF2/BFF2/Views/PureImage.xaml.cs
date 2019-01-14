using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BFF2.Views
{
    public partial class PureImage : ContentPage
    {
        private string NamespacePrefix = Helpers.ImagePrefix;

        public PureImage()
        {
            InitializeComponent();
        }

        public void AddImages(CustomImage[] images)
        { 
            var sview = new ScrollView();
            var layout = new StackLayout();
            sview.VerticalOptions = LayoutOptions.FillAndExpand;
            sview.HorizontalOptions = LayoutOptions.FillAndExpand;
            sview.Orientation = ScrollOrientation.Vertical;
            for (var i = 0; i < images.Length; i++)
            {
                var image = new Image { 
                    Source = ImageSource.FromResource(
                        NamespacePrefix + images[i].Path
                    ) 
                };
                layout.Children.Add(image);
                //image.Aspect = Aspect.AspectFill;
                image.VerticalOptions = LayoutOptions.FillAndExpand;
                image.HorizontalOptions = LayoutOptions.FillAndExpand;
            }
            layout.HorizontalOptions = LayoutOptions.FillAndExpand;
            layout.VerticalOptions = LayoutOptions.FillAndExpand;
            sview.Content = layout;
            Content = sview;
            Content.HorizontalOptions = LayoutOptions.FillAndExpand;
        }
    }
}
