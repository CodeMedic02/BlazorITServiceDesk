using System.ComponentModel.DataAnnotations;

namespace ITServiceDesk.Data
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int StatusId { get; set; }
        public TicketStatus Status { get; set; }
        public int PriorityId { get; set; }
        public TicketPriority Priority { get; set; }
        public string UserId { get; set; }

        public ICollection<TicketComment> Comments { get; set; }
    }
}
