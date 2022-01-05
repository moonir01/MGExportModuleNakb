
namespace MGExportModule.Common.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Common/CmnItemMaster"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CmnItemMasterRow))]
    public class CmnItemMasterController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Common/CmnItemMaster/CmnItemMasterIndex.cshtml");
        }
    }
}