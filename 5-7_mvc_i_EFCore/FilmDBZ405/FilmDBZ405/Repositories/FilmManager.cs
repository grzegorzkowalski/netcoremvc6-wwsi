using FilmDBZ405.Data;
using FilmDBZ405.Models;
using System.Linq;

namespace FilmDBZ405.Repositories
{
    public class FilmManager
    {
        private ApplicationDbContext _context;
        public FilmManager(ApplicationDbContext context)
        { 
            _context = context;
        }
        public FilmManager AddFilm(FilmModel filmModel)
        {
            try
            {
                _context.Films.Add(filmModel);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                filmModel.ID = 0;
                _context.Films.Add(filmModel);
                _context.SaveChanges();
            }

            return this;
        }

        public FilmManager RemoveFilm(int id)
        {
            var filmToDelete = _context.Films.SingleOrDefault(film => film.ID == id);
            _context.Films.Remove(filmToDelete);
            _context.SaveChanges();
            
            return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            _context.Update(filmModel);
            _context.SaveChanges();
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            var filmToChange = GetFilm(id);
            try
            {
                filmToChange.Title = newTitle;
                UpdateFilm(filmToChange);
            }
            catch (Exception e)
            {
                filmToChange.Title = newTitle;
                if (newTitle == null) 
                {
                    filmToChange.Title = "Brak tytułu";
                }
                UpdateFilm(filmToChange);
            }
            return this;
        }

        public FilmModel GetFilm(int id)
        {
            var film = _context.Films.SingleOrDefault(film => film.ID == id);
            return film;
        }

        public List<FilmModel> GetFilms()
        {
            var films = _context.Films.ToList();
            return films;
        }
    }
}
