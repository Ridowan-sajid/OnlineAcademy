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
    public class StudentCommunityServices
    {
        public static List<StudentCommunityDTO> Get()
        {
            var data = DataAccessFactory.StudentCommunityData().Get();
            return Convert(data);
        }

        public static StudentCommunityDTO Get(int id)
        {
            return Convert(DataAccessFactory.StudentCommunityData().Get(id));
        }

        public static bool Create(StudentCommunityDTO StudentCommunity)
        {
            var data = Convert(StudentCommunity);
            return DataAccessFactory.StudentCommunityData().Insert(data);
        }

        public static bool Update(StudentCommunityDTO StudentCommunity)
        {
            var data = Convert(StudentCommunity);
            return DataAccessFactory.StudentCommunityData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.StudentCommunityData().Delete(id);
        }


        static List<StudentCommunityDTO> Convert(List<StudentCommunity> StudentCommunity)
        {
            var data = new List<StudentCommunityDTO>();
            foreach (var cm in StudentCommunity)
            {
                data.Add(new StudentCommunityDTO()
                {
                    Id = cm.Id,
                    StudentId = cm.StudentId,
                    Student = cm.Student,
                    CommunityId = cm.CommunityId,
                    Community = cm.Community

                });
            }

            return data;
        }

        static StudentCommunityDTO Convert(StudentCommunity cm)
        {
            return new StudentCommunityDTO()
            {
                Id = cm.Id,
                StudentId = cm.StudentId,
                Student = cm.Student,
                CommunityId = cm.CommunityId,
                Community = cm.Community
            };
        }

        static StudentCommunity Convert(StudentCommunityDTO cm)
        {
            return new StudentCommunity()
            {
                Id = cm.Id,
                StudentId = cm.StudentId,
                Student = cm.Student,
                CommunityId = cm.CommunityId,
                Community = cm.Community
            };
        }
    }
}
