// See https://aka.ms/new-console-template for more information
using System;

namespace MoviesConApp
{
    class Program
    {
        static void Main()
        {
            MovieManager movieManager = new MovieManager();

            // Test GetAllMovies method
            Console.WriteLine("All Movies:");
            foreach (var movie in movieManager.GetAllMovies())
            {
                Console.WriteLine($"{movie.Title} - {movie.Director} - {movie.ReleaseDate.ToShortDateString()}");
            }

            // Test GetMovieByTitle method
            string searchTitle = "Movie 1";
            Movie foundMovie = movieManager.GetMovieByTitle(searchTitle);

            if (foundMovie != null)
            {
                Console.WriteLine($"\nMovie found by title '{searchTitle}': {foundMovie.Title} - {foundMovie.Director} - {foundMovie.ReleaseDate.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"\nMovie with title '{searchTitle}' not found.");
            }
        }
    }
}

