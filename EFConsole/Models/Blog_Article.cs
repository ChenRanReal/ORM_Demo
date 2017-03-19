using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Blog_Article
    {
        public Blog_Article()
        {
            this.Blog_Comment = new List<Blog_Comment>();
            this.Blog_Tag = new List<Blog_Tag>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public System.DateTime PostTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Blog_Comment> Blog_Comment { get; set; }
        public virtual ICollection<Blog_Tag> Blog_Tag { get; set; }
    }
}
