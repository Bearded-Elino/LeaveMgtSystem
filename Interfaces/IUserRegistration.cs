using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Interfaces
{
    public interface IUserRegistration
    {
        Task<User> GetUserByUsernameAsync (string username);
        Task AddUserAsync(User user);
    }
}