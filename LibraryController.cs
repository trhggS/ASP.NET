using lr4.Services;
using Microsoft.AspNetCore.Mvc;

namespace lr4.Controllers
{
    public class LibraryController : Controller
    {
        private readonly LibraryService _libraryService;
        private readonly UserService _userService;

        public LibraryController(LibraryService libraryService, UserService userService)
        {
            _libraryService = libraryService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return Content("Welcome to the Library!");
        }

        public IActionResult Books()
        {
            var books = _libraryService.GetBooks();
            return Json(books);
        }

        public IActionResult Profile(int? id)
        {
            var userProfile = _userService.GetUserProfile(id);
            return Json(userProfile);
        }
    }
}
