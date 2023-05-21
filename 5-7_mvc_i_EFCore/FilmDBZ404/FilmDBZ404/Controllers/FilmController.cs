using FilmDBZ404.Models;
using FilmDBZ404.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FilmDBZ404.Controllers
{
    public class FilmController : Controller
    {
        private FilmManager _manager;
        public FilmController(FilmManager manager)
        {
            _manager = manager;        
        }
        public IActionResult Index()
        {
            var film = _manager.GetFilms();
            return View(film);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FilmModel film)
        {
            _manager.AddFilm(film);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var filmDetails = _manager.GetFilm(id);
            return View(filmDetails);   
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            _manager.RemoveFilm(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var filmToEdit = _manager.GetFilm(id);
            return View(filmToEdit);
        }

        [HttpPost]
        public IActionResult Edit(FilmModel film)
        {
            _manager.UpdateFilm(film);
            return RedirectToAction("Index");
        }


    }
}
