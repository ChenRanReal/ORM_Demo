using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Comments");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.FatherId).HasColumnName("FatherId");
            this.Property(t => t.ArticleId).HasColumnName("ArticleId");
            this.Property(t => t.PostTime).HasColumnName("PostTime");

            // Relationships
            this.HasRequired(t => t.Article)
                .WithMany(t => t.Comments)
                .HasForeignKey(d => d.ArticleId);

        }
    }
}
