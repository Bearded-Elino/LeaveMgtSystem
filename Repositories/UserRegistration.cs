using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagementSystem.Data;
using LeaveManagementSystem.Interfaces;
using LeaveManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Repositories
{
    public class UserRegistration : IUserRegistration
    {
        private readonly AppDbContext _context;

        public UserRegistration(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddUserAsync(User user)
        {
            _context.users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _context.users.SingleOrDefaultAsync(u => u.UserName == username);
        }
    }
}