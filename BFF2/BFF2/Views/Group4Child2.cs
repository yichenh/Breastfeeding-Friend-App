using System;

using Xamarin.Forms;

namespace BFF2.Views
{
    public class Group4Child2 : ContentPage
    {
        public Group4Child2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

