using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApplication.Models
{
    public enum UserType
    {
        [Display(Name = "Standard")]
        Standard,
        [Display(Name = "PowerUser")]
        PowerUser,
        [Display(Name = "Admin")]
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
