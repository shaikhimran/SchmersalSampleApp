using System;
using System.Collections.Generic;
using System.Text;

namespace SchmersalSampleAppLib.Model
{
    public class Response
    {
        public Response()
        {
            Movies = new List<Movie>();
            Errors = new List<Error>();
        }
        public bool IsSuccess { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Error> Errors { get; set; }
    }

    public class Error
    {
       
        public string Message { get; set; }
    }
}
