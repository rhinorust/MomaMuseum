using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MomaMuseum
{
    class DirectionMoma : ContentPage
    {
        public DirectionMoma()
        {
            Title = AppLanguageResource.Directions;
            BackgroundColor = Color.White;
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Contacts data goes here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}
