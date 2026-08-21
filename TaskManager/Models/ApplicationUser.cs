using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TaskManager.Models;

public class ApplicationUser : IdentityUser
{
  
   public string? DisplayName{get;set;}
   public DateTime? CreatedAt{get;set;}
   public ICollection<TaskItem>? Tasks { get; set; }

}