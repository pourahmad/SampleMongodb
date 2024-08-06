using MongoDB.Bson;

namespace SampleMongodb.Services.Category;

public class CategoryDto
{
    public ObjectId _id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
}
