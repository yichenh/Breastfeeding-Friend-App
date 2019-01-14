using System;
using Xamarin.Forms;
namespace BFF2
{
    /**
     * This class is used to define functions that can be accessed globally
     * and are useful for views/classes anywhere in the app.    
     */
    public static class Helpers
    {
        public static string ImagePrefix = "BFF2.Images.";

        /**
         * Adds an event listener to the Image trigger so that when it is
         * clicked it pulls up the uri `uri`.
         */
        public static void AddRedirectToURI(string uri, Image trigger)
        {
            AddGestureCallback(trigger, (object sender, EventArgs e) =>
            {
                Device.OpenUri(new Uri(uri));
            });
        }

        /**
         * Adds an event listener to the Image trigger so that when it is
         * clicked it redirects to the view whose name is `name`. This is used
         * specifically when the view being pointed at is a pure image
         * view. GoToPageByName is defined in MainPage.        
         */
        public static void AddRedirectToViewByName(string name, Image trigger)
        {
            AddGestureCallback(trigger, (object sender, EventArgs e) =>
            {
                ((MainPage)Application.Current.MainPage).GoToPageByName(name);
            });
        }

        public static void AddRedirectToCustomView(Type type, Image trigger)
        {
            AddGestureCallback(trigger, (object sender, EventArgs e) =>
            {
                ((MainPage)Application.Current.MainPage).GoToCustomPage(type);
            });
        }

        private static void AddGestureCallback(Image trigger, EventHandler callback)
        {
            var tap = new TapGestureRecognizer();
            tap.Tapped += callback;
            trigger.GestureRecognizers.Add(tap);
        }
    }
}
