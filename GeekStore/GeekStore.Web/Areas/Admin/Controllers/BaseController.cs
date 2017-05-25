using GeekStore.UI.Extensions;
using System.Web.Mvc;

namespace GeekStore.UI.Areas.Admin.Controllers
{
    [Authorize]
    [AdminRoleRequired]
    public class BaseController : Controller { }
}