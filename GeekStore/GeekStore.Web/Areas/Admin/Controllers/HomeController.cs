using GeekStore.UI.Extensions;
using System.Web.Mvc;

namespace GeekStore.UI.Areas.Admin.Controllers
{
    [AdminRoleRequired]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}