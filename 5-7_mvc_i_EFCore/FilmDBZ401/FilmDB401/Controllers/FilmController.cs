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
            //var film = new FilmModel();
            //film.Title = "Gladiator2";
            //film.Year = 2006;
            //_filmManager.AddFilm(film);
            _filmManager.RemoveFilm(3);
            return View();
        }
    }
}
