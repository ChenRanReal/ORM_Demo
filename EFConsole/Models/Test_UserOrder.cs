using System;
using System.Collections.Generic;

namespace EFConsole.Models
{
    public partial class Test_UserOrder
    {
        public int Id { get; set; }
        public int Test_OrderId { get; set; }
        public int Test_UserId { get; set; }
        public virtual Test_Order Test_Order { get; set; }
        public virtual Test_User Test_User { get; set; }
    }
}
