using AuthorApplication2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorApplication2.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController
        public ActionResult Index()
        {
            List<Movies> movieList = RepositoryMovie.GetMovieList();
            return View(movieList);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Movies movie = RepositoryMovie.GetMovieID(id);
          
            return View(movie);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            Movies movie = new Movies();
            return View(movie);
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Movies pmovie)
        {
            try
            {
                if (ModelState.IsValid) //inbuilt property for all controllers
                {
                   RepositoryMovie.AddNewMovie(pmovie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {
            Movies movie = RepositoryMovie.GetMovieID(id);
            
            if (id <= 0)
            {

                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Movies movies)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryMovie.UpdateMovie(movies);

                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Movies movie = RepositoryMovie.GetMovieID(id);
            return View(movie);
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                RepositoryMovie.DeleteMovie(id);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
