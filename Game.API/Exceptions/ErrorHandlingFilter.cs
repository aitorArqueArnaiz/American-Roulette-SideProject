using Microsoft.AspNetCore.Mvc.Filters;

public class ErrorHandlingFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        Serilog.Log.ForContext<ErrorHandlingFilter>().Error($"Error ocurred during execution of action {context.ActionDescriptor.DisplayName}. Error message {exception}");

        context.ExceptionHandled = true; 
    }
}