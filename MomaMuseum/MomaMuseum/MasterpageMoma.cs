using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MomaMuseum
{
    class MasterpageMoma : ContentPage
    {
        public ListView ListView { get { return listView; } }

        ListView listView;

        public MasterpageMoma()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = AppLanguageResource.Map,
                IconSource = "ic_action_navigate.png",
                TargetType = typeof(MapMoma)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = AppLanguageResource.Storyline,
                IconSource = "ic_action_map.png",
                TargetType = typeof(StorylineMoma)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = AppLanguageResource.Scavenger,
                IconSource = "ic_action_search.png",
                TargetType = typeof(ScavengerPageMoma)
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = AppLanguageResource.Directions,
                IconSource = "ic_action_compass.png",
                TargetType = typeof(DirectionMoma)
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = AppLanguageResource.Contact,
                IconSource = "ic_action_phone.png",
                TargetType = typeof(ContactMoma)
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = AppLanguageResource.Help,
                IconSource = "ic_action_help.png",
                TargetType = typeof(HelpMoma)
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = AppLanguageResource.Settings,
                IconSource = "ic_action_settings.png",
                TargetType = typeof(SettingsMoma)
            });

            listView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() => {
                    var imageCell = new ImageCell();
                    imageCell.SetBinding(TextCell.TextProperty, "Title");
                    imageCell.TextColor = Color.White;
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
                    return imageCell;
                }),
                VerticalOptions = LayoutOptions.FillAndExpand,
        };

            Padding = new Thickness(10, 10, 0, 0);
            Icon = "menu_icon.png";
            Title = "Master";
            BackgroundColor = Color.FromHex("#001533");
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
            Children = { 
                    listView
                }
            };
        }

    }
}
