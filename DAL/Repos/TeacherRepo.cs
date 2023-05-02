using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TeacherRepo : Repo, IRepo<Teacher, int, bool>
    {
        public bool Delete(int id)
        {
            var data = db.Teachers.Find(id);
            db.Teachers.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Teacher> Get()
        {
            return db.Teachers.ToList();
        }

        public Teacher Get(int id)
        {
            return db.Teachers.Find(id);
        }

        public bool Insert(Teacher obj)
        {

            db.Teachers.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Teacher obj)
        {
            var data = db.Teachers.Find(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
