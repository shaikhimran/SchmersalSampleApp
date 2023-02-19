using System;
using System.Collections.Generic;
using System.Text;
using SchmersalSampleAppLib.Interface;
namespace SchmersalSampleAppLib.DataStore
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IMovieRepository movieRepository)
        {
            MovieRepository = movieRepository;
        }
        public IMovieRepository MovieRepository { get; }
    }
}
