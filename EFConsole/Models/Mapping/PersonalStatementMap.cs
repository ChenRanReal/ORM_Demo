using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class PersonalStatementMap : EntityTypeConfiguration<PersonalStatement>
    {
        public PersonalStatementMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonalStatements");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Money).HasColumnName("Money");
            this.Property(t => t.PostTime).HasColumnName("PostTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.ConsumeTime).HasColumnName("ConsumeTime");
            this.Property(t => t.ConsumeYearAndMonth).HasColumnName("ConsumeYearAndMonth");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
