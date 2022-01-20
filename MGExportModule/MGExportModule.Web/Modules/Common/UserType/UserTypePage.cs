
namespace MGExportModule.Common.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Common/UserType"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.UserTypeRow))]
    public class UserTypeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Common/UserType/UserTypeIndex.cshtml");
        }
    }
}