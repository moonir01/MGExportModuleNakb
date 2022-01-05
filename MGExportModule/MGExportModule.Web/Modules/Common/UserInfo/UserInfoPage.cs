
namespace MGExportModule.Common.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Common/UserInfo"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.UserInfoRow))]
    public class UserInfoController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Common/UserInfo/UserInfoIndex.cshtml");
        }
    }
}