using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Article
    {
        public Article()
        {
            this.ArticleTags = new List<ArticleTag>();
            this.Comments = new List<Comment>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public System.DateTime PostTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int Count { get; set; }
        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
