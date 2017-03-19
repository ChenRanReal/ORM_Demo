using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Test_User
    {
        public Test_User()
        {
            this.Test_UserOrder = new List<Test_UserOrder>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Test_UserOrder> Test_UserOrder { get; set; }
    }
}
