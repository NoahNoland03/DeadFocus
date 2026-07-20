using System.ComponentModel.DataAnnotations;

namespace DeadFocus.Models
{
    public class GoalProgress
    {
        [Key]
        public int ProgressId { get; set; } // Primary key for the GoalProgress entity
        public int GoalId { get; set; } // Foreign key referencing the associated goal
        public int WeekNumber { get; set; } // The week number for which the progress is recorded
        public decimal GoalHourProgress { get; set; }
        public bool IsCompleted { get; set; } // Indicates whether the goal for the week is completed
        public int UserId { get; set; } // Foreign key referencing the associated user

    }
}
