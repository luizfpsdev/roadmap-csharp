namespace Recycle_web_api.Middlewares;

public class SegundoMiddleware
{
    public RequestDelegate _next { get; }
    public SegundoMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext httpContext)
    {

        Console.WriteLine("executou o segundo middleware");

        await _next(httpContext);

        Console.WriteLine("executou pos segundo middleware");
    }
}
