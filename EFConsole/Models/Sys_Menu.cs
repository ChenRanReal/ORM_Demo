using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Sys_Menu
    {
        public Sys_Menu()
        {
            this.Sys_Role = new List<Sys_Role>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FatherId { get; set; }
        public string MetaParameter { get; set; }
        public string Url { get; set; }
        public int DisplayOrder { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<Sys_Role> Sys_Role { get; set; }
    }
}
