using Microsoft.AspNetCore.Mvc;
using UserWebApplication.Core.Entities;
using UserWebApplication.Core.Repositories;
using UserWebApplication.Core.Repositories.Bases;

namespace UserWebApplication.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestCategoryController
    {
        private readonly IRequestCategoryRepository _RequestCategoryRepository;

        public RequestCategoryController(IRequestCategoryRepository RequestCategoryRepository)
        {
            _RequestCategoryRepository = RequestCategoryRepository;
        }

        [HttpGet("GetAll")]
        public async Task<List<RequestCategory>> GetAll()
        {
            var RequestCategorys = await _RequestCategoryRepository.GetAllAsync();
            return RequestCategorys;
        }

        [HttpGet("GetById/{id:int}")]
        public async Task<RequestCategory> GetById(int id)
        {
            var RequestCategory = await _RequestCategoryRepository.GetIdAsync(id);
            return RequestCategory;
        }

        [HttpPost("Add")]
        public async void Add([FromBody] RequestCategory RequestCategory)
        {
            await _RequestCategoryRepository.AddAsync(RequestCategory);
        }

        [HttpDelete("Delete/{id:int}")]
        public async void Delete(int id)
        {
            _RequestCategoryRepository.Delete(id);
        }

        [HttpPut("Update")]
        public async void Update([FromBody] RequestCategory RequestCategory)
        {
            await _RequestCategoryRepository.Update(RequestCategory);
        }
    }
}
