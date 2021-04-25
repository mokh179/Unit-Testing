using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
  public   class role
    {
        [Key]
        public int RoleID { get; set; }
        public string name { get; set; }
        public List<userroles> userRoles { get; set; }
    }
}
