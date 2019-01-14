using System;
using Xamarin.Forms;
namespace BFF2
{
    public class Template : ContentView
    {
        /**
         * Use this class to make changes on every view. The variable content
         * is added as a ContentPresenter.        
         */
        public Template()
        {
            var contentPresenter = new ContentPresenter();
            var layout = new StackLayout();
            layout.BackgroundColor = Color.FromHex("#DADBD6");
            layout.Children.Add(contentPresenter);
            var label = new Label();
            label.Text = "BFF 2";
            layout.Children.Add(label);
            Content = layout;
        }
    }
}
