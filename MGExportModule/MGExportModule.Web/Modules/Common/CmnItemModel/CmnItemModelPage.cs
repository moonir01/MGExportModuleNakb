
namespace MGExportModule.Common.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Common/CmnItemModel"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CmnItemModelRow))]
    public class CmnItemModelController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Common/CmnItemModel/CmnItemModelIndex.cshtml");
        }
    }
}