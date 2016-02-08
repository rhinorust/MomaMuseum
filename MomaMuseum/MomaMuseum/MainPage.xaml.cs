﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MomaMuseum
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MapPage()) { BarBackgroundColor = Color.FromHex("0066ff"), BackgroundColor = Color.White };
            masterPage.ListView.ItemSelected += OnItemSelected;
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
