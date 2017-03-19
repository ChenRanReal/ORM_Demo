using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Sys_Role
    {
        public Sys_Role()
        {
            this.Sys_Post = new List<Sys_Post>();
            this.Sys_Menu = new List<Sys_Menu>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public virtual ICollection<Sys_Post> Sys_Post { get; set; }
        public virtual ICollection<Sys_Menu> Sys_Menu { get; set; }
    }
}
