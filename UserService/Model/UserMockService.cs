using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Model
{
    public class UserMockService : IUserRespository
    {
        private static List<User> users;
        private int count = 3;

        public UserMockService()
        {
            users = new List<User>();
            users.Add(new User() { Id = 1, Name = "Magesh", Email = "a@b.com" });
            users.Add(new User() { Id = 2, Name = "Arun", Email = "ab@ab.com" });
            users.Add(new User() { Id = 3, Name = "Varun", Email = "ac@ac.com" });
        }
        public User AddUser(User user)
        {
            user.Id = ++count;
            users.Add(user);
            return user;
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserById(int Id)
        {
            return users.FirstOrDefault(x => x.Id == Id);
        }
    }
}
