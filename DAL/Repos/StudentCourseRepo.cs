using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StudentCourseRepo : Repo, IRepo<StudentCourse, int, bool>
    {
        public bool Delete(int id)
        {
            var data = db.StudentCourses.Find(id);
            db.StudentCourses.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<StudentCourse> Get()
        {
            return db.StudentCourses.ToList();
        }

        public StudentCourse Get(int id)
        {
            return db.StudentCourses.Find(id);
        }

        public bool Insert(StudentCourse obj)
        {
            db.StudentCourses.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(StudentCourse obj)
        {
            var data = db.StudentCourses.Find(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
