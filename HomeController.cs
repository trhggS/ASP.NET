using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        //throw new Exception("Test exception");
        return View();
    }

    [HttpPost]
    public IActionResult SaveData(string value, DateTime expirationDate)
    {
        Response.Cookies.Append("Data", value, new Microsoft.AspNetCore.Http.CookieOptions
        {
            Expires = expirationDate
        });

        return RedirectToAction("CheckCookie");
    }

    public IActionResult CheckCookie()
    {
        return View();
    }
}
