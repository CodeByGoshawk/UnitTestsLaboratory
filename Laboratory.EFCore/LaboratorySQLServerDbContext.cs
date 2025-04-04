using Laboratory.Domain.Abstracts;
using Laboratory.EFCore.Frameworks;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Laboratory.EFCore;
public class LaboratorySQLServerDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        builder.RegisterAllEntities<IDbSetEntity>(typeof(IDbSetEntity).Assembly);

        base.OnModelCreating(builder);
    }
}
