﻿using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CommunityServices
    {
        public static List<CommunityDTO> Get()
        {
            var data = DataAccessFactory.CommunityData().Get();
            return Convert(data);
        }

        public static CommunityDTO Get(int id)
        {
            return Convert(DataAccessFactory.CommunityData().Get(id));
        }

        public static bool Create(CommunityDTO community)
        {
            var data = Convert(community);
            return DataAccessFactory.CommunityData().Insert(data);
        }

        public static bool Update(CommunityDTO community)
        {
            var data = Convert(community);
            return DataAccessFactory.CommunityData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CommunityData().Delete(id);
        }


        static List<CommunityDTO> Convert(List<Community> community)
        {
            var data = new List<CommunityDTO>();
            foreach (var cm in community)
            {
                data.Add(new CommunityDTO()
                {
                    Id = cm.Id,
                    Name = cm.Name,
                    StudentCommunities = cm.StudentCommunities,
                    CourseId = cm.CourseId,
                    Posts = cm.Posts,
                    Course=cm.Course

                });
            }

            return data;
        }

        static CommunityDTO Convert(Community cm)
        {
            return new CommunityDTO()
            {
                Id = cm.Id,
                Name = cm.Name,
                StudentCommunities = cm.StudentCommunities,
                CourseId = cm.CourseId,
                Posts = cm.Posts,
                Course = cm.Course
            };
        }

        static Community Convert(CommunityDTO cm)
        {
            return new Community()
            {
                Id = cm.Id,
                Name = cm.Name,
                StudentCommunities = cm.StudentCommunities,
                CourseId = cm.CourseId,
                Posts = cm.Posts,
                Course = cm.Course
            };
        }

    }
}
