using Laboratory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Laboratory.EFCore.Configurations;
internal class UserConfigurations : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(nameof(User), "AAA");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.PasswordHash).IsRequired();
        builder.Property(u => u.UserName).IsRequired();
        builder.Property(u => u.Age).IsRequired();
        builder.Property(u => u.Gender).IsRequired();
    }
}
