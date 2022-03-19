using eTicketsShop.Data.Base;
using eTicketsShop.Data.ValidationModels;
using eTicketsShop.Data.ViewModels;
using eTicketsShop.Models;

namespace eTicketsShop.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);

        Task AddNewMovieAsync(MovieValidationModel data);

        Task UpdateMovieAsync(Movie data);
    }
}
