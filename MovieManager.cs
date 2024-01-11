using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesConApp
{
    public class MovieManager
    {
        private List<Movie> movies;

        public MovieManager()
        {
            movies = new List<Movie>
        {
            new Movie { Title = "Movie 1", Director = "Director 1", ReleaseDate = DateTime.Parse("2010-04-11") },
            new Movie { Title = "Movie 2", Director = "Director 2", ReleaseDate = DateTime.Parse("2012-02-12") },
            new Movie { Title = "Movie 3", Director = "Director 3", ReleaseDate = DateTime.Parse("2011-03-10") },
            new Movie { Title = "Movie 4", Director = "Director 4", ReleaseDate = DateTime.Parse("2013-05-15") }

        };
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovieByTitle(string title)
        {
            return movies.Find(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
