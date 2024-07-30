using Microsoft.AspNetCore.Mvc;
using UserWebApplication.Core.Entities;
using UserWebApplication.Core.Repositories;
using UserWebApplication.Core.Repositories.Bases;

namespace UserWebApplication.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRoleController
    {
        private readonly IUserRoleRepository _userRoleRepository;

        public UserRoleController(IUserRoleRepository userRoleRepository)
        {
            _userRoleRepository = userRoleRepository;
        }

        [HttpGet("GetAll")]
        public async Task<List<UserRole>> GetAll()
        {
            var userRoles = await _userRoleRepository.GetAllAsync();
            return userRoles;
        }

        [HttpGet("GetById/{id:int}")]
        public async Task<UserRole> GetById(int id)
        {
            var userRoles = await _userRoleRepository.GetIdAsync(id);
            return userRoles;
        }

        [HttpPost("Add")]
        public async void Add([FromBody] UserRole userRole)
        {
            await _userRoleRepository.AddAsync(userRole);
        }

        [HttpDelete("Delete/{id:int}")]
        public async void Delete(int id)
        {
            _userRoleRepository.Delete(id);
        }

        [HttpPut("Update")]
        public async void Update([FromBody] UserRole userRole)
        {
            await _userRoleRepository.Update(userRole);
        }

    }
}
