using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class Sys_UserMap : EntityTypeConfiguration<Sys_User>
    {
        public Sys_UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Sys_User");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.LoginName).HasColumnName("LoginName");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Depart_Id).HasColumnName("Depart_Id");

            // Relationships
            this.HasRequired(t => t.Sys_Department)
                .WithMany(t => t.Sys_User)
                .HasForeignKey(d => d.Depart_Id);

        }
    }
}
