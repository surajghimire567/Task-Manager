using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace TaskManager.Models;

public class TaskItem

{
    public int Id { get; set; }


    [Required]
    [StringLength(111, MinimumLength = 3)]
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? CompletedAt { get; set; }
    public enum TaskPriority
    {
        Low = 0,
        Medium = 1,
        High = 2
    }
    public TaskPriority Priority { get; set; }
    public string? UserId { get; set; }
    public ApplicationUser? User { get; set; }
    [NotMapped]
    public bool IsOverdue => !IsCompleted && DueDate < DateTime.Today;
}