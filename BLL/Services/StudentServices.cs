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
    public class StudentServices
    {
        public static List<StudentDTO> Get()
        {
            var data = DataAccessFactory.StudentData().Get();
            return Convert(data);
        }

        public static StudentDTO Get(int id)
        {
            return Convert(DataAccessFactory.StudentData().Get(id));
        }

        public static bool Create(StudentDTO Student)
        {
            var data = Convert(Student);
            return DataAccessFactory.StudentData().Insert(data);
        }

        public static bool Update(StudentDTO Student)
        {
            var data = Convert(Student);
            return DataAccessFactory.StudentData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.StudentData().Delete(id);
        }


        static List<StudentDTO> Convert(List<Student> Student)
        {
            var data = new List<StudentDTO>();
            foreach (var cm in Student)
            {
                data.Add(new StudentDTO()
                {
                    Id = cm.Id,
                    Name = cm.Name,
                    Age = cm.Age,
                    Phone = cm.Phone,
                    Gmail = cm.Gmail,
                    Gender = cm.Gender,
                    JoinDate = cm.JoinDate,
                    StudentCommunities = cm.StudentCommunities,
                    StudentCourses = cm.StudentCourses,
                    Posts = cm.Posts,
                    Comments = cm.Comments

    });
            }

            return data;
        }

        static StudentDTO Convert(Student cm)
        {
            return new StudentDTO()
            {
                Id = cm.Id,
                Name = cm.Name,
                Age = cm.Age,
                Phone = cm.Phone,
                Gmail = cm.Gmail,
                Gender = cm.Gender,
                JoinDate = cm.JoinDate,
                StudentCommunities = cm.StudentCommunities,
                StudentCourses = cm.StudentCourses,
                Posts = cm.Posts,
                Comments = cm.Comments
            };
        }

        static Student Convert(StudentDTO cm)
        {
            return new Student()
            {
                Id = cm.Id,
                Name = cm.Name,
                Age = cm.Age,
                Phone = cm.Phone,
                Gmail = cm.Gmail,
                Gender = cm.Gender,
                JoinDate = cm.JoinDate,
                StudentCommunities = cm.StudentCommunities,
                StudentCourses = cm.StudentCourses,
                Posts = cm.Posts,
                Comments = cm.Comments
            };
        }
    }
}
