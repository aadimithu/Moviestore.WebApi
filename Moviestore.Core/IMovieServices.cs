using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviestore.Core
{
    public interface IMovieServices
    {
        List<Movie> GetMovies();
        //Movie GetMovie(string id);
    }
}
