using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MomaMuseum
{
    class MainMoma : MasterDetailPage
    {
        MasterpageMoma masterPage;

        public MainMoma()
        {
            masterPage = new MasterpageMoma();
            Master = masterPage;
            Detail = new NavigationPage(new MapMoma()) { BarBackgroundColor = Color.FromHex("0066ff"), BackgroundColor = Color.White };

            masterPage.ListView.ItemSelected += OnItemSelected;

           // if (Device.OS == TargetPlatform.Windows)
            //{
            //    Master.Icon = "swap.png";
           // }
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType)) { BarBackgroundColor = Color.FromHex("0066ff"), BackgroundColor = Color.White };
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
