using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class Blog_ArticleMap : EntityTypeConfiguration<Blog_Article>
    {
        public Blog_ArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Blog_Article");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.PostTime).HasColumnName("PostTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.Count).HasColumnName("Count");

            // Relationships
            this.HasMany(t => t.Blog_Tag)
                .WithMany(t => t.Blog_Article)
                .Map(m =>
                    {
                        m.ToTable("Blog_ArticleBlog_Tag");
                        m.MapLeftKey("Blog_Article_Id");
                        m.MapRightKey("Blog_Tag_Id");
                    });


        }
    }
}
