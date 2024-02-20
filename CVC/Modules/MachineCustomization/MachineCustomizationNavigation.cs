using Serenity.Navigation;
using MyPages = CVC.MachineCustomization.Pages;

// added by Denis for RS 6.5 dated 8/3/2021
[assembly: NavigationLink(int.MaxValue, "Display Object Types/List Display", typeof(MyPages.ListDisplayController), icon: null)]
// added by Denis for RS 6.5 dated 8/6/2021
[assembly: NavigationLink(int.MaxValue, "Display Object Types/Form Display", typeof(MyPages.FormDisplayController), icon: null)]
// added by Denis for RS 6.5 dated 8/7/2021
[assembly: NavigationLink(int.MaxValue, "Display Object Types/Button Display", typeof(MyPages.ButtonDisplayController), icon: null)]
// added by Denis for RS 6.5 dated 8/7/2021
[assembly: NavigationLink(int.MaxValue, "Display Object Types/Realtime Parameter Display", typeof(MyPages.RealtimeParameterDisplayController), icon: null)]
// added by Denis for RS 6.5 dated 8/7/2021
[assembly: NavigationLink(int.MaxValue, "Display Object Types/Line Chart Display", typeof(MyPages.LineChartDisplayController), icon: null)]
// added by Denis for RS 6.5 dated 8/9/2021
[assembly: NavigationLink(int.MaxValue, "Display Object Types/Pie Chart Display", typeof(MyPages.PieChartDisplayController), icon: null)]
// added by Denis for RS 6.5 dated 8/9/2021
[assembly: NavigationLink(int.MaxValue, "Display Object Types/Tree Display", typeof(MyPages.TreeDisplayController), icon: null)]
// added by Denis for RS 6.5 dated 8/11/2021
[assembly: NavigationLink(int.MaxValue, "Display Object Types/Attachment Display", typeof(MyPages.AttachmentDisplayController), icon: null)]
// added by Denis for RS 6.5 dated 8/11/2021
[assembly: NavigationLink(int.MaxValue, "Display Object Types/Alarm Display", typeof(MyPages.AlarmDisplayController), icon: null)]
// added by Denis for RS 6.5 dated 8/11/2021
[assembly: NavigationLink(int.MaxValue, "Display Object Types/Notification Display", typeof(MyPages.NotificationDisplayController), icon: null)]
// added by Denis for RS 6.5 dated 8/11/2021
[assembly: NavigationLink(int.MaxValue, "Display Object Types/Container Display", typeof(MyPages.ContainerDisplayController), icon: null)]
// added by Denis for RS 8.1 dated 9/6/2021
[assembly: NavigationLink(int.MaxValue, "Entity Customization/Business Entity Relationship", typeof(MyPages.PrimaryRelationshipController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Entity Customization/Secondary Relationship", typeof(MyPages.SecondaryRelationshipController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Entity Customization/Screen Views", typeof(MyPages.ScreenViewsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Entity Customization/Display Object Type Color", typeof(MyPages.DisplayObjectTypeColorController), icon: null)]