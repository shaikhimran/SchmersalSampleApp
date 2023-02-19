using System;
using System.Collections.Generic;
using System.Text;

namespace SchmersalSampleAppLib.Interface
{
    public interface IUnitOfWork
    {
        public IMovieRepository MovieRepository { get; }
    }
}
