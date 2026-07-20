using System.ComponentModel.DataAnnotations;

namespace DeadFocus.Models
{
    public class Sessions
    {
        [Key]
        public int SessionId { get; set; }
        public int SessionTime { get; set; } // Duration of the session in seconds
        public DateTime DateOfSession { get; set; }
        public int ProgressId { get; set; }
        public int UserId { get; set; }

    }
}
