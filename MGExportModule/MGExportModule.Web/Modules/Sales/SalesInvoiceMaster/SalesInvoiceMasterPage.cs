
namespace MGExportModule.Sales.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Sales/SalesInvoiceMaster"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.SalesInvoiceMasterRow))]
    public class SalesInvoiceMasterController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Sales/SalesInvoiceMaster/SalesInvoiceMasterIndex.cshtml");
        }
    }
}