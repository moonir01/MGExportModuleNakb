using Serenity.Navigation;
using MyPages = MGExportModule.Common.Pages;

[assembly: NavigationLink(int.MaxValue, "Common/User Info", typeof(MyPages.UserInfoController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Common/Cmn Item Brand", typeof(MyPages.CmnItemBrandController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Common/Cmn Item Category", typeof(MyPages.CmnItemCategoryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Common/Cmn Item Group", typeof(MyPages.CmnItemGroupController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Common/Cmn Item Model", typeof(MyPages.CmnItemModelController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Common/Cmn Item Size", typeof(MyPages.CmnItemSizeController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Common/Item", typeof(MyPages.CmnItemMasterController), icon: null)]