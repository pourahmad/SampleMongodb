using Microsoft.EntityFrameworkCore;
using SampleMongodb.Data;
using SampleMongodb.Services.Category;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MongoDbContext>(option =>
    option.UseMongoDB(builder.Configuration.GetConnectionString("MongoDbConnectionString"), builder.Configuration.GetSection("MongoDbName").Value));

builder.Services.AddScoped<ICategoryService, CategoryService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
