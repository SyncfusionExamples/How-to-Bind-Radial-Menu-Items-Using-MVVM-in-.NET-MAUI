using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BindRadialItems
{
    public class RadialMenuViewModel
    {
        public ObservableCollection<RadialMenuItemInfo> MenuItems { get; set; }

        public RadialMenuViewModel()
        {
            MenuItems = new ObservableCollection<RadialMenuItemInfo>()
            {
                new RadialMenuItemInfo()
                {
                    Icon = "\uE700"
                },
                new RadialMenuItemInfo()
                {
                    Icon = "\uE715"
                },
                new RadialMenuItemInfo()
                {
                    Icon = "\uE70A"
                },
                new RadialMenuItemInfo()
                {
                    Icon = "\uE716"
                },
                new RadialMenuItemInfo()
                {
                    Icon = "\uE77E"
                }
            };
        }
    }
}
