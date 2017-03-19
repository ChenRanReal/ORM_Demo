using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class Test_UserOrderMap : EntityTypeConfiguration<Test_UserOrder>
    {
        public Test_UserOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Test_UserOrder");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Test_OrderId).HasColumnName("Test_OrderId");
            this.Property(t => t.Test_UserId).HasColumnName("Test_UserId");

            // Relationships
            this.HasRequired(t => t.Test_Order)
                .WithMany(t => t.Test_UserOrder)
                .HasForeignKey(d => d.Test_OrderId);
            this.HasRequired(t => t.Test_User)
                .WithMany(t => t.Test_UserOrder)
                .HasForeignKey(d => d.Test_UserId);

        }
    }
}
