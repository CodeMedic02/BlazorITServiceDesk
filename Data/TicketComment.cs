using System.ComponentModel.DataAnnotations;

namespace ITServiceDesk.Data
{
    public class TicketComment
    {
        [Key]
        public int TicketCommentId { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TicketId { get; set; }
        public Ticket? Ticket { get; set; }
        public string? UserId { get; set; }
    }
}