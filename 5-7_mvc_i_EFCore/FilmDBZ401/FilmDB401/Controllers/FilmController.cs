using FilmDB401.Models;
using FilmDB401.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FilmDB401.Controllers
{
    public class FilmController : Controller
    {
        private FilmManager _filmManager;
        public FilmController(FilmManager filmManager)
        {
            _filmManager = filmManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FilmModel film)
        {
            _filmManager.AddFilm(film);
            return RedirectToAction("Index");
        }
    }
}
