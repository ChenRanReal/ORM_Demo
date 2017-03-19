using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class RD_Post
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
