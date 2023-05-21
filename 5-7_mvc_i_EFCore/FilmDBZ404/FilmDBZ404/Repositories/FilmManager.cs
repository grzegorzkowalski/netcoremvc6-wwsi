using FilmDBZ404.Data;
using FilmDBZ404.Models;

namespace FilmDBZ404.Repositories
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
            _context.Films.Add(filmModel);
            _context.SaveChanges();
            return this;    
        }

        public FilmManager RemoveFilm(int id)
        {
            try
            {
                var film = _context.Films.SingleOrDefault(x => x.Id == id);
                _context.Films.Remove(film);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
            return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            _context.Films.Update(filmModel);
            _context.SaveChanges();
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            if (String.IsNullOrEmpty(newTitle))
            {
                newTitle = "Brak tytuł";
            }
            var film = GetFilm(id);
            film.Name = newTitle;
            UpdateFilm(film);
            return this;
        }

        public FilmModel GetFilm(int id)
        {
            return _context.Films.SingleOrDefault(x => x.Id == id);
        }

        public List<FilmModel> GetFilms()
        {
            return _context.Films.ToList();
        }
    }
}
