using GeekStore.Infrastructure.IoC;
using GeekStore.Service.Interfaces;
using System.Web.Mvc;

namespace GeekStore.UI.Extensions
{
    public class AdminRoleRequiredAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //var userService = Infrastructure.IoC.ServiceLocator.Resolve<IUserService>();
            var userName = filterContext.HttpContext.User.Identity.Name;
            var userService = ServiceLocator.Get<IUserService>();
            var user = userService.GetByName(userName);
            if(user == null)
            {
                filterContext.Result = new RedirectResult("/Home/Index");

            }
            else if (!user.IsAdmin)
            {
                filterContext.Result = new RedirectResult("/Home/Index");
            }
        }
    }
}