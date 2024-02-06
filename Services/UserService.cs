using ITServiceDesk.Data;
using ITServiceDesk.Interfaces;

namespace ITServiceDesk.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ticket>> GetTicketsByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
