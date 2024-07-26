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
        Task<bool> AddNewUser(Member user);

        Task<Member> UpdateUser(Member user);

        Task DeleteUser(Member user);

        Task<Member> GetUserById(long id);

        Task<Member> GetUserByName(string name);

        Task<Member> GetUserByEmail(string email);

      //  Task<List<Member>> GetAllUsers();
    }
}