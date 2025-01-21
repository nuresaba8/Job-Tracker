using DAL.EF.Tables;
using DAL.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class UserRepo : Repo, ILoginRepo<User, int, User>
    {
        public User Login(User obj)
        {
            var user = db.Users.FirstOrDefault(u => u.UserEmail == obj.UserEmail && u.UserPassword == obj.UserPassword);
            return user;
        }

    }
}
