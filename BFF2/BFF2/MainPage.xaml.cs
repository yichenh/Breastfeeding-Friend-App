using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BFF2
{
	public partial class MainPage : MasterDetailPage
	{
        ControlTemplate controlTemplate = new ControlTemplate(typeof(Template));
		public MainPage()
		{
			InitializeComponent();
            toc.listView.ItemSelected += OnItemSelected;
            Detail = createPage(new Views.WelcomePage());
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            Detail = MakePageFromItem(item);
        }

        public NavigationPage MakePageFromItem(MasterPageItem item)
        {
            if (item != null)
            {
                toc.listView.SelectedItem = null;
                IsPresented = false;
                if (item.Images != null)
                {
                    var emptyPage = (Views.PureImage)Activator.CreateInstance(item.TargetType);
                    emptyPage.AddImages(item.Images);
                    return createPage(emptyPage);
                }
                else
                {
                    return createPage((ContentPage)Activator.CreateInstance(item.TargetType));
                }
            }
            else
            {
                return (NavigationPage) Detail;
            }
        }

        public void GoToPageByName(string name)
        {
            if(name != null)
            {
                MasterPageItem[] items = (MasterPageItem[]) toc.listView.ItemsSource;
                for(var i = 0; i<items.Length; i++)
                {
                    if(name == items[i].UqName)
                    {
                        Detail = MakePageFromItem(items[i]);
                        break;
                    }
                }
            }
        }

        public void GoToCustomPage(Type type)
        {
            Detail = createPage((ContentPage)Activator.CreateInstance(type));
        }

        NavigationPage createPage(ContentPage basePage)
        {
            basePage.ControlTemplate = controlTemplate;
            var navPage = new NavigationPage(basePage);
            navPage.BarBackgroundColor = Color.FromHex("#a51417");
            return navPage;
        }
    }
}
