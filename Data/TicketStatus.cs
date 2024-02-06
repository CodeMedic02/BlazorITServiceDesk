using System.ComponentModel.DataAnnotations;

namespace ITServiceDesk.Data
{
    public class TicketStatus
    {
       [Key]
       public int StatusId { get; set; }
       public string? StatusName { get; set; }
       public ICollection<Ticket>? Tickets { get; set; }
    }
}