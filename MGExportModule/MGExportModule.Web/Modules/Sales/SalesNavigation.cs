using Serenity.Navigation;
using MyPages = MGExportModule.Sales.Pages;

[assembly: NavigationLink(int.MaxValue, "Sales/Sales Invoice Detail", typeof(MyPages.SalesInvoiceDetailController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Sales/Sales Invoice Master", typeof(MyPages.SalesInvoiceMasterController), icon: null)]