using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentCourseServices
    {
        public static List<StudentCourseDTO> Get()
        {
            var data = DataAccessFactory.StudentCourseData().Get();
            return Convert(data);
        }

        public static StudentCourseDTO Get(int id)
        {
            return Convert(DataAccessFactory.StudentCourseData().Get(id));
        }

        public static bool Create(StudentCourseDTO StudentCourse)
        {
            var data = Convert(StudentCourse);
            return DataAccessFactory.StudentCourseData().Insert(data);
        }

        public static bool Update(StudentCourseDTO StudentCourse)
        {
            var data = Convert(StudentCourse);
            return DataAccessFactory.StudentCourseData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.StudentCourseData().Delete(id);
        }


        static List<StudentCourseDTO> Convert(List<StudentCourse> StudentCourse)
        {
            var data = new List<StudentCourseDTO>();
            foreach (var cm in StudentCourse)
            {
                data.Add(new StudentCourseDTO()
                {
                    Id = cm.Id,
                    StudentId = cm.StudentId,
                    Student = cm.Student,
                    CourseId = cm.CourseId,
                    Course = cm.Course

    });
            }

            return data;
        }

        static StudentCourseDTO Convert(StudentCourse cm)
        {
            return new StudentCourseDTO()
            {
                Id = cm.Id,
                StudentId = cm.StudentId,
                Student = cm.Student,
                CourseId = cm.CourseId,
                Course = cm.Course
            };
        }

        static StudentCourse Convert(StudentCourseDTO cm)
        {
            return new StudentCourse()
            {
                Id = cm.Id,
                StudentId = cm.StudentId,
                Student = cm.Student,
                CourseId = cm.CourseId,
                Course = cm.Course
            };
        }
    }
}
