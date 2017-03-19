using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FatherId { get; set; }
        public string MetaParameter { get; set; }
        public int DisplayOrder { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}
