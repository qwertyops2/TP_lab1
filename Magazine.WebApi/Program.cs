using Magazine.Core.Services;
using Magazine.WebApi;
using Magazine.WebApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();                              
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddDbContext<DbInformation>(options => options.UseSqlite("Data Source=magazine.db"));
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();