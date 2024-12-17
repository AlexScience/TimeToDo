using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeToDo.Models.Models;

namespace TimeToDo.API.DataAccess.Configuration;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.ToTable("users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.FullName)
            .HasColumnType("varchar")
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(u => u.UserName)
            .HasColumnType("varchar")
            .HasMaxLength(256)
            .IsRequired();

        builder.HasIndex(u => u.UserName).IsUnique();

        builder.Property(u => u.Email)
            .HasColumnType("varchar")
            .HasMaxLength(256)
            .IsRequired();

        builder.HasIndex(u => u.Email).IsUnique();
    }
}