using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagementSystem.DTOs;
using LeaveManagementSystem.Interfaces;
using LeaveManagementSystem.KeyGen;
using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRegistration _userRepo;
        private readonly IMapper _mapper;
        public UserController(IUserRegistration userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
            
        }

        [HttpPost("Register")]

        public async Task<IActionResult> Register(UserRegistrationDto UserDto)
        {
            if(await _userRepo.GetUserByUsernameAsync(UserDto.UserName) != null)
            {
                return BadRequest("username already exists");
            }

            // Below is where we use the automapper
            var user = _mapper.Map<User>(UserDto);
            user.Id = Guid.NewGuid();
            user.Role = "Employee";

            await _userRepo.AddUserAsync(user);
            return Ok("user registration successful");
        }

        [HttpGet("generate")]
        public async Task<IActionResult> GenerateKey()
        {
            string key = KeyGenerator.GenerateKey();
            return Ok(key);
        }
    }
}