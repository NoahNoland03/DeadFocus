using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeadFocus.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserId {  get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string? Role { get; set; }
        public string? PhoneNumber { get; set; }



    }
}
