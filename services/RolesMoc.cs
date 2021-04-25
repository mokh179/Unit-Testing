using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace services
{
   public class RolesMoc:IOperations<role>
    {
        private apiCon _db;

        public RolesMoc(apiCon db)
        {
            _db = db;
        }

        public role Addnew(role obj)
        {
            _db.Roles.Add(obj);
            _db.SaveChanges();
            return obj;
        }

        public bool del(int id)
        {
            _db.Users.Remove(_db.Users.Find(id));
            _db.SaveChanges();
            return true;
        }

        public role Edit(role obj)
        {
            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return obj;
        }

        public List<role> getAll()
        {
            return _db.Roles.ToList<role>();
        }

        public role getByID(int id)
        {
            return _db.Roles.FirstOrDefault(a => a.RoleID == id);
        }

        public bool test(string user, string pass)
        {
            throw new NotImplementedException();
        }
    }
}
