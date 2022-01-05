
namespace MGExportModule.Common.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Common/CmnItemSize"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CmnItemSizeRow))]
    public class CmnItemSizeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Common/CmnItemSize/CmnItemSizeIndex.cshtml");
        }
    }
}