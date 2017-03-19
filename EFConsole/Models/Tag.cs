using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Tag
    {
        public Tag()
        {
            this.ArticleTags = new List<ArticleTag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
    }
}
