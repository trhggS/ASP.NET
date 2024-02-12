namespace lr2
{
    using Microsoft.Extensions.Configuration;

    public class ConfigurationAnalysisService
    {
        private readonly IConfiguration _configuration;

        public ConfigurationAnalysisService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetCompanyWithMaxEmployees()
        {
            int maxEmployees = 0;
            string companyWithMaxEmployees = "";

            foreach (var company in _configuration.GetSection("Companies").GetChildren())
            {
                int employees = company.GetValue<int>("Employees");
                if (employees > maxEmployees)
                {
                    maxEmployees = employees;
                    companyWithMaxEmployees = company.Key;
                }
            }

            return companyWithMaxEmployees;
        }

        public string GetMyInformation()
        {
            string name = _configuration.GetValue<string>("MyInformation:Name");
            int age = _configuration.GetValue<int>("MyInformation:Age");
            string country = _configuration.GetValue<string>("MyInformation:Country");

            return $"Name: {name}, Age: {age}, Country: {country}";
        }
    }

}
