using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Database;
using TheReddit.Entities;

namespace TheReddit.Services
{
    public class UserDBService
    {
        public ApplicationDBContext Context { get; set; }

        public UserDBService(ApplicationDBContext context)
        {
            Context = context;
        }

        public bool CreateUser(User user)
        {
            if (Context.Users.FirstOrDefault(u => u.NickName.Equals(user.NickName)) is null)
            {
                Context.Users.Add(user);
                Context.SaveChanges();
                return true; 
            }
            else
            {
                return false;
            }
        }

        public bool Login(User user)
        {
            var entity = Context.Users.FirstOrDefault(u => u.NickName.Equals(user.NickName) && u.Password.Equals(user.Password));
            return !(entity is null);
        }
    }
}
