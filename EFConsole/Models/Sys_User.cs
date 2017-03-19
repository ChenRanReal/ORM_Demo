using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Sys_User
    {
        public Sys_User()
        {
            this.Sys_Post = new List<Sys_Post>();
        }

        public int Id { get; set; }
        public string LoginName { get; set; }
        public string UserName { get; set; }
        public int Depart_Id { get; set; }
        public virtual Sys_Department Sys_Department { get; set; }
        public virtual ICollection<Sys_Post> Sys_Post { get; set; }
    }
}
