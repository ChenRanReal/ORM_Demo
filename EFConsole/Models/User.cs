using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
