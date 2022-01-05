
namespace MGExportModule.Sales.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Sales/SalesInvoiceDetail"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.SalesInvoiceDetailRow))]
    public class SalesInvoiceDetailController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Sales/SalesInvoiceDetail/SalesInvoiceDetailIndex.cshtml");
        }
    }
}