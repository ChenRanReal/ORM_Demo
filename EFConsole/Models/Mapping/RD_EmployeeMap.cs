using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models.Mapping
{
    public class RD_EmployeeMap : EntityTypeConfiguration<RD_Employee>
    {
        public RD_EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("RD_Employee");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Native).HasColumnName("Native");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.FamilyNumber).HasColumnName("FamilyNumber");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.QQNumber).HasColumnName("QQNumber");
            this.Property(t => t.Education).HasColumnName("Education");
            this.Property(t => t.Major).HasColumnName("Major");
            this.Property(t => t.GraduateSchool).HasColumnName("GraduateSchool");
            this.Property(t => t.PoliticalStatus).HasColumnName("PoliticalStatus");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.PositionCall).HasColumnName("PositionCall");
            this.Property(t => t.EntryDate).HasColumnName("EntryDate");
            this.Property(t => t.PositiveDate).HasColumnName("PositiveDate");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.BirthYinDate).HasColumnName("BirthYinDate");
        }
    }
}
