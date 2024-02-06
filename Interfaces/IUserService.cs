using ITServiceDesk.Data;

namespace ITServiceDesk.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> GetUserByIdAsync(string userId);
        Task<List<Ticket>> GetTicketsByUserIdAsync(string userId);


    }
}
