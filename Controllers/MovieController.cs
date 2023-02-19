using Microsoft.AspNetCore.Mvc;
using SchmersalSampleAppLib.Interface;
using SchmersalSampleAppLib.Model;

namespace SchmersalSampleApp.Controllers
{

    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IRequestHandler _requestHandler;

        public MovieController(IRequestHandler requestHandler)
        {
            _requestHandler = requestHandler;
        }
        /// <summary>
        /// Get movies details by genre
        /// </summary>
        /// <param name="Genre"></param>
        /// <returns></returns>
        [Route("Movie/GetByGenre")]
        [HttpPost]
        public IActionResult GetByGenre(string Genre)
        {
            Response httpResponse = new Response { IsSuccess = true};
            try
            {
                
                if (string.IsNullOrEmpty(Genre))
                {
                    httpResponse.IsSuccess = false;
                    httpResponse.Errors.Add(new Error { Message = $"'{nameof(Genre)}' cannot be null or empty." });
                    return BadRequest(httpResponse);
                }

                var moviesList = _requestHandler.GetMoviesByGenere(Genre);
               
                httpResponse.Movies.AddRange(moviesList);

                return Ok(httpResponse);
            }
            catch (System.Exception ex)
            {
                httpResponse.IsSuccess = false;
                httpResponse.Errors.Add(new Error { Message = ex.Message });
                return BadRequest(httpResponse);

            }
           


        }
    }
}
