using SchmersalSampleAppLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchmersalSampleAppLib.Interface
{
    public interface IRequestHandler
    {
        public List<Movie> GetMoviesByGenere(string genre);
    }
}
