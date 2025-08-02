namespace Recycle_web_api.Middlewares;

public class CultureMidleware
{
    public RequestDelegate _next { get; }
    public CultureMidleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext httpContext)
    {

        Console.WriteLine("executou o middleware");

        await _next(httpContext);

        Console.WriteLine("executou pos middleware");
    }
}
