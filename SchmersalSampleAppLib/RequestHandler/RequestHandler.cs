using System;
using System.Collections.Generic;
using SchmersalSampleAppLib.Interface;
using SchmersalSampleAppLib.Model;

namespace SchmersalSampleAppLib.RequestHandler
{
    public class RequestHandler : IRequestHandler
    {
        private readonly IUnitOfWork _unitOfWork;
        public RequestHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Movie> GetMoviesByGenere(string genre)
        {
          return  _unitOfWork.MovieRepository.GetMovies(genre);
        }
    }
}
