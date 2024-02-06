using ITServiceDesk.Data;

namespace ITServiceDesk.Interfaces
{
    public interface ITicketService
    {
        Task<List<Ticket>> GetAllTicketsAsync();
        Task<Ticket> GetTicketByIdAsync(int ticketId);
        Task<Ticket> CreateTicketAsync(Ticket ticket);
        Task UpdateTicketAsync(Ticket ticket);
        Task DeleteTicketAsync(int ticketId);
        Task ChangeTicketStatusAsync(int ticketId, int statusId);
        Task ChangeTicketPriorityAsync(int ticketId, int priorityId);
    }
}
