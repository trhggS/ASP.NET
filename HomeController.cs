namespace lr2
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private readonly ConfigurationAnalysisService _configurationService;

        public HomeController(ConfigurationAnalysisService configurationService)
        {
            _configurationService = configurationService;
        }

        public IActionResult Index()
        {
            string companyWithMaxEmployees = _configurationService.GetCompanyWithMaxEmployees();

            string myInformation = _configurationService.GetMyInformation();

            return Content($"Company with max employees: {companyWithMaxEmployees}\n\nMy Information: {myInformation}");
        }
    }

}
