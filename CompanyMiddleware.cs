using System.Text.Json;

public class CompanyMiddleware
{
    private readonly RequestDelegate _next;
    private Company _company;

    public CompanyMiddleware(RequestDelegate next)
    {
        _next = next;

        _company = new Company
        {
            Id = 1,
            Name = "Example Company",
            Description = "This is an example company."
        };
    }

    public async Task Invoke(HttpContext context)
    {
        if (context.Request.Path == "/company")
        {
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(JsonSerializer.Serialize(_company));
        }
        else if (context.Request.Path == "/random")
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 101);

            await context.Response.WriteAsync($"Random Number: {randomNumber}");
        }
        else
        {
            await _next.Invoke(context);
        }
    }
}
