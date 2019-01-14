using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BFF2.Views
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class View1 : ContentPage
	{
		public View1 ()
		{
			InitializeComponent ();
            testImage.Source = ImageSource.FromResource("BFF2.Images.group2child0pic1.png");
		}
	}
}