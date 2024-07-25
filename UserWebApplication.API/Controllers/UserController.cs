﻿using Microsoft.AspNetCore.Mvc;
using UserWebApplication.Core.Entities;
using UserWebApplication.Core.Repositories.Bases;

namespace UserWebApplication.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        [HttpGet("GetAll")]
        public async Task<List<User>> GetAll()
        {
            var users = await _userRepository.GetAllAsync();
            return users;
        }

        [HttpPost("Add")]
        public async void Add([FromBody] User user)
        {
            await _userRepository.AddAsync(user);
        }

        [HttpDelete("Delete")]
        public async void Delete([FromBody] int id)
        {
            _userRepository.Delete(id);
        }

        [HttpPut("Update")]
        public async void Update([FromBody] User user)
        {
            await _userRepository.Update(user);
        }
    }
}
