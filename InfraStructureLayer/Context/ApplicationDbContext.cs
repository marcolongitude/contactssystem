using DomainLayer.EntityMapper;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Context;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions options): base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ContactMap());
        base.OnModelCreating(modelBuilder);
    }
}