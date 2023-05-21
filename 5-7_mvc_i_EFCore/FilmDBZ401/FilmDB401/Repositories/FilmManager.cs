using FilmDB401.Data;
using FilmDB401.Models;
using System.Linq;

namespace FilmDB401.Repositories
{
    public class FilmManager
    {
        private ApplicationDbContext _context;
        public FilmManager (ApplicationDbContext context)
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
            var filmToDelete = _context.Films.SingleOrDefault(x => x.ID == id);
            try
            {
                _context.Films.Remove(filmToDelete);
                _context.SaveChanges();
            }
            catch (Exception)
            {

               
            }
            
            return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            return this;
        }

        public void ChangeTitle(int id, string newTitle)
        {
            if (String.IsNullOrEmpty(newTitle))
            {
                newTitle = "Brak tytułu";
            }
            var film = GetFilm(id);
            film.Title = newTitle;
            _context.Films.Update(film);
            _context.SaveChanges();
        }

        public FilmModel GetFilm(int id)
        {
            return _context.Films.SingleOrDefault(x => x.ID == id);
        }

        public List<FilmModel> GetFilms()
        {
            return _context.Films.ToList();
        }
    }
}
