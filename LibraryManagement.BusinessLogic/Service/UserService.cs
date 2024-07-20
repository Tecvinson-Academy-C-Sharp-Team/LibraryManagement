using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Data.Entity;
using LibraryManagement.Data.Service;

namespace LibraryManagement.BusinessLogic.Service
{
    public class UserService : IUserService
    {
        public async Task<bool> AddNewUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserById(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}