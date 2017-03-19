using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class ArticleTagMap : EntityTypeConfiguration<ArticleTag>
    {
        public ArticleTagMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ArticleTags");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ArticleId).HasColumnName("ArticleId");
            this.Property(t => t.TagId).HasColumnName("TagId");

            // Relationships
            this.HasRequired(t => t.Article)
                .WithMany(t => t.ArticleTags)
                .HasForeignKey(d => d.ArticleId);
            this.HasRequired(t => t.Tag)
                .WithMany(t => t.ArticleTags)
                .HasForeignKey(d => d.TagId);

        }
    }
}
