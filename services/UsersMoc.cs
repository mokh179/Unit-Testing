using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
namespace services
{
    public class UsersMoc:IOperations<user>
    {
        private apiCon _db;

        public UsersMoc(apiCon db)
        {
            _db = db;
        }

        public user Addnew(user obj)
        {
            _db.Users.Add(obj);
            _db.SaveChanges();
            return obj;

        }

        public bool del(int id)
        {
            _db.Users.Remove(_db.Users.FirstOrDefault(a => a.ID == id));
            _db.SaveChanges();
            return true;
        }

        public user Edit(user user)
        {
            _db.Entry<user>(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return user;

        }

        public List<user> getAll()
        {
            return _db.Users.ToList<user>();
        }

        public user getByID(int id)
        {
            return _db.Users.FirstOrDefault(x => x.ID == id);
            //return _db.Users.Find(id);
        }
    }
}
