using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieService
{
    
    public class MovieRepository : IMovieRepository
    {
        private MovieContext db = new MovieContext();

        public Movie DeleteMovie(int id)
        {
            Movie movie = new Movie();
            try
            {
                movie = GetMovie(id);
                db.Movies.Remove(movie);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }
            return movie;
        }

        public Movie GetMovie(int id)
        {
            return db.Movies.Find(id);
        }

        public List<Movie> GetMovies()
        {
            return db.Movies.ToList();
        }

        public Movie SaveMovie(Movie movie)
        {
            try
            {
                
                db.Movies.Add(movie);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return movie;
        }

        public Movie UpdateMovie(Movie movie)
        {
            db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return movie;
        }
    }
}
