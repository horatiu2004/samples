using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WebApplication1.Models
{
    public enum UserType
    {
        [Description("Standard")]
        Standard = 1,
        [Description("PowerUser")]
        PowerUser,
        [Description("Admin")]
        Admin
    }

    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
    }
}
