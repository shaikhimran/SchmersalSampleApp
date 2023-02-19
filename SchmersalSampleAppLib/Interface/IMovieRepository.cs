using SchmersalSampleAppLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchmersalSampleAppLib.Interface
{
    public interface IMovieRepository
    {
        public List<Movie> GetMovies(string genere);
    }
}
