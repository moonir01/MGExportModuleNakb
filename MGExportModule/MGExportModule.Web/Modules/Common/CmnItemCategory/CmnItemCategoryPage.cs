
namespace MGExportModule.Common.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Common/CmnItemCategory"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CmnItemCategoryRow))]
    public class CmnItemCategoryController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Common/CmnItemCategory/CmnItemCategoryIndex.cshtml");
        }
    }
}