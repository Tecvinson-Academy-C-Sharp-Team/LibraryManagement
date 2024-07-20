using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Data.Entity;

namespace LibraryManagement.Data.Service
{
    public interface IUserService
    {
        Task<bool> AddNewUser(User user);

        Task<User> UpdateUser(User user);

        Task DeleteUser(User user);

        Task<User> GetUserById(long id);

        Task<User> GetUserByName(string name);

        Task<User> GetUserByEmail(string email);
    }
}