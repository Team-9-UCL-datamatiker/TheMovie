using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Model
{
    public class Movie(string title, string duration, string genre)
    {
        public string Title { get; set; } = title;
        public string Duration { get; set; } = duration;
        public string Genre { get; set; } = genre;

        public override string ToString()
        {
            return $"{Title}, {Genre}, {Duration}";
        }
    }
}
