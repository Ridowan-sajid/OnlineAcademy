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
    public class UserServices
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserData().Get();
            return Convert(data);
        }

        public static UserDTO Get(int id)
        {
            return Convert(DataAccessFactory.UserData().Get(id));
        }

        public static bool Create(UserDTO Student)
        {
            var data = Convert(Student);
            return DataAccessFactory.UserData().Insert(data);
        }

        public static bool Update(UserDTO Student)
        {
            var data = Convert(Student);
            return DataAccessFactory.UserData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.UserData().Delete(id);
        }


        static List<UserDTO> Convert(List<User> Student)
        {
            var data = new List<UserDTO>();
            foreach (var cm in Student)
            {
                data.Add(new UserDTO()
                {
                    Id = cm.Id,
                    Name = cm.Name,
                    Age = cm.Age,
                    Phone = cm.Phone,
                    Gmail = cm.Gmail,
                    Gender = cm.Gender,
                    Role = cm.Role,
                    JoinDate = cm.JoinDate,
                    UserCommunities = cm.UserCommunities,
                    UserCourses = cm.UserCourses,
                    Posts = cm.Posts,
                    Comments = cm.Comments

    });
            }

            return data;
        }

        static UserDTO Convert(User cm)
        {
            return new UserDTO()
            {
                Id = cm.Id,
                Name = cm.Name,
                Age = cm.Age,
                Phone = cm.Phone,
                Gmail = cm.Gmail,
                Gender = cm.Gender,
                Role = cm.Role,
                JoinDate = cm.JoinDate,
                UserCommunities = cm.UserCommunities,
                UserCourses = cm.UserCourses,
                Posts = cm.Posts,
                Comments = cm.Comments
            };
        }

        static User Convert(UserDTO cm)
        {
            return new User()
            {
                Id = cm.Id,
                Name = cm.Name,
                Age = cm.Age,
                Phone = cm.Phone,
                Gmail = cm.Gmail,
                Gender = cm.Gender,
                Role = cm.Role,
                JoinDate = cm.JoinDate,
                UserCommunities = cm.UserCommunities,
                UserCourses = cm.UserCourses,
                Posts = cm.Posts,
                Comments = cm.Comments
            };
        }
    }
}
