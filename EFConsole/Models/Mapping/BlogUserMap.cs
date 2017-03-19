using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class BlogUserMap : EntityTypeConfiguration<BlogUser>
    {
        public BlogUserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("BlogUsers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.AutoCode).HasColumnName("AutoCode");
            this.Property(t => t.NiceName).HasColumnName("NiceName");
        }
    }
}
