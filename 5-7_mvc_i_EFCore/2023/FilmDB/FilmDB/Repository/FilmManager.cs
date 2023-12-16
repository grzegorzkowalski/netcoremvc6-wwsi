using FilmDB.Data;
using FilmDB.Models;

namespace FilmDB.Repository
{
    public class FilmManager
    {
        private ApplicationDbContext _applicationDbContext;
        public FilmManager(ApplicationDbContext applicationDbContext) 
        {
            _applicationDbContext = applicationDbContext;    
        }
        public FilmManager AddFilm(FilmModel filmModel)
        {
            try
            {
                _applicationDbContext.Add(filmModel);
                _applicationDbContext.SaveChanges();
                
            }
            catch (Exception)
            {

                filmModel.ID = 0;
                //applicationDbContext.Add(filmModel);
                _applicationDbContext.SaveChanges();
            }
            return this;
        }

        public FilmManager RemoveFilm(int id)
        {
            var filmToDel = GetFilm(id);
            if (filmToDel != null)
            {
                _applicationDbContext.Films.Remove(filmToDel);
                _applicationDbContext.SaveChanges();
            }
            return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            _applicationDbContext.Films.Update(filmModel);
            _applicationDbContext.SaveChanges();
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            var filmToUpdate = GetFilm(id);
            if (filmToUpdate != null)
            {
                try
                {
                    filmToUpdate.Title = newTitle;
                    _applicationDbContext.SaveChanges();
                }
                catch (Exception)
                {

                    filmToUpdate.Title = "Brak Tytułu";
                    _applicationDbContext.SaveChanges();
                }

            }
            return this;
        }

        public FilmModel GetFilm(int id)
        {
            return _applicationDbContext.Films.Single(x =>  x.ID == id);
        }

        public List<FilmModel> GetFilms()
        {
            return _applicationDbContext.Films.ToList();
        }
    }
}
