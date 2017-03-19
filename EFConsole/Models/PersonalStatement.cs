using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class PersonalStatement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Money { get; set; }
        public System.DateTime PostTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public System.DateTime ConsumeTime { get; set; }
        public string ConsumeYearAndMonth { get; set; }
        public string Remark { get; set; }
    }
}
