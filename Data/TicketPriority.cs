using System.ComponentModel.DataAnnotations;

namespace ITServiceDesk.Data
{
    public class TicketPriority
    {
        [Key]
        public int PriorityId { get; set; }
        public string? PriorityName { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
        
    }
}