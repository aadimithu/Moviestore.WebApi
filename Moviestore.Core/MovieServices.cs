using System;
using System.Collections.Generic;


namespace Moviestore.Core
{
    public class MovieServices : IMovieServices
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {

                    Name = "avatar",
                    Price = "123",
                    Category = "action",
                    Award = "no",
                    Description = "enimated"
                }

                 
            };
            
        }
    }
}
