using AndelaSchool.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndelaSchool.Infra.Data.Configurations
{
    public class EntityConfiguration<TEntity> where TEntity : Entity
    {
        public void DefaultConfigs(EntityTypeBuilder<TEntity> builder, string tableName)
        {
            builder.ToTable(tableName);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedAt).IsRequired();
        }
    }
}