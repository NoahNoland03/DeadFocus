using System.ComponentModel.DataAnnotations;

namespace DeadFocus.Models
{
    public class GoalType

    {
        [Key]
        public int GoalTypeId { get; set; }
        public string GoalTypeName { get; set; }
        public string GoalTypeDescription { get; set; }
        public DateTime GoalTypeDate { get; set; } //date the goal type was created
        public int UserId { get; set; }
        public bool IsActive { get; set; } //is the category active?

    }
}
