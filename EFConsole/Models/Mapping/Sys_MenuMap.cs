using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class Sys_MenuMap : EntityTypeConfiguration<Sys_Menu>
    {
        public Sys_MenuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Sys_Menu");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FatherId).HasColumnName("FatherId");
            this.Property(t => t.MetaParameter).HasColumnName("MetaParameter");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasMany(t => t.Sys_Role)
                .WithMany(t => t.Sys_Menu)
                .Map(m =>
                    {
                        m.ToTable("Sys_RoleSys_Menu");
                        m.MapLeftKey("Sys_Menu_Id");
                        m.MapRightKey("Sys_Role_Id");
                    });


        }
    }
}
