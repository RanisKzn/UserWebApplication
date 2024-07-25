using Microsoft.AspNetCore.Mvc;
using UserWebApplication.Core.Entities;
using UserWebApplication.Core.Repositories;
using UserWebApplication.Core.Repositories.Bases;

namespace UserWebApplication.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController
    {
        private readonly IRequestRepository _RequestRepository;

        public RequestController(IRequestRepository RequestRepository)
        {
            _RequestRepository = RequestRepository;
        }

        [HttpGet("GetAll")]
        public async Task<List<Request>> GetAll()
        {
            var Requests = await _RequestRepository.GetAllAsync();
            return Requests;
        }

        [HttpGet("GetById/{id:int}")]
        public async Task<Request> GetById(int id)
        {
            var Request = await _RequestRepository.GetIdAsync(id);
            return Request;
        }

        [HttpPost("Add")]
        public async void Add([FromBody] Request Request)
        {
            await _RequestRepository.AddAsync(Request);
        }

        [HttpDelete("Delete/{id:int}")]
        public async void Delete(int id)
        {
            _RequestRepository.Delete(id);
        }

        [HttpPut("Update")]
        public async void Update([FromBody] Request Request)
        {
            await _RequestRepository.Update(Request);
        }
    }
}
