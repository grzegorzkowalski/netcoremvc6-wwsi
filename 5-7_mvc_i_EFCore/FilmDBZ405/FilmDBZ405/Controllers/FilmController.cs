using Microsoft.AspNetCore.Mvc;
using FilmDBZ405.Repositories;
using FilmDBZ405.Models;

namespace FilmDBZ405.Controllers
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
            //film.Title = "Gladiator3";
            //film.Year = 2024;
            //_filmManager.AddFilm(film);
            ////_filmManager.RemoveFilm(2);
            //var getFilm = _filmManager.GetFilm(1);
            //_filmManager.ChangeTitle(5, null);
            //var allFilms = _filmManager.GetFilms();
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
            try
            {
                _filmManager.AddFilm(film);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(film);
            }
        }

        public IActionResult FilmList()
        {
            var films = _filmManager.GetFilms();
            return View(films);
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var film = _filmManager.GetFilm(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            try
            {
                _filmManager.RemoveFilm(id);
                return RedirectToAction("FilmList");
            }
            catch (Exception)
            {

                return View("Remove", id);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var film = _filmManager.GetFilm(id);
            return View(film);
            //_filmManager.UpdateFilm(film);
        }

        [HttpPost]
        public IActionResult Edit(FilmModel film)
        {
            _filmManager.UpdateFilm(film);
            return RedirectToAction("FilmList");
        }
    }
}
