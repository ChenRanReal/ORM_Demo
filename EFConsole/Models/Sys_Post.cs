using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Sys_Post
    {
        public Sys_Post()
        {
            this.Sys_Role = new List<Sys_Role>();
            this.Sys_User = new List<Sys_User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public int Depart_Id { get; set; }
        public virtual Sys_Department Sys_Department { get; set; }
        public virtual ICollection<Sys_Role> Sys_Role { get; set; }
        public virtual ICollection<Sys_User> Sys_User { get; set; }
    }
}
