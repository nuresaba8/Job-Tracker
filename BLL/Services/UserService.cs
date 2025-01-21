using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>();
            });
            return new Mapper(config);
        }

        public static string Login(UserDTO o)
        {
            var repo = DataAccessFactory.UserData();
            var finalData = GetMapper().Map<User>(o);
            var user = repo.Login(finalData);

            if (user.UserRole == 1)
            {
                return "Admin";
            }
            else if (user.UserRole == 2)
            {
                return "Hiring Manager";
            }
            else
            {
                return "Candidate";
            }

        }
    }
}
