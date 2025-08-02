namespace Recycle_web_api.Middlewares;

public class PrimeiroMiddleware
{
    public RequestDelegate _next { get; }

    // para criação de middlewares é necessario utilizar o RequestDelegate
    // como parametro
    public PrimeiroMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    // também é necessário chamar o Invoke ou o InvokeAsync e deve
    // retornar sempre uma tasks
    public async Task InvokeAsync(HttpContext httpContext)
    {

        Console.WriteLine("executou o primeiro middleware");

        await _next(httpContext);

        Console.WriteLine("executou pos primeiro middleware");
    }
}
