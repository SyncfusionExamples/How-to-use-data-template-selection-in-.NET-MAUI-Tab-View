namespace TabView
{
    public class ContentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate? NormalTemplate { get; set; }
        public DataTemplate? ImportantTemplate { get; set; }

        protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
        {
            return item is TabData data && data.IsImportant ? ImportantTemplate : NormalTemplate;
        }
    }
}
