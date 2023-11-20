using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HikingRoutes.API.CumstomActionFilters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        // Custom action attribute to return BadRequest if ModelState is not valid
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ModelState.IsValid == false)
            {
                context.Result = new BadRequestResult();
            }
        }
    }
}
