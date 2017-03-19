using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class RD_Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        public int Native { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FamilyNumber { get; set; }
        public string EmailAddress { get; set; }
        public string QQNumber { get; set; }
        public int Education { get; set; }
        public string Major { get; set; }
        public string GraduateSchool { get; set; }
        public int PoliticalStatus { get; set; }
        public int Department { get; set; }
        public int PositionCall { get; set; }
        public System.DateTime EntryDate { get; set; }
        public System.DateTime PositiveDate { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> BirthYinDate { get; set; }
    }
}
