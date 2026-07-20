using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;

namespace DeadFocus.Models
{
    public class Goals

    {
        [Key]
        public int GoalId { get; set; }
        public string GoalName { get; set; }
        public decimal GoalHoursAmount { get; set; } 
        public int UserId { get; set; } //foreign key to the user table
        public bool GoalStatusId { get; set; } 
        public DateTime StartDate { get; set; } //date the goal was created
        public DateTime DateTime { get; set; } //date the goal was completed'
        public int GoalTypeId { get; set; } //foreign key to the goal type table
    }
}
