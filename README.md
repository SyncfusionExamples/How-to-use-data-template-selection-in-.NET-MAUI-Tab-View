# How to use data template selection in .NET MAUI Tab View

This article explains how to use data template selector text in [.NET MAUI Tab View](https://www.syncfusion.com/maui-controls/maui-tab-view). 

* The `DataTemplateSelector` can be assigned to both [HeaderItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_HeaderItemTemplate) and [ContentItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_ContentItemTemplate) of the SfTabView to select templates based on the bound data.

By using a `DataTemplateSelector` to the [HeaderItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_HeaderItemTemplate) of the SfTabView, multiple custom user interfaces can be applied to render tab header data items based on specific conditions.

Similarly, a `DataTemplateSelector` can be applied to the [ContentItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_ContentItemTemplate) of the SfTabView to conditionally apply different content templates for each tab.
 
> **Note:**
> DataTemplateSelector is supported only when the ItemsSource property is used to generate tab items.

**MainPage.Xaml**
 ```
 <ContentPage.Resources>
    <!-- Normal header -->
    <DataTemplate x:Key="NormalHeaderTemplate">
        <Label Text="{Binding Title}" Padding="12" FontSize="14" />
    </DataTemplate>

    <!-- Important header -->
    <DataTemplate x:Key="ImportantHeaderTemplate">
        <StackLayout Orientation="Horizontal" Spacing="6" Padding="12">
            <Label Text="★" FontSize="14" TextColor="DarkOrange" />
            <Label Text="{Binding Title}" FontAttributes="Bold" TextColor="DarkOrange" />
        </StackLayout>
    </DataTemplate>

    <!-- DataTemplateSelector for HeaderItemTemplate-->
    <local:HeaderTemplateSelector x:Key="HeaderSelector"
           NormalTemplate="{StaticResource NormalHeaderTemplate}"
           ImportantTemplate="{StaticResource ImportantHeaderTemplate}" />

    <!-- Normal content -->
    <DataTemplate x:Key="NormalContentTemplate">
        <StackLayout Padding="20">
            <Label Text="{Binding Description}" FontSize="14" />
        </StackLayout>
    </DataTemplate>

    <!-- Important content -->
    <DataTemplate x:Key="ImportantContentTemplate">
        <Grid Padding="10">
            <Border Padding="20" StrokeShape="RoundRectangle 8" BackgroundColor="#FFF6E5" Stroke="DarkOrange">
                <StackLayout Spacing="8">
                    <Label Text="Important" FontAttributes="Bold" TextColor="DarkOrange" />
                    <Label Text="{Binding Description}" FontSize="14" />
                </StackLayout>
            </Border>
        </Grid>
    </DataTemplate>

    <!-- DataTemplateSelector for ContentItemTemplate-->
    <local:ContentTemplateSelector x:Key="ContentSelector" 
           NormalTemplate="{StaticResource NormalContentTemplate}"
           ImportantTemplate="{StaticResource ImportantContentTemplate}" />
</ContentPage.Resources>

<ContentPage.BindingContext>
    <local:TabViewModel />
</ContentPage.BindingContext>

<tabView:SfTabView ItemsSource="{Binding Tabs}" 
        HeaderItemTemplate="{StaticResource HeaderSelector}"
        ContentItemTemplate="{StaticResource ContentSelector}" />
 ```
 
**Output:**
   
 ![datatemplate-selector-tabview.gif](https://support.syncfusion.com/kb/agent/attachment/article/23128/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjYyNDI4Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.0cvnU0Xiss1XmgxjUk6Iin89a5UA1_Ghgg8eHTXUlPM)