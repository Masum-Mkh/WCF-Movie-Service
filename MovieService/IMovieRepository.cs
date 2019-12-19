using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMovieRepository" in both code and config file together.
    [ServiceContract]
    public interface IMovieRepository
    {
        [OperationContract]
        List<Movie> GetMovies();

        [OperationContract]
        Movie GetMovie(int id);

        [OperationContract]
        Movie SaveMovie(Movie movie);

        [OperationContract]
        Movie UpdateMovie(Movie movie);

        [OperationContract]
        Movie DeleteMovie(int id);
    }
}
