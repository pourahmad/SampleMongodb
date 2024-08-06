using MongoDB.Bson;
using SampleMongodb.Entities;

namespace SampleMongodb.Services.Category;

public interface ICategoryService
{
    Task<object> GetByIdAsync(ObjectId id);
    Task<object> GetAllAsync(); 

    Task<object> AddAsync(CategoryDto category);
    Task<object> UpdateAsync(CategoryDto entity);
    Task<object> DeleteAsync(ObjectId id);    
}