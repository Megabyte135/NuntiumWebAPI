using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations
{
    class ArticleEntityTypeConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(u => u.Title).IsRequired();
            builder.Property(u => u.Text).IsRequired();
            builder.Property(u => u.PreviewText).IsRequired();
            builder.Property(u => u.CreationDate).IsRequired();
            builder.Property(u => u.AuthorId).IsRequired();
        }
    }
}
