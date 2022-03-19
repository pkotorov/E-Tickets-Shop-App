using eTicketsShop.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketsShop.Data.Services
{
    public class UsersService : IUsersService
    {
        private readonly AppDbContext context;

        public UsersService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsersAsync()
        {
            return await this.context.Users.ToListAsync();
        }
    }
}
