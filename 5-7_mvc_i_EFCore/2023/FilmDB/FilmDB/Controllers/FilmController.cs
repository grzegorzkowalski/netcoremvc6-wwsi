using FilmDB.Models;
using FilmDB.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        private FilmManager _manager;
        public FilmController(FilmManager filmManager) 
        {
            _manager = filmManager;
        }
        public IActionResult Index()
        {
            var films = _manager.GetFilms();

            return View(films);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FilmModel filmModel)
        {
            try
            {   
                _manager.AddFilm(filmModel);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View(filmModel);
            }
            
            
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var film = _manager.GetFilm(id);

            return View(film);
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            var filmToDelete = _manager.GetFilm(id);
            if (filmToDelete != null) 
            {
                _manager.RemoveFilm(id);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Remove", id);
            }  
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var film = _manager.GetFilm(id);

            return View(film);
        }

        [HttpPost]
        public IActionResult Edit(FilmModel film)
        {
            _manager.UpdateFilm(film);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id) 
        { 
            var film = _manager.GetFilm(id);
            return View(film);
        }

    }
}
