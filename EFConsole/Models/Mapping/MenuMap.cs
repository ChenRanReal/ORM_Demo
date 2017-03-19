using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class MenuMap : EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(20);

            this.Property(t => t.Controller)
                .HasMaxLength(40);

            this.Property(t => t.Action)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("Menus");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FatherId).HasColumnName("FatherId");
            this.Property(t => t.MetaParameter).HasColumnName("MetaParameter");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            this.Property(t => t.Controller).HasColumnName("Controller");
            this.Property(t => t.Action).HasColumnName("Action");
        }
    }
}
