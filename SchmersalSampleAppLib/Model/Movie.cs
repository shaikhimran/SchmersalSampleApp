using System;
using System.Collections.Generic;
using System.Text;

namespace SchmersalSampleAppLib.Model
{
//    Id: Unique identifier for the movie

//Title: Title of the movie

//Genre: Genre of the movie
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime? ReleaseYear { get; set; }

    }
}
