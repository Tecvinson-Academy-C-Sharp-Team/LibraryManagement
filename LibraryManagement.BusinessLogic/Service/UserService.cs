using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Data.Data;
using LibraryManagement.Data.Entity;
using LibraryManagement.Data.Service;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryManagement.BusinessLogic.Service
{
    public class UserService : IUserService
    {
        public delegate void Notify(string message);

        public event Notify? OnMemberAdded;

        public event Notify? OnMemberUpdated;

        public event Notify OnMemberDeleted;

        public event Notify OnLoanAdded;

        public event Notify OnLoanUpdated;

        public event Notify OnLoadDeleted;

        private Notify notification = new Notify(OnNewMemberAdded);

        public static void OnNewMemberAdded(string member)
        {
            // some things happens here ...

            // raise the book added event here ...
            Console.WriteLine($"A member: {member} was added!");
        }

/*        public async Task<Member> AddMember(Member member)
        {
            LibraryContext.Members.Add(member);

            string msg = $"A member with name: {member.Name} was added to our repository!";
            OnMemberAdded?.Invoke(msg);

            return member;
        }
*/
        public async Task<Member> AddNewMember(Member member)
        {
                throw new NotImplementedException();
        }
        public async Task<Member> UpdateMember(Member member)
        {
            throw new NotImplementedException();
        }
        public async Task<Member> DeleteMember(Member member)
        {
            throw new NotImplementedException();
        }
        public async Task<Member> GetAllMembers(Member member)
        {
            throw new NotImplementedException();
        }
        public async Task<Member> GetMemberById(long memberId)
        {
            throw new NotImplementedException();
        }
        public async Task<Member> GetMemberByName(string name)
        {
            throw new NotImplementedException();
        }
        public async Task<Member> GetMemberByEmail(string email)
        {
                throw new NotImplementedException();
        }

        public async Task<Loan> AddNewLoan(Loan loan)
        {
            throw new NotImplementedException();
        }

        public async Task<Loan> UpdateLoan(Loan loan)
        {
            throw new NotImplementedException();
        }

        public async Task<Loan> DeleteLoan(Loan loan)
        {
            throw new NotImplementedException();
        }

        public async Task<Loan> GetLoanById(long id)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> AddNewUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> DeleteUser(User user)
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