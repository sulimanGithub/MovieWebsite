using MovieWebsite.Data.Base;
using MovieWebsite.Data.ViewModels;
using MovieWebsite.Models;

namespace MovieWebsite.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdown> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovie data);

        Task UpdateMovieAsync(NewMovie data);
    }
}
