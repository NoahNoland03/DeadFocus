using System.ComponentModel.DataAnnotations;

namespace DeadFocus.Models
{
    public class Quotes
    {
        [Key]
        public int QuoteId { get; set; }
        public string QuoteName { get; set; } = string.Empty;
        public string Quote {  get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
    }
}
