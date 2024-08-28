using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagementSystem.DTOs;
using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Mappers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserRegistrationDto, User>();
        }
    }
}