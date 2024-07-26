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
        Task<Member> AddNewMember(Member member);
        Task<Member> UpdateMember(Member member);
        Task<Member> DeleteMember(Member member);
        Task<Member> GetMemberById(long id);
        Task<Member> GetMemberByName(string name);
        Task<Member> GetMemberByEmail(string email);

        Task<Loan> AddNewLoan(Loan loan);
        Task<Loan> UpdateLoan(Loan loan);
        Task<Loan> DeleteLoan(Loan loan);
        Task<Loan> GetLoanById(long id);

        Task<bool> AddNewUser(User user);
        Task<User> UpdateUser(User user);
        Task <User> DeleteUser(User user);
        Task<User> GetUserById(long id);
        Task<User> GetUserByName(string name);
        Task<User> GetUserByEmail(string email);
    }
}