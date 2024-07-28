using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Data.Data;
using LibraryManagement.Data.Entity;
using LibraryManagement.Data.Service;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.BusinessLogic.Service
{
    public class MemberService : IUserService
    {
        private readonly LibraryContext _context;

        public MemberService(LibraryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<bool> AddNewUser(Member user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            try
            {
                _context.Members.Add(user);
                var result = await _context.SaveChangesAsync();
                return result > 0;
            }
            catch (DbUpdateException ex)
            {
               
                throw new InvalidOperationException("An error occurred while adding the user.", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An unexpected error occurred while adding the user.", ex);
            }
        }

            public async Task<Member> UpdateUser(Member user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var existingUser = await _context.Members.FindAsync(user.Id);
            if (existingUser == null)
            {
                throw new InvalidOperationException("User not found");
            }

            // Update properties
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            // Update other properties as needed

            await _context.SaveChangesAsync();
            return existingUser;
        }

        public async Task DeleteUser(Member user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var existingUser = await _context.Members.FindAsync(user.Id);
            if (existingUser == null)
            {
                throw new InvalidOperationException("User not found");
            }

            _context.Members.Remove(existingUser);
            await _context.SaveChangesAsync();
        }

        public async Task<Member> GetUserById(long id)
        {
            var user = await _context.Members.FindAsync(id);
            if (user == null)
            {
                throw new InvalidOperationException("User not found");
            }

            return user;
        }

        public async Task<Member> GetUserByName(string name)
        {
            var user = await _context.Members.FirstOrDefaultAsync(u => u.Name == name);
            if (user == null)
            {
                throw new InvalidOperationException("User not found");
            }

            return user;
        }

        public async Task<Member> GetUserByEmail(string email)
        {
            var user = await _context.Members.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                throw new InvalidOperationException("User not found");
            }

            return user;
        }
    }
}