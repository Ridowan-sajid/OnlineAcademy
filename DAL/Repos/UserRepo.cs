using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IRepo2<User, int, bool>,IAuth<bool>
    {
        public bool Authenticate(string name, string password)
        {
            var data = db.Users.FirstOrDefault(u => u.Name.Equals(name) &&
            u.Password.Equals(password));
            if (data != null) return true;
            return false;
                   
        }

        public bool Delete(int id)
        {
            var data = db.Users.Find(id);
            db.Users.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public User Get(string name, string password)
        {
             var user = (from u in db.Users
                        where u.Name.Equals(name)
                        && u.Password.Equals(password)
                        select u).SingleOrDefault();
            return user;
        }


        public bool Insert(User obj)
        {
            db.Users.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(User obj)
        {
            var data = db.Users.Find(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
