using eTicketsShop.Models;

namespace eTicketsShop.Data.Services
{
    public interface IUsersService
    {
        Task<IEnumerable<ApplicationUser>> GetAllUsersAsync();
    }
}
