using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StudentRepo : Repo, IRepo<Student, int, bool>
    {
        public bool Delete(int id)
        {
            var data = db.Students.Find(id);
            db.Students.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Student> Get()
        {
            return db.Students.ToList();
        }

        public Student Get(int id)
        {
            return db.Students.Find(id);
        }

        public bool Insert(Student obj)
        {
            db.Students.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Student obj)
        {
            var data = db.Students.Find(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
