using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Blog_Tag
    {
        public Blog_Tag()
        {
            this.Blog_Article = new List<Blog_Article>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public virtual ICollection<Blog_Article> Blog_Article { get; set; }
    }
}
