using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
   public class user
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<userroles> userRoles { get; set; }
    }
}
