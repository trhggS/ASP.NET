public class ErrorLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public ErrorLoggingMiddleware(RequestDelegate next, ILogger<ErrorLoggingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            LogToFile($"Exception: {ex.Message}");
            throw;
        }
    }

    private void LogToFile(string message)
    {
        string path = "errorLog.txt";

        using (StreamWriter writer = new StreamWriter(path, append: true))
        {
            writer.WriteLine($"[{DateTime.Now}] {message}");
        }
    }
}
