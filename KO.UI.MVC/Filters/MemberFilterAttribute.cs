using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KO.Entity;
using KO.UI.MVC.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace KO.UI.MVC.Filters
{
    public class MemberFilterAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)

        {
            var tempmember = context.HttpContext.Session.GetObjectFromJson<Member>("Member");

            if (tempmember == null)
            {
                context.Result = new RedirectResult("/Login/Index");
            }
            return;
        }
    }
}
