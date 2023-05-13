using AutoMapper;
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
    public class AuthServices
    {
        public static TokenDTO Authenticate(string name, string password)
        {
            var res = DataAccessFactory.AuthData().Authenticate(name, password);

            if (res)
            {

                var user = DataAccessFactory.UserData().Get(name,password);
                var token = new Token();
                token.UserId = user.Id;
                token.CreatedAt = DateTime.Now;
                token.TKey = Guid.NewGuid().ToString();
                var ret = DataAccessFactory.TokenData().Insert(token);
                if(ret != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    var mapped = mapper.Map<TokenDTO>(ret);
                    return mapped;
                }
               
            }
            return null;

        }


        public static bool IsTokenValid(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Get(tkey);
            if (extk != null && extk.DestryedAt == null)
            {
                return true;
            }
            return false;
        }
        public static bool Logout(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Get(tkey);
            extk.DestryedAt = DateTime.Now;
            if (DataAccessFactory.TokenData().Update(extk) != null)
            {
                return true;
            }
            return false;


        }
        public static bool IsAdmin(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Get(tkey);
            if (IsTokenValid(tkey) && extk.User.Role.Equals("Admin"))
            {
                return true;
            }
            return false;
        }

        public static bool IsTeacher(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Get(tkey);
            if (IsTokenValid(tkey) && extk.User.Role.Equals("Teacher"))
            {
                return true;
            }
            return false;
        }
    }
}
