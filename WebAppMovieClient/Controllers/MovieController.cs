using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMovieClient.MovieServiceReference;

namespace WebAppMovieClient.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            MovieRepositoryClient client = new MovieRepositoryClient();
            client.Open();
            var movieList = client.GetMovies();
            client.Close();

            return View(movieList);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            MovieRepositoryClient client = new MovieRepositoryClient();
            client.Open();
            var movie = client.GetMovie(id);
            client.Close();

            return View(movie);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(Movie model)
        {
            try
            {
                Movie movie = new Movie();

                MovieRepositoryClient client = new MovieRepositoryClient();

                client.Open();
                 movie = client.SaveMovie(model);
                client.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            MovieRepositoryClient client = new MovieRepositoryClient();
            client.Open();

            var movie = client.GetMovie(id);
            return View(movie);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie model)
        {
            try
            {
                MovieRepositoryClient client = new MovieRepositoryClient();
                client.Open();

                var movie = client.UpdateMovie(model);
                client.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                
            }
            return View();
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            MovieRepositoryClient client = new MovieRepositoryClient();
            client.Open();
            var movie = client.GetMovie(id);

            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                MovieRepositoryClient client = new MovieRepositoryClient();
                client.Open();
                client.DeleteMovie(id);
                client.Close();

                
            }
            catch
            {
                
            }
            return RedirectToAction("Index");
        }
    }
}
