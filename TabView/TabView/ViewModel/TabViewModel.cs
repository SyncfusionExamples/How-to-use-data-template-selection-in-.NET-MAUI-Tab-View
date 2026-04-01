using System.Collections.ObjectModel;

namespace TabView
{
    public class TabViewModel
    {
        public ObservableCollection<TabData> Tabs { get; }

        public TabViewModel()
        {
            Tabs = new ObservableCollection<TabData>
            {
                new TabData { Title = "Home", Description = "Home content", IsImportant = false },
                new TabData { Title = "Dashboard", Description = "Dashboard overview", IsImportant = true },
                new TabData { Title = "Messages", Description = "User messages", IsImportant = false },
                new TabData { Title = "Favorites", Description = "Pinned items", IsImportant = true },
                new TabData { Title = "Profile", Description = "User profile settings", IsImportant = false },
                new TabData { Title = "Alerts", Description = "Critical notifications", IsImportant = true }
            };
        }
    }
}
