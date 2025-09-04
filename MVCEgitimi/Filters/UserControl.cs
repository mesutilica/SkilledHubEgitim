using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters; // filtre kullanabilmek için gerekli kütüphane

namespace MVCEgitimi.Filters
{
    public class UserControl : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var SessionUserGuid = context.HttpContext.Session.GetString("UserGuid");
            var CookiesUserguid = context.HttpContext.Request.Cookies["userguid"];
            var id = context.HttpContext.Session.GetInt32("kullaniciId");
            if (id is null)
            {
                context.Result = new RedirectResult("/MVC12Session?msg=AccessDenied");
            }
            base.OnActionExecuting(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            base.OnResultExecuting(context);
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            base.OnResultExecuted(context);
        }
    }
}
