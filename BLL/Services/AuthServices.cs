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
                var token = new Token();
                token.UserId = name;
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
    }
}
