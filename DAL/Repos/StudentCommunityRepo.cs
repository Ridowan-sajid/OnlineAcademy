using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StudentCommunityRepo : Repo, IRepo<StudentCommunity, int, bool>
    {
        public bool Delete(int id)
        {
            var data = db.StudentCommunities.Find(id);
            db.StudentCommunities.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<StudentCommunity> Get()
        {
            return db.StudentCommunities.ToList();
        }

        public StudentCommunity Get(int id)
        {
            return db.StudentCommunities.Find(id);
        }

        public bool Insert(StudentCommunity obj)
        {
            db.StudentCommunities.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(StudentCommunity obj)
        {
            var data = db.StudentCommunities.Find(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
