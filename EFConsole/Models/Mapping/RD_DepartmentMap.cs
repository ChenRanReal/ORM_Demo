using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class RD_DepartmentMap : EntityTypeConfiguration<RD_Department>
    {
        public RD_DepartmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("RD_Department");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
        }
    }
}
