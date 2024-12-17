using Microsoft.EntityFrameworkCore;
using TimeToDo.API.DataAccess.Configuration;
using TimeToDo.Models.Models;

namespace TimeToDo.API.DataAccess;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<ApplicationUser> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
    }
}