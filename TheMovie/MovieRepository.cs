using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    public class MovieRepository
    {
        public ObservableCollection<Movie> Movies;
        public MovieRepository()
        {
            Movies = new ObservableCollection<Movie>();
            //Movies.Add(new Movie("one", "2", "three"));
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public void RemoveMovie(int index)
        {
            Movies.Remove(Movies[index]);
        }

        public void UpdateMovie(Movie movie)
        {
            //implementation
        }

        public void AddMoviesFromList(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line = sr.ReadLine();
            while (line != null)
            {
                int pack = 0;
                string[] words = line.Split(';');
                AddMovie(new Movie(words[3], words[5], words[4]));

                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
