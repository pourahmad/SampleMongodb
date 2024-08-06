﻿using MongoDB.Bson;

namespace SampleMongodb.Entities;

public class Category
{
    public ObjectId _id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
}
