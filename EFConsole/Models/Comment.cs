using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public int FatherId { get; set; }
        public int ArticleId { get; set; }
        public System.DateTime PostTime { get; set; }
        public virtual Article Article { get; set; }
    }
}
