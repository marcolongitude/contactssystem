using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.EntityMapper;

public class ContactMap: IEntityTypeConfiguration<Contacts> 
{
    public void Configure(EntityTypeBuilder<Contacts> builder)
    {
        builder.HasKey(c => c.Id)
            .HasName("id");

        builder.Property(c => c.Id).ValueGeneratedOnAdd()
            .HasColumnName("id")
            .HasColumnType("INT");

        builder.Property(c => c.Name)
            .HasColumnName("name")
            .HasColumnType("NVARCHAR(100)")
            .IsRequired();

        builder.Property(c => c.Telephone)
            .HasColumnName("telephone")
            .HasColumnType("NVARCHAR(12)")
            .IsRequired();

        builder.Property(c => c.Enterprise)
            .HasColumnName("enterprise")
            .HasColumnType("NVARCHAR(100)");

        builder.Property(c => c.IsActive)
            .HasColumnName("isActive")
            .HasColumnType("TINYINT")
            .IsRequired();
    }
}