using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Sys_Department
    {
        public Sys_Department()
        {
            this.Sys_Post = new List<Sys_Post>();
            this.Sys_User = new List<Sys_User>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FatherId { get; set; }
        public int DisplayOrder { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<Sys_Post> Sys_Post { get; set; }
        public virtual ICollection<Sys_User> Sys_User { get; set; }
    }
}
