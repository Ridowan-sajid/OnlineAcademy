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
    public class CourseServices
    {
        public static List<CourseDTO> Get()
        {
            var data = DataAccessFactory.CourseData().Get();
            return Convert(data);
        }

        public static CourseDTO Get(int id)
        {
            return Convert(DataAccessFactory.CourseData().Get(id));
        }

        public static bool Create(CourseDTO Course)
        {
            var data = Convert(Course);
            return DataAccessFactory.CourseData().Insert(data);
        }

        public static bool Update(CourseDTO Course)
        {
            var data = Convert(Course);
            return DataAccessFactory.CourseData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CourseData().Delete(id);
        }


        static List<CourseDTO> Convert(List<Course> Course)
        {
            var data = new List<CourseDTO>();
            foreach (var cm in Course)
            {
                data.Add(new CourseDTO()
                {
                    Id = cm.Id,
                    Name = cm.Name,
                    /*TeacherId = cm.TeacherId,*/
                    Price = cm.Price,
                    UserCourses = cm.UserCourses,

                });
            }

            return data;
        }

        static CourseDTO Convert(Course cm)
        {
            return new CourseDTO()
            {
                Id = cm.Id,
                Name = cm.Name,
                /*TeacherId = cm.TeacherId,*/
                Price = cm.Price,
                UserCourses = cm.UserCourses,
            };
        }

        static Course Convert(CourseDTO cm)
        {
            return new Course()
            {
                Id = cm.Id,
                Name = cm.Name,
                /*TeacherId = cm.TeacherId,*/
                Price = cm.Price,
                UserCourses = cm.UserCourses,
            };
        }
    }
}
