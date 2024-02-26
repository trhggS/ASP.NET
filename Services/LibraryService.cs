using lr4.Models;

namespace lr4.Services
{
    public class LibraryService
    {
        private readonly IConfiguration _configuration;

        public LibraryService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Book> GetBooks()
        {
            var books = _configuration.GetSection("Books").Get<List<Book>>();
            return books;
        }
    }
}
