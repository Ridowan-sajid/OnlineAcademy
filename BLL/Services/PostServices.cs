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
    public class PostServices
    {
        public static List<PostDTO> Get()
        {
            var data = DataAccessFactory.PostData().Get();
            return Convert(data);
        }

        public static PostDTO Get(int id)
        {
            return Convert(DataAccessFactory.PostData().Get(id));
        }

        public static bool Create(PostDTO Post)
        {
            var data = Convert(Post);
            return DataAccessFactory.PostData().Insert(data);
        }

        public static bool Update(PostDTO Post)
        {
            var data = Convert(Post);
            return DataAccessFactory.PostData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.PostData().Delete(id);
        }


        static List<PostDTO> Convert(List<Post> Post)
        {
            var data = new List<PostDTO>();
            foreach (var cm in Post)
            {
                data.Add(new PostDTO()
                {
                    Id = cm.Id,
                    Title = cm.Title,
                    Details = cm.Details,
                    Date = cm.Date,
                    CommunityId = (int)cm.CommunityId,
                    /*Community = cm.Community,*/
                    UserId = (int)cm.UserId,
                   /* Student = cm.Student,*/
                   /* TeacherId = (int)cm.TeacherId,*/
                    /*Teacher = cm.Teacher,*/
                    /*Comments=cm.Comments*/
                });
            }

            return data;
        }

        static PostDTO Convert(Post cm)
        {
            return new PostDTO()
            {
                Id = cm.Id,
                Title = cm.Title,
                Details = cm.Details,
                Date = cm.Date,
                CommunityId = (int)cm.CommunityId,
                /*Community = cm.Community,*/
                UserId = (int)cm.UserId,
                /*Student = cm.Student,*/
               /* TeacherId = (int)cm.TeacherId,*/
                /*Teacher = cm.Teacher,
                Comments = cm.Comments*/
            };
        }

        static Post Convert(PostDTO cm)
        {
            return new Post()
            {
                Id = cm.Id,
                Title = cm.Title,
                Details = cm.Details,
                Date = cm.Date,
                CommunityId = cm.CommunityId,
                /*Community = cm.Community,*/
                UserId = cm.UserId,
                /*Student = cm.Student,*/
               /* TeacherId = cm.TeacherId,*/
                /*Teacher = cm.Teacher,*/
                /*Comments = cm.Comments*/
            };
        }
    }
}
