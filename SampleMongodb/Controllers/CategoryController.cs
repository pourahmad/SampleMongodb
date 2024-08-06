using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using SampleMongodb.Services.Category;

namespace SampleMongodb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController(ICategoryService categoryService) : ControllerBase
    {
        private const string Id = "{id}";
        private const string Name = "{name}";
        private readonly ICategoryService _categoryService = categoryService;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _categoryService.GetAllAsync();

            return Ok(result);
        }

        [HttpGet(Id)]
        public async Task<IActionResult> Get(string id)
        {
            var result = await _categoryService.GetByIdAsync(new ObjectId(id));

            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Post(CategoryDto category)
        {
            var result = await _categoryService.AddAsync(category);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CategoryDto category)
        {
            var result = await _categoryService.UpdateAsync(category);

            return Ok(result);
        }

        [HttpDelete(Id)]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _categoryService.DeleteAsync(new ObjectId(id));

            return Ok(result);
        }
    }
}
