
namespace MGExportModule.Common.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Common/CmnItemGroup"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CmnItemGroupRow))]
    public class CmnItemGroupController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Common/CmnItemGroup/CmnItemGroupIndex.cshtml");
        }
    }
}