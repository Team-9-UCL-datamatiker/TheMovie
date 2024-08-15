using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    public class Movie
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Genre { get; set; }

        public Movie(string title, string duration, string genre)
        {
            Title = title;
            Duration = duration;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Title}, {Genre}, {Duration}";
        }
    }
}
