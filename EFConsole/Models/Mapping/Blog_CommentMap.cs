using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class Blog_CommentMap : EntityTypeConfiguration<Blog_Comment>
    {
        public Blog_CommentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Blog_Comment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.FatherId).HasColumnName("FatherId");
            this.Property(t => t.PostTime).HasColumnName("PostTime");
            this.Property(t => t.Article_Id).HasColumnName("Article_Id");

            // Relationships
            this.HasOptional(t => t.Blog_Article)
                .WithMany(t => t.Blog_Comment)
                .HasForeignKey(d => d.Article_Id);

        }
    }
}
