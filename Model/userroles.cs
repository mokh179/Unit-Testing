using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
   public class userroles
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int userID { get; set; }
        [ForeignKey("Role")]
        public int roleID { get; set; }
        public user User { get; set; }
        public role Role { get; set; }
    }
}
