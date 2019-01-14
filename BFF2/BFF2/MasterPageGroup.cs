using System;
using Xamarin.Forms;

namespace BFF2
{
    public class MasterPageGroup
    {
        public ListView Children { get; set; }
        public bool Expanded { get; set; }

        public MasterPageGroup()
        {
            Expanded = false;
            if (Children != null)
            {
                Children.IsVisible = Expanded;
            }
        }
    }
}
