using LibraryManagement.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Service
{
        public interface IRepository
        {
            Task<bool> AddNewMember(Member member);
            Task<bool> AddNewLoan(Loan loan);

            Task<Member> UpdateMember(Member member);
            Task<Loan> UpdateLoan(Loan loan);
            Task<Member> DeleteMember(Member member);
            Task<Loan> DeleteLoan(Loan loan);

            Task<Member> GetMemberById(long id);
            Task<Loan> GetLoanById(long id);
            Task<Member> GetMemberByName(string name);

            Task<Member> GetMemberByEmail(string email);
        }
    }