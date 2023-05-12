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
    public class UserCommunityServices
    {
        public static List<UserCommunityDTO> Get()
        {
            var data = DataAccessFactory.UserCommunityData().Get();
            return Convert(data);
        }

        public static UserCommunityDTO Get(int id)
        {
            return Convert(DataAccessFactory.UserCommunityData().Get(id));
        }

        public static bool Create(UserCommunityDTO userCommunityDTO)
        {
            var data = Convert(userCommunityDTO);
            return DataAccessFactory.UserCommunityData().Insert(data);
        }

        public static bool Update(UserCommunityDTO userCommunityDTO)
        {
            var data = Convert(userCommunityDTO);
            return DataAccessFactory.UserCommunityData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.UserCommunityData().Delete(id);
        }


        static List<UserCommunityDTO> Convert(List<UserCommunity> StudentCommunity)
        {
            var data = new List<UserCommunityDTO>();
            foreach (var cm in StudentCommunity)
            {
                data.Add(new UserCommunityDTO()
                {
                    Id = cm.Id,
                    UserId = cm.UserId,
                    User = cm.User,
                    CommunityId = cm.CommunityId,
                    Community = cm.Community

                });
            }

            return data;
        }

        static UserCommunityDTO Convert(UserCommunity cm)
        {
            return new UserCommunityDTO()
            {
                Id = cm.Id,
                UserId = cm.UserId,
                User = cm.User,
                CommunityId = cm.CommunityId,
                Community = cm.Community
            };
        }

        static UserCommunity Convert(UserCommunityDTO cm)
        {
            return new UserCommunity()
            {
                Id = cm.Id,
                UserId = cm.UserId,
                User = cm.User,
                CommunityId = cm.CommunityId,
                Community = cm.Community
            };
        }
    }
}
