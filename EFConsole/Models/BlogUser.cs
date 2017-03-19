using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class BlogUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IsValid { get; set; }
        public string AutoCode { get; set; }
        public string NiceName { get; set; }
    }
}
