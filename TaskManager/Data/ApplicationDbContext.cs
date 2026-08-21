using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;


namespace TaskManager.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<TaskItem> Tasks { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);
    builder.Entity<TaskItem>(e => {
        e.ToTable("Tasks");  
    e.Property(t => t.Title).IsRequired().HasMaxLength(111);
   e.Property(t => t.IsCompleted).HasDefaultValue(false);
e.HasOne(t => t.User)
    .WithMany(u => u.Tasks)
    .HasForeignKey(t => t.UserId)
    .OnDelete(DeleteBehavior.Cascade);
    e.HasIndex(t => t.UserId);
});
}
}