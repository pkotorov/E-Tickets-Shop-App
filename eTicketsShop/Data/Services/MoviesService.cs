using eTicketsShop.Data.Base;
using eTicketsShop.Data.ValidationModels;
using eTicketsShop.Data.ViewModels;
using eTicketsShop.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketsShop.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext context;

        public MoviesService(AppDbContext context)
            : base(context)
        {
            this.context = context;
        }

        public async Task AddNewMovieAsync(MovieValidationModel data)
        {
            var movie = new Movie()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageUrl = data.ImageUrl,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                MovieCategory = data.MovieCategory,
            };

            await this.context.Movies.AddAsync(movie);
            await this.context.SaveChangesAsync();

        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await this.context.Movies
                .FirstOrDefaultAsync(n => n.Id == id);

            return movieDetails;
        }

        public async Task UpdateMovieAsync(Movie data)
        {
            var dbMovie = await this.context.Movies.FirstOrDefaultAsync(n => n.Id == data.Id);

            if(dbMovie != null)
            {
                dbMovie.Name = data.Name;
                dbMovie.Description = data.Description;
                dbMovie.Price = data.Price;
                dbMovie.ImageUrl = data.ImageUrl;
                dbMovie.StartDate = data.StartDate;
                dbMovie.EndDate = data.EndDate;
                dbMovie.MovieCategory = data.MovieCategory;

                await this.context.SaveChangesAsync();
            }
        }
    }
}
