using ITServiceDesk.Data;
using ITServiceDesk.Interfaces;

namespace ITServiceDesk.Services
{
    public class TicketService : ITicketService
    {
        private readonly ApplicationDbContext _context;

        public TicketService(ApplicationDbContext context)
        {
            _context = context;
        }

        Task ITicketService.ChangeTicketPriorityAsync(int ticketId, int priorityId)
        {
            throw new NotImplementedException();
        }

        Task ITicketService.ChangeTicketStatusAsync(int ticketId, int statusId)
        {
            throw new NotImplementedException();
        }

        Task<Ticket> ITicketService.CreateTicketAsync(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        Task ITicketService.DeleteTicketAsync(int ticketId)
        {
            throw new NotImplementedException();
        }

        Task<List<Ticket>> ITicketService.GetAllTicketsAsync()
        {
            throw new NotImplementedException();
        }

        Task<Ticket> ITicketService.GetTicketByIdAsync(int ticketId)
        {
            throw new NotImplementedException();
        }

        Task ITicketService.UpdateTicketAsync(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
