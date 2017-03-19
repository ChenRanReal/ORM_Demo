using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class Sys_RoleMap : EntityTypeConfiguration<Sys_Role>
    {
        public Sys_RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("Sys_Role");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
        }
    }
}
