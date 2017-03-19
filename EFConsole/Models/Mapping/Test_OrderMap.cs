using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class Test_OrderMap : EntityTypeConfiguration<Test_Order>
    {
        public Test_OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Test_Order");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderName).HasColumnName("OrderName");
        }
    }
}
