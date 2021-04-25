using System;
using System.Collections.Generic;
using System.Text;
using Model;
namespace services
{
    class userRoles

    {
        private apiCon _db;

        public userRoles(apiCon db)
        {
            _db = db;
        }

        public string getRole(int id)
        {
            userroles u=_db.Userroles.Find(id);
            string role = u.roleID.ToString();
            return role;
        }

    }
}
