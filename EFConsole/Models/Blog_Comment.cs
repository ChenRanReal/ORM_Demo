using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Blog_Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public int FatherId { get; set; }
        public System.DateTime PostTime { get; set; }
        public Nullable<int> Article_Id { get; set; }
        public virtual Blog_Article Blog_Article { get; set; }
    }
}
