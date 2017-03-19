using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class Sys_PostMap : EntityTypeConfiguration<Sys_Post>
    {
        public Sys_PostMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Sys_Post");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            this.Property(t => t.Depart_Id).HasColumnName("Depart_Id");

            // Relationships
            this.HasMany(t => t.Sys_Role)
                .WithMany(t => t.Sys_Post)
                .Map(m =>
                    {
                        m.ToTable("Sys_PostSys_Role");
                        m.MapLeftKey("Sys_Post_Id");
                        m.MapRightKey("Sys_Role_Id");
                    });

            this.HasMany(t => t.Sys_User)
                .WithMany(t => t.Sys_Post)
                .Map(m =>
                    {
                        m.ToTable("Sys_UserSys_Post");
                        m.MapLeftKey("Sys_Post_Id");
                        m.MapRightKey("Sys_User_Id");
                    });

            this.HasRequired(t => t.Sys_Department)
                .WithMany(t => t.Sys_Post)
                .HasForeignKey(d => d.Depart_Id);

        }
    }
}
