using TianLi_WanXiang_Service.Data;
using TianLi_WanXiang_Service.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext
builder.Services.AddDbContext<ObjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WanXiangContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ObjectContext>();
    context.Database.EnsureCreated();
}

app.UseHttpsRedirection();

//app.UseStaticFiles();

//app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
