using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Model
{
    public interface IUserRespository
    {
        List<User> GetAllUsers();
        User GetUserById(int Id);
        User AddUser(User user);
    }
}
