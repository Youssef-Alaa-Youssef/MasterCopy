using Factory.DAL.Models.Documentation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Factory.DAL.Configurations.Documents
{
    public class APIDocConfiguration : IEntityTypeConfiguration<APIDoc>
    {
        public void Configure(EntityTypeBuilder<APIDoc> builder)
        {
            builder.ToTable("APIDocs", "docs")
                .HasComment("Stores API documentation entries");

            builder.HasKey(d => d.Id)
                .HasName("PK_APIDocs");

            builder.Property(d => d.Title)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("Title of the API endpoint");

            builder.Property(d => d.IsPublic)
                .IsRequired()
                .HasDefaultValue(false)
                .HasComment("Indicates if the API is publicly documented");

            builder.Property(d => d.Method)
                .IsRequired()
                .HasMaxLength(10)
                .HasConversion(
                    v => v.ToUpper(),
                    v => v.ToUpper())
                .HasComment("HTTP method (GET, POST, PUT, etc.)");

            builder.Property(d => d.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()")
                .HasComment("Timestamp when the documentation was created");

            // Indexes
            builder.HasIndex(d => d.Title)
                .HasDatabaseName("IX_APIDocs_Title");

            builder.HasIndex(d => new { d.Method, d.Endpoint })
                .IsUnique()
                .HasDatabaseName("UX_APIDocs_Method_Endpoint");

            builder.HasIndex(d => d.IsPublic)
                .HasDatabaseName("IX_APIDocs_IsPublic");
        }
    }

    public class APIParameterConfiguration : IEntityTypeConfiguration<APIParameter>
    {
        public void Configure(EntityTypeBuilder<APIParameter> builder)
        {
            builder.ToTable("APIParameters", "docs")
                .HasComment("Stores parameter definitions for API endpoints");

            builder.HasKey(p => p.Id)
                .HasName("PK_APIParameters");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasComment("Parameter name (primary language)");

            builder.Property(p => p.Required)
                .IsRequired()
                .HasDefaultValue(false)
                .HasComment("Indicates if the parameter is required");

            // Relationships
            builder.HasOne(p => p.APIDoc)
                .WithMany(d => d.ParametersList)
                .HasForeignKey(p => p.APIDocId)
                .HasConstraintName("FK_APIParameters_APIDocs")
                .OnDelete(DeleteBehavior.Cascade);

            // Indexes
            builder.HasIndex(p => p.APIDocId)
                .HasDatabaseName("IX_APIParameters_APIId");
        }
    }

    public class APIResponseConfiguration : IEntityTypeConfiguration<APIResponse>
    {
        public void Configure(EntityTypeBuilder<APIResponse> builder)
        {
            builder.ToTable("APIResponses", "docs")
                .HasComment("Stores response definitions for API endpoints");

            builder.HasKey(r => r.Id)
                .HasName("PK_APIResponses");

            builder.Property(r => r.StatusCode)
                .IsRequired()
                .HasComment("HTTP status code");

            // Relationships
            builder.HasOne(r => r.APIDoc)
                .WithMany()
                .HasForeignKey(r => r.APIDocId)
                .HasConstraintName("FK_APIResponses_APIDocs")
                .OnDelete(DeleteBehavior.Cascade);

            // Indexes
            builder.HasIndex(r => r.APIDocId)
                .HasDatabaseName("IX_APIResponses_APIId");

            builder.HasIndex(r => r.StatusCode)
                .HasDatabaseName("IX_APIResponses_StatusCode");
        }
    }
}