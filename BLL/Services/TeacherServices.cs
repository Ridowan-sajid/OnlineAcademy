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
    public class TeacherServices
    {
        public static List<TeacherDTO> Get()
        {
            var data = DataAccessFactory.TeacherData().Get();
            return Convert(data);
        }

        public static TeacherDTO Get(int id)
        {
            return Convert(DataAccessFactory.TeacherData().Get(id));
        }

        public static bool Create(TeacherDTO Teacher)
        {
            var data = Convert(Teacher);
            return DataAccessFactory.TeacherData().Insert(data);
        }

        public static bool Update(TeacherDTO Teacher)
        {
            var data = Convert(Teacher);
            return DataAccessFactory.TeacherData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.TeacherData().Delete(id);
        }


        static List<TeacherDTO> Convert(List<Teacher> Teacher)
        {
            var data = new List<TeacherDTO>();
            foreach (var cm in Teacher)
            {
                data.Add(new TeacherDTO()
                {
                    Id = cm.Id,
                    Name = cm.Name,
                    Age = cm.Age,
                    Phone = cm.Phone,
                    Gmail = cm.Gmail,
                    Gender = cm.Gender,
                    JoinDate = cm.JoinDate,
                    Education = cm.Education,
                    InterestedCourse = cm.InterestedCourse,
                    Role = cm.Role,
                    Courses = cm.Courses,
                    Posts = cm.Posts,
                    Comments = cm.Comments






    });
            }

            return data;
        }

        static TeacherDTO Convert(Teacher cm)
        {
            return new TeacherDTO()
            {
                Id = cm.Id,
                Name = cm.Name,
                Age = cm.Age,
                Phone = cm.Phone,
                Gmail = cm.Gmail,
                Gender = cm.Gender,
                JoinDate = cm.JoinDate,
                Education = cm.Education,
                InterestedCourse = cm.InterestedCourse,
                Role = cm.Role,
                Courses = cm.Courses,
                Posts = cm.Posts,
                Comments = cm.Comments
            };
        }

        static Teacher Convert(TeacherDTO cm)
        {
            return new Teacher()
            {
                Id = cm.Id,
                Name = cm.Name,
                Age = cm.Age,
                Phone = cm.Phone,
                Gmail = cm.Gmail,
                Gender = cm.Gender,
                JoinDate = cm.JoinDate,
                Education = cm.Education,
                InterestedCourse = cm.InterestedCourse,
                Role = cm.Role,
                Courses = cm.Courses,
                Posts = cm.Posts,
                Comments = cm.Comments
            };
        }
    }
}
