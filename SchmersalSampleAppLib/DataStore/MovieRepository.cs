using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchmersalSampleAppLib.Interface;
using SchmersalSampleAppLib.Model;

namespace SchmersalSampleAppLib.DataStore
{
    public class MovieRepository: IMovieRepository
    {
        SchemersalSampleAppContext _schemersalSampleAppContext;
        public MovieRepository (SchemersalSampleAppContext schemersalSampleAppContext)
        {
            _schemersalSampleAppContext = schemersalSampleAppContext;

        }

        public List<Movie> GetMovies(string genere)
        {
           return  _schemersalSampleAppContext.Movies.
                Where(m => m.Genre.Equals(genere)).ToList();
        }
    }
}
