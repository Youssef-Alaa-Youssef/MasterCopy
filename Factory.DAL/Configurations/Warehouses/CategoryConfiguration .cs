using Factory.DAL.Enums.Stores;
using Factory.DAL.Models.Warehouses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Factory.DAL.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.NameEn)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.NameAr)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.DescriptionEn)
                .HasMaxLength(250);

            builder.Property(c => c.DescriptionAr)
                .HasMaxLength(250);

            builder.Property(c => c.IsActive)
                .HasDefaultValue(true);

            builder.Property(c => c.CreatedDate)
                .HasDefaultValueSql("GETUTCDATE()"); 

            builder.Property(c => c.UpdatedDate)
                .IsRequired(false);

            builder.Property(c => c.GlassType)
                .HasDefaultValue(GlassProductType.Clear);

            builder.Property(c => c.HasDimensions)
                .HasDefaultValue(false);

            builder.Property(c => c.DefaultWidth)
                .IsRequired(false);

            builder.Property(c => c.DefaultHeight)
                .IsRequired(false);

            builder.Property(c => c.DefaultThickness)
                .IsRequired(false);

            builder.HasOne(c => c.MainWarehouse)
                .WithMany(mw => mw.Categories)
                .HasForeignKey(c => c.MainWarehouseId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.HasIndex(c => c.NameEn)
                .IsUnique();

            builder.HasIndex(c => c.NameAr)
                .IsUnique();

            builder.HasIndex(c => c.MainWarehouseId);
        }
    }
}