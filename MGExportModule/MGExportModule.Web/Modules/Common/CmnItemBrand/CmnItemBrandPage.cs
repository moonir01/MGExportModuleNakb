
namespace MGExportModule.Common.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Common/CmnItemBrand"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CmnItemBrandRow))]
    public class CmnItemBrandController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Common/CmnItemBrand/CmnItemBrandIndex.cshtml");
        }
    }
}