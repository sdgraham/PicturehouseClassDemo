using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picturehouse
{

    /// <summary>
    /// Represents a film that is currently showing at the picture house
    /// </summary>
    public class Film
    {
        public string Title { get; set; }
        public string AgeRating { get; set; }
        public int RunningTime { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Film(string filmTitle, string ageRating, int runningTime, DateTime releaseDate)
        {

        }
    }
}
