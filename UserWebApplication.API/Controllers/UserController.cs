using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("GetById/{id:int}")]
        public async Task<User> GetById(int id)
        {
            var user = await _userRepository.GetIdAsync(id);
            return user;
        }

        [HttpPost("Add")]
        public async void Add([FromBody] User user)
        {
            await _userRepository.AddAsync(user);
        }

        [HttpDelete("Delete/{id:int}")]
        public async void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        [HttpPut("Update")]
        public async void Update([FromBody] User user)
        {
            await _userRepository.Update(user);
        }

        [HttpPost("Login")]
        public async Task<User> Login([FromBody] UserDto userDto)
        {
            var user = await _userRepository.Login(userDto);

            if(user != null)
            {
                return user;
            }

            return null;
        }
    }
}
